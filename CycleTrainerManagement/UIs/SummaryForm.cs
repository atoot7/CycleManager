using CycleTrainerManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleTrainerManagement.UIs
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }
        public static ReadInfo Info = null;
        private static SummaryForm _Form = null;
        public static SummaryForm Instance(ReadInfo info)
        {
            if (_Form == null)
            {
                Info = info;
                _Form = new SummaryForm();
            }
            return _Form;
        }


        private void SummaryForm_Load(object sender, EventArgs e)
        {
            cmbSelectStandard.SelectedIndex = 1;
            GetSummary();

        }

        private void GetSummary()
        {
            var lengthWorkOut = Info.Params.LengthWorkOut;


            double workOutHour = TimeSpan.Parse(lengthWorkOut).TotalHours;
            //double workOut

            var HrDataList = Info.HrDataList;
            var AvgSpeed = HrDataList.Average(x => double.Parse(x.SpeedInKMH));
            var MaxSpeed = HrDataList.Max(x => double.Parse(x.SpeedInKMH));

            var AvgHeartRate = HrDataList.Average(x => double.Parse(x.HeartRate));
            var MaxHeartRate = HrDataList.Max(x => double.Parse(x.HeartRate));
            var MinHeartRate = HrDataList.Min(x => double.Parse(x.HeartRate));

            var AgvPower = HrDataList.Average(x => double.Parse(x.PowerInWatt));
            var MaxPower = HrDataList.Max(x => double.Parse(x.PowerInWatt));

            var AvgAltitude = HrDataList.Average(x => double.Parse(x.Altitude));
            var MaxAltitude = HrDataList.Max(x => double.Parse(x.Altitude));
            var MinAltitude = HrDataList.Min(x => double.Parse(x.Altitude));


            var standard = "";
            var expression="";
            if (cmbSelectStandard.Text == "Kilometer")
            {
                standard = "KM/H"; expression = "KM";
            }
            else
            {
                standard = "Miles/H";
                expression = "Miles";
                AvgSpeed = AvgSpeed * 0.621371;
                MaxSpeed = MaxSpeed * 0.621371;
            }
            lblAvgSpeed.Text = AvgSpeed.ToString("0.##") + " " + standard;
            lblMaxSpeed.Text = MaxSpeed.ToString("0.##") + " " + standard;
            lblAvgHeart.Text = AvgHeartRate.ToString("0.##") + " " + "BPM"; 
            lblMaxHeart.Text = MaxHeartRate.ToString("0.##") + " " + "BPM";
            lblMinHeart.Text = MinHeartRate.ToString("0.##") + " " + "BPM";
            lblAvgPower.Text = AgvPower.ToString("0.##") + " " + "Watt";
            lblMaxPower.Text = MaxPower.ToString("0.##") + " " + "Watt";
            lblAvgAltitude.Text = AvgAltitude.ToString("0.##");
            lblMaxAltitude.Text = MaxAltitude.ToString("0.##");
            lblDistance.Text = (workOutHour*AvgSpeed).ToString("0.##")+" "+expression;
        }

        private void SummaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Form = null;
        }

        private void cmbSelectStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSummary();
        }
    }
}
