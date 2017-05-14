using CycleTrainerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace CycleTrainerManagement.UIs
{
    public partial class IntervalSummaryForm : Form
    {
        public IntervalSummaryForm()
        {
            InitializeComponent();
        }
        public static ReadInfo Info = null;
        private static IntervalSummaryForm _Form = null;
        public static IntervalSummaryForm Instance(ReadInfo info)
        {
            if (_Form == null)
            {
                Info = info;
                _Form = new IntervalSummaryForm();
            }
            return _Form;
        }

        private void IntervalSummaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Form = null;
        }

        private void IntervalSummaryForm_Load(object sender, EventArgs e)
        {
            List<HrData> intevalHrData = new List<HrData>();
            List<IntervalAverages> intervalData = new List<IntervalAverages>();
            var numberofRows = 0;
            //meeting with client require to set minimum interval time criteria
            var intervaltime = 180 / int.Parse(Info.Params.Interval);
            var intervalLenght = 0;
            foreach (var item in Info.HrDataList)
            {
                //meeting with client required to understand interval criteria
                //var isInterval = detectInterval(int.Parse(item.HeartRate), int.Parse(item.PowerInWatt), int.Parse(item.SpeedInKMH), Info.HrDataList.Average(x => int.Parse(x.HeartRate)), Info.HrDataList.Average(x => int.Parse(x.PowerInWatt))*0.66, Info.HrDataList.Average(x => int.Parse(x.SpeedInKMH)));
                var isInterval = detectInterval(int.Parse(item.HeartRate), int.Parse(item.PowerInWatt), int.Parse(item.SpeedInKMH), Info.HrDataList.Average(x => int.Parse(x.HeartRate)), Info.HrDataList.Average(x => int.Parse(x.PowerInWatt)), Info.HrDataList.Average(x => int.Parse(x.SpeedInKMH)));
                if (isInterval)
                {
                    intervalLenght += int.Parse(Info.Params.Interval);
                    numberofRows++;
                    intevalHrData.Add(new HrData
                    {
                        HeartRate = item.HeartRate,
                        PowerInWatt = item.PowerInWatt,
                        SpeedInKMH = item.SpeedInKMH
                    });

                }
                else
                {
                    if (numberofRows > intervaltime)
                    {
                        intervalData.Add(new IntervalAverages
                        {
                            AverageHeartRate = double.Parse(intevalHrData.Average(x => int.Parse(x.HeartRate)).ToString("0.##")),
                            AverageSpeed = double.Parse(intevalHrData.Average(x => int.Parse(x.SpeedInKMH)).ToString("0.##")),
                            AveragePower = double.Parse(intevalHrData.Average(x => int.Parse(x.PowerInWatt)).ToString("0.##")),
                            IntervalLengthInSeconds = numberofRows * int.Parse(Info.Params.Interval)
                        });
                        intevalHrData = new List<HrData>();
                        numberofRows = 0;
                    }
                    intervalLenght = 0;
                }
            }
            dataGridViewIntervalSummary.DataSource = null;
            dataGridViewIntervalSummary.DataSource = intervalData;
        }
        private bool detectInterval(int HeartRate, int PowerInWatt, int SpeedInKMH, double averageHeartRate, double AveragePowerInWatt, double AverageSpeed)
        {
            if (HeartRate > averageHeartRate && PowerInWatt > AveragePowerInWatt && SpeedInKMH > AverageSpeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
