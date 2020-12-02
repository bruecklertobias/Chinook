using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Report.Marketing
{
    public class ITrackStatistic
    {
        public int MaxTime { get; }
        public int MinTime { get; }
        public double AverageTime { get; }
    }
}
