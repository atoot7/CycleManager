using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTrainerManagement.Models
{
    public class HrData
    {
        public string HeartRate { get; set; }
        public string SpeedInKMH { get; set; }
        public string Cadence { get; set; }
        public string Altitude { get; set; }
        public string PowerInWatt { get; set; }
        public string PowerBalancePaddalIndex { get; set; }
    }
    public class IntervalAverages
    {
        public double AverageHeartRate { get; set; }
        public double AverageSpeed { get; set; }
        public double AveragePower { get; set; }
        public int IntervalLengthInSeconds { get; set; }
    }
}
