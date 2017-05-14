using CycleTrainerManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleTrainerManagement.UIs
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            //Thread t = new Thread(new ThreadStart(Loading));
            //t.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
            //t.Abort();
        }

        private static HomeForm _Form = null;
        public static ReadInfo Info = new ReadInfo();

        public static HomeForm Instance(ReadInfo info)
        {
            if (_Form == null)
            {
                Info = info;
                _Form = new HomeForm();
            }
            return _Form;
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {
            GetCycleData(Info);
            GetBasicInfo(Info);
            btnReset.Enabled = false;
        }

        private void GetCycleData(ReadInfo info)
        {
            List<HrData> ListHrData = new List<HrData>();
            ListHrData = info.HrDataList;
            cycleDataGridView.DataSource = null;
            cycleDataGridView.DataSource = ListHrData;
        }

        private void GetBasicInfo(ReadInfo info)
        {
            List<ParamInfos> basicInfoList = new List<ParamInfos>();
            ParamInfos paramInfo = new ParamInfos();
            paramInfo = info.Params;
            basicInfoList.Add(paramInfo);
            gridViewBasicInfo.DataSource = null;
            gridViewBasicInfo.DataSource = basicInfoList;
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Form = null;
        }

        private void cycleDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void cycleDataGridView_MouseLeave(object sender, EventArgs e)
        {

        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StaticDataClasses.hrdataList = new List<HrData>();
            StaticDataClasses.paramInfo = new ParamInfos();
            MasterStaticClass.hrdataList = new List<HrData>();
            MasterStaticClass.paramInfo = new ParamInfos();
            MasterStaticClass.SelectionDate = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSelection();
        }

        private void ResetSelection()
        {
            cycleDataGridView.ClearSelection();
            StaticDataClasses.hrdataList = MasterStaticClass.hrdataList;
            StaticDataClasses.paramInfo = MasterStaticClass.paramInfo;

            btnRowsSelection.Enabled = true;
            btnReset.Enabled = false;
        }

        private void btnRowsSelection_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = cycleDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                var list = new List<HrData>();
                for (int i = 0; i < selectedRowCount; i++)
                {

                    var model = new HrData()
                    {
                        HeartRate = cycleDataGridView.SelectedRows[i].Cells[0].Value.ToString(),
                        SpeedInKMH = cycleDataGridView.SelectedRows[i].Cells[1].Value.ToString(),
                        Cadence = cycleDataGridView.SelectedRows[i].Cells[2].Value.ToString(),
                        Altitude = cycleDataGridView.SelectedRows[i].Cells[3].Value.ToString(),
                        PowerInWatt = cycleDataGridView.SelectedRows[i].Cells[4].Value.ToString(),
                        PowerBalancePaddalIndex = cycleDataGridView.SelectedRows[i].Cells[5].Value.ToString(),
                    };
                    list.Add(model);
                }
                StaticDataClasses.hrdataList = list;
            }
            btnReset.Enabled = true;
            btnRowsSelection.Enabled = false;
        }
    }
}
