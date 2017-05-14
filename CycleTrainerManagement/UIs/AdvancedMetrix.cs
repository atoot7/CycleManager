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
    public partial class AdvancedMetrixForm : Form
    {
        public AdvancedMetrixForm()
        {
            InitializeComponent();
        }
        public static ReadInfo Info = null;
        private static AdvancedMetrixForm _Form = null;
        public static AdvancedMetrixForm Instance(ReadInfo info)
        {
            if (_Form == null)
            {
                Info = info;
                _Form = new AdvancedMetrixForm();
            }
            return _Form;
        }


        private void AdvancedMetrixForm_Load(object sender, EventArgs e)
        {
            GetAdvancedMetrix();

        }

        private void GetAdvancedMetrix()
        {
            //var lengthWorkOut = Info.Params.LengthWorkOut;
            //double workOutMin = TimeSpan.Parse(lengthWorkOut).TotalMinutes;
            var selectRowsTime = Info.HrDataList.Count() * int.Parse(Info.Params.Interval);
            var workOutMin = (double)selectRowsTime / 60;

            //double workOut

            var HrDataList = Info.HrDataList;
            var AgvPower = HrDataList.Average(x => double.Parse(x.PowerInWatt));
            var FTP = AgvPower * 0.95;


            var tempPower4 = Math.Pow(AgvPower, 4);
            var tempagvandtime = tempPower4 * workOutMin / 60;
            var root4 = 1.0 / 4;
            var NP = Math.Pow(tempagvandtime, root4);
            var IF = NP / FTP;
            var TSS = (workOutMin * 60 * NP * IF) / (FTP * 3600) * 100;
            lblFTP.Text = FTP.ToString("0.##");
            lblNP.Text = NP.ToString("0.##");
            lblIF.Text = IF.ToString("0.##");
            lblTSS.Text = TSS.ToString("0.##");
        }

        private void AdvancedMetrixForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Form = null;
        }

        private void cmbSelectStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAdvancedMetrix();
        }
    }
}
