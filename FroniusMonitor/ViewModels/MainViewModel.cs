﻿using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using De.Hochstaetter.Fronius.Contracts;
using De.Hochstaetter.Fronius.Localization;
using De.Hochstaetter.Fronius.Models;
using De.Hochstaetter.FroniusMonitor.Models;
using De.Hochstaetter.FroniusMonitor.Wpf.Commands;
using Microsoft.Win32;

namespace De.Hochstaetter.FroniusMonitor.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel(ISolarSystemService solarSystemService)
        {
            SolarSystemService = solarSystemService;
            ExportSettingsCommand = new NoParameterCommand(ExportSettings);
            LoadSettingsCommand = new NoParameterCommand(LoadSettings);
        }

        public ICommand ExportSettingsCommand { get; }
        public ICommand LoadSettingsCommand { get; }

        internal Dispatcher Dispatcher { get; set; } = null!;

        public ISolarSystemService SolarSystemService { get; }

        private bool includeInverterPower;

        public bool IncludeInverterPower
        {
            get => includeInverterPower;
            set => Set(ref includeInverterPower, value);
        }

        public async Task OnInitialize()
        {
            await SolarSystemService.Start(App.Settings.FroniusConnection, App.Settings.FritzBoxConnection).ConfigureAwait(false);
        }

        private async void LoadSettings()
        {
            var dialog = new OpenFileDialog
            {
                Filter = string.Format(Resources.SettingsFilter, Resources.AppName),
                AddExtension = false, CheckFileExists = true, CheckPathExists = true,
                DereferenceLinks = true, Multiselect = false, ValidateNames = true, Title = Resources.LoadSettings
            };

            var result = dialog.ShowDialog();

            if (!result.HasValue || !result.Value)
            {
                return;
            }

            SolarSystemService.Stop();

            try
            {
                try
                {
                    await Settings.Load(dialog.FileName);
                }
                catch (Exception ex)
                {
                    await Dispatcher.InvokeAsync(() => MessageBox.Show(ex.Message, Resources.Error, MessageBoxButton.OK, MessageBoxImage.Error));
                    return;
                }

                await Settings.Save().ConfigureAwait(false);
            }
            finally
            {
                await SolarSystemService.Start(App.Settings.FroniusConnection, App.Settings.FritzBoxConnection).ConfigureAwait(false);
            }
        }

        private async void ExportSettings()
        {
            var dialog = new SaveFileDialog
            {
                AddExtension = false,
                CheckPathExists = true,
                OverwritePrompt = true,
                Filter = string.Format(Resources.SettingsFilter, Resources.AppName),
                DereferenceLinks = true,
                FileName = Path.GetFileName(App.SettingsFileName),
                Title = Resources.ExportSettings,
                ValidateNames = true,
            };

            var result = dialog.ShowDialog();

            if (!result.HasValue || !result.Value)
            {
                return;
            }

            try
            {
                await Settings.Save(dialog.FileName).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                await Dispatcher.InvokeAsync(() => MessageBox.Show(ex.Message, Resources.Error, MessageBoxButton.OK, MessageBoxImage.Error));
            }
        }
    }
}
