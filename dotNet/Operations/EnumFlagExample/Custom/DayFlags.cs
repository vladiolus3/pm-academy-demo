﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnumFlagExample.Custom
{

    [Flags]
    public enum DayFlags : short
    {
        Undefined = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
        Weekends = Saturday | Sunday,
        Weekdays = Monday | Tuesday | Wednesday | Thursday | Friday
    }
}
