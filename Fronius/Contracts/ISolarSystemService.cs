﻿using De.Hochstaetter.Fronius.Models.Settings;

namespace De.Hochstaetter.Fronius.Contracts
{
    public interface ISolarSystemService
    {
        SolarSystem? SolarSystem { get; }
        WebConnection? WattPilotConnection { get; set; }
        public IToshibaHvacService HvacService { get; }

        public BindableCollection<ISwitchable>? SwitchableDevices { get; }

        public int FroniusUpdateRate { get; set; }
        public double GridPowerSum { get; }
        public double LoadPowerSum { get; }
        public double SolarPowerSum { get; }
        public double StoragePowerSum { get; }
        public double AcPowerSum { get; }
        public double DcPowerSum { get; }
        public double PowerLossSum { get; }
        public double? Efficiency { get; }
        public double? GridPowerAvg { get; }
        public double? LoadPowerAvg { get; }
        public double? StoragePowerAvg { get; }
        public double? SolarPowerAvg { get; }
        public double? PowerLossAvg { get; }
        IList<SmartMeterCalibrationHistoryItem> SmartMeterHistory { get; }

        event EventHandler<SolarDataEventArgs>? NewDataReceived;

        Task Start(WebConnection? inverterConnection, WebConnection? fritzBoxConnection, WebConnection? wattPilotConnection);
        void Stop();
        void SuspendPowerConsumers();
        void ResumePowerConsumers();
        void InvalidateFritzBox();
        Task<IList<SmartMeterCalibrationHistoryItem>> ReadCalibrationHistory();
        Task<IList<SmartMeterCalibrationHistoryItem>> AddCalibrationHistoryItem(double consumedEnergyOffsetWattHours, double producedEnergyOffsetWattHours);
    }
}
