﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Report.Marketing
{
    public class ICustomerSaleStatistic
    {
        string maxName { get; }
        string minName { get; }
        string maxNumber { get; }
        string minNumber { get; }
        string avgNumber { get; }
    }
}
