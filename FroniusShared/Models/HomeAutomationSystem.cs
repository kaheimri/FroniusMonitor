﻿namespace De.Hochstaetter.FroniusShared.Models;

public class HomeAutomationSystem : BindableBase
{
    public HomeAutomationSystem(ISolarSystem solarSystem)
    {
        this.solarSystem = solarSystem;
    }

    private ISolarSystem? solarSystem;
    public ISolarSystem? SolarSystem
    {
        get => solarSystem;
        set => Set(ref solarSystem, value);
    }

    private Gen24Sensors? gen24Sensors;

    public Gen24Sensors? Gen24Sensors
    {
        get => gen24Sensors;
        set => Set(ref gen24Sensors, value);
    }

    private Gen24Sensors? gen24Sensors2;

    public Gen24Sensors? Gen24Sensors2
    {
        get => gen24Sensors2;
        set => Set(ref gen24Sensors2, value);
    }

    private Gen24Config? gen24Config;

    public Gen24Config? Gen24Config
    {
        get => gen24Config;
        set => Set(ref gen24Config, value);
    }

    private Gen24Config? gen24Config2;

    public Gen24Config? Gen24Config2
    {
        get => gen24Config2;
        set => Set(ref gen24Config2, value);
    }

    private FritzBoxDeviceList? fritzBox;

    public FritzBoxDeviceList? FritzBox
    {
        get => fritzBox;
        set => Set(ref fritzBox, value);
    }

    private WattPilot? wattPilot;

    public WattPilot? WattPilot
    {
        get => wattPilot;
        set => Set(ref wattPilot, value);
    }
}

