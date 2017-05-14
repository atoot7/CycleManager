using CycleTrainerManagement.DataReader;
using CycleTrainerManagement.Models;
using CycleTrainerManagement.UIs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace CycleTrainerManagement
{
    public partial class FrmCycleManagerHome : Form
    {
        public FrmCycleManagerHome()
        {
            InitializeComponent();
        }

        public void Loading()
        {
            try
            {
                Application.Run(new LoadingScreen());
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void menuStripStart_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Any())
            {
                this.ActiveMdiChild.Close();
            }
            string[] data = null;
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.Filter = "HRM files|*.hrm";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string file = fdlg.FileName;
                data = File.ReadAllLines(file);
            }
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            Thread.Sleep(1000);
            LoadData(data);
            t.Abort();
        }
        private void LoadData(string[] data)
        {
            try
            {
                ReadInfo info = GetData(data);
                HomeForm _homeForm = HomeForm.Instance(info);
                _homeForm.MdiParent = this;
                _homeForm.Show();
                StaticDataClasses.paramInfo = info.Params;
                StaticDataClasses.hrdataList = info.HrDataList;
                MasterStaticClass.paramInfo = info.Params;
                MasterStaticClass.hrdataList = info.HrDataList;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! while loading data!");
            }
        }

        private static ReadInfo GetData(string[] data)
        {
            ReadInfo info = new ReadInfo();
            try
            {

                info = DataLoader.Reader(data);
                return info;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new ReadInfo();
            }
        }

        private void graphMenuToolStrip_Click(object sender, EventArgs e)
        {
            if (StaticDataClasses.hrdataList != null && StaticDataClasses.hrdataList.Count() > 0)
            {
                try
                {
                    ReadInfo info = new ReadInfo
                    {
                        HrDataList = StaticDataClasses.hrdataList,
                        Params = StaticDataClasses.paramInfo
                    };
                    if (info.HrDataList == null)
                    {
                        throw new System.InvalidOperationException("Load data file first!");
                    }
                    List<HrData> ListHrData = new List<HrData>();
                    ListHrData = info.HrDataList;
                    GraphForm _graphForm = GraphForm.Instance(ListHrData);
                    _graphForm.MdiParent = this;
                    _graphForm.Show();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please load data first!");
            }
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StaticDataClasses.hrdataList != null && StaticDataClasses.hrdataList.Count() > 0)
            {
                try
                {
                    ReadInfo info = new ReadInfo
                    {
                        HrDataList = StaticDataClasses.hrdataList,
                        Params = StaticDataClasses.paramInfo

                    };
                    if (info.HrDataList == null)
                    {
                        throw new System.InvalidOperationException("Load data file first!");
                    }
                    SummaryForm _graphForm = SummaryForm.Instance(info);
                    _graphForm.MdiParent = this;
                    _graphForm.Show();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please load data first!");
            }
        }

        private void FrmCycleManagerHome_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void advancedMetrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StaticDataClasses.hrdataList != null && StaticDataClasses.hrdataList.Count() > 0)
            {
                ReadInfo info = new ReadInfo
                {
                    HrDataList = StaticDataClasses.hrdataList,
                    Params = StaticDataClasses.paramInfo

                };
                if (info.HrDataList == null)
                {
                    MessageBox.Show("Load data file first!");
                }
                AdvancedMetrixForm _TssForm = AdvancedMetrixForm.Instance(info);
                _TssForm.MdiParent = this;
                _TssForm.Show();
            }
            else
            {
                MessageBox.Show("Load data file first!");
            }
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalenderView calender = CalenderView.Instance();
            calender.MdiParent = this;
            calender.Show();
        }

        private void dataListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StaticDataClasses.hrdataList != null && StaticDataClasses.hrdataList.Count() > 0)
            {
                ReadInfo info = new ReadInfo
                {
                    HrDataList = StaticDataClasses.hrdataList,
                    Params = StaticDataClasses.paramInfo

                };
                if (info.HrDataList == null)
                {
                    MessageBox.Show("Load data file first!");
                }
                Thread t = new Thread(new ThreadStart(Loading));
                t.Start();
                Thread.Sleep(1000);
                HomeForm _homeForm = HomeForm.Instance(info);
                _homeForm.MdiParent = this;
                _homeForm.Show();
                t.Abort();


            }
            else
            {
                MessageBox.Show("Load data file first!");
            }
        }

        private void intervalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StaticDataClasses.hrdataList != null && StaticDataClasses.hrdataList.Count() > 0)
            {
                ReadInfo info = new ReadInfo
                {
                    HrDataList = StaticDataClasses.hrdataList,
                    Params = StaticDataClasses.paramInfo

                };
                if (info.HrDataList == null)
                {
                    MessageBox.Show("Load data file first!");
                }
                IntervalSummaryForm _IntervalForm = IntervalSummaryForm.Instance(info);
                _IntervalForm.MdiParent = this;
                _IntervalForm.Show();
            }
            else
            {
                MessageBox.Show("Load data file first!");
            }
        }
    }
}
