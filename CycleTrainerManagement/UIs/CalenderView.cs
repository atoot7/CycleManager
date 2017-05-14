using CycleTrainerManagement.DataReader;
using CycleTrainerManagement.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace CycleTrainerManagement.UIs
{
    public partial class CalenderView : Form
    {
        public CalenderView()
        {
            InitializeComponent();
        }
        private static CalenderView _Form = null;
        public static CalenderView Instance()
        {
            if (_Form == null)
            {
                _Form = new CalenderView();
            }
            return _Form;
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
                var selection = monthCalendar1.SelectionStart.ToString("MM-dd-yyyy");
            if (selection!=MasterStaticClass.SelectionDate)
            {
                var baseDirectory = AppDomain.CurrentDomain.BaseDirectory + "Data\\";
                var fileLocation = Path.Combine(baseDirectory, selection + ".hrm");
                if (File.Exists(@fileLocation))
                {
                    MasterStaticClass.SelectionDate = selection;
                    MasterStaticClass.SelectionEndDate = selection;
                    string[] data = null;
                    var file = @fileLocation;
                    data = File.ReadAllLines(file);
                    LoadData(data);
                }
                else
                {
                    MessageBox.Show("File Not Found!");
                }
            }
        }

        private void CalenderView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Form = null;
        }

        private void LoadData(string[] data)
        {
            try
            {
                ReadInfo info = GetData(data);
                StaticDataClasses.paramInfo = info.Params;
                StaticDataClasses.hrdataList = info.HrDataList;
                MasterStaticClass.paramInfo = info.Params;
                MasterStaticClass.hrdataList = info.HrDataList;
                MessageBox.Show("Data Load Successful");
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

        private void CalenderView_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MasterStaticClass.SelectionDate))
            {
                monthCalendar1.SelectionStart = DateTime.Parse(MasterStaticClass.SelectionDate);
                monthCalendar1.SelectionEnd = DateTime.Parse(MasterStaticClass.SelectionEndDate);
            }
        }
    }
}
