﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Hochstaetter.Fronius.Models.ToshibaAc
{
    public enum ToshibaAcOperatingMode : byte
    {
        Auto = 0x41,
        Cooling = 0x42,
        Drying = 0x44,
        Heating = 0x43,
        FanOnly = 0x45,
    }
}
