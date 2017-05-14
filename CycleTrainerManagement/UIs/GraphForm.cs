using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using CycleTrainerManagement.Models;

namespace CycleTrainerManagement.UIs
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }
        public static List<HrData> Info = null;

        private static GraphForm _Form = null;
        public static GraphForm Instance(List<HrData> hrList)
        {
            if (_Form == null)
            {
                Info = hrList;
                _Form = new GraphForm();
            }
            return _Form;
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            CreateGraphHeartRate(zedGraphCycleHeartRate, Info, true);
            CreateSpeedGraph(zedGraphControlSpeed, Info, true);
            CreateGraphPower(zedGraphControlPower, Info, true);
            CreateGraphCadence(zedGraphControlCadence, Info, true);
            CreateGraphAptitude(zedGraphControlAltitude, Info, true);
        }
        private void CreateGraphHeartRate(ZedGraphControl zgc, List<HrData> hr, bool HrGraph)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();
            GraphPane myPane = zgc.GraphPane;
            myPane.Title.Text = "Heart Rate Report";
            myPane.XAxis.Title.Text = "Data";
            myPane.YAxis.Title.Text = "Heart Rate Value";
            var x = 0;
            if (HrGraph)
            {
                PointPairList listHr = new PointPairList();
                foreach (var item in hr)
                {
                    listHr.Add(x, double.Parse(item.HeartRate));
                    x++;
                }
                x = 0;
                LineItem myCurveHr = myPane.AddCurve("HeartRate", listHr, Color.Blue,
                                        SymbolType.Triangle);
            }                
            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Refresh();
        }


        private void CreateSpeedGraph(ZedGraphControl zgc, List<HrData> hr, bool SpeedGraph)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();
            GraphPane myPane = zgc.GraphPane;
            myPane.Title.Text = "Speed Report";
            myPane.XAxis.Title.Text = "Data";
            myPane.YAxis.Title.Text = "Speed Value";
            var x = 0;
            if (SpeedGraph)
            {
                PointPairList listSpeed = new PointPairList();
                foreach (var item in hr)
                {
                    listSpeed.Add(x, double.Parse(item.SpeedInKMH));
                    x++;
                }
                x = 0;
                LineItem myCurveSpeed = myPane.AddCurve("Speed", listSpeed, Color.Red,
                                        SymbolType.Star);
            }
            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Refresh();
        }
        private void CreateGraphCadence(ZedGraphControl zgc, List<HrData> hr, bool CadenceGraph)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();
            GraphPane myPane = zgc.GraphPane;
            myPane.Title.Text = "Cadence Report";
            myPane.XAxis.Title.Text = "Data";
            myPane.YAxis.Title.Text = "Cadence Value";
            var x = 0;
            if (CadenceGraph)
            {

                PointPairList listCadence = new PointPairList();
                foreach (var item in hr)
                {
                    listCadence.Add(x, double.Parse(item.Cadence));
                    x++;
                }
                x = 0;
                LineItem myCurveCadence = myPane.AddCurve("Cadence", listCadence, Color.Purple,
                                        SymbolType.Diamond);
            }
            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Refresh();
        }
        private void CreateGraphAptitude(ZedGraphControl zgc, List<HrData> hr, bool AltitudeGraph)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();
            GraphPane myPane = zgc.GraphPane;
            myPane.Title.Text = "Altitude Report";
            myPane.XAxis.Title.Text = "Data";
            myPane.YAxis.Title.Text = "Altitude Value";
            var x = 0;
            if (AltitudeGraph)
            {
                PointPairList listAltitude = new PointPairList();
                foreach (var item in hr)
                {
                    listAltitude.Add(x, double.Parse(item.Altitude));
                    x++;
                }
                x = 0;
                LineItem myCurveAlt = myPane.AddCurve("Altitude", listAltitude, Color.Green,
                                        SymbolType.Square);
            }
            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Refresh();
        }
        private void CreateGraphPower(ZedGraphControl zgc, List<HrData> hr, bool PowerGraph)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();
            GraphPane myPane = zgc.GraphPane;
            myPane.Title.Text = "Power Report";
            myPane.XAxis.Title.Text = "Data";
            myPane.YAxis.Title.Text = "Power Value";
            var x = 0;
            if (PowerGraph)
            {
                PointPairList listPower = new PointPairList();
                foreach (var item in hr)
                {
                    listPower.Add(x, double.Parse(item.PowerInWatt));
                    x++;
                }
                x = 0;
                LineItem myCurvePower = myPane.AddCurve("Power", listPower, Color.Magenta,
                                        SymbolType.Circle);
            }
            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Refresh();
        }


        private void GraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Form = null;
        }

        private void checkBoxHr_CheckedChanged(object sender, EventArgs e)
        {
            ReDrawFilterGraph();


        }

        private void checkBoxSpeed_CheckedChanged(object sender, EventArgs e)
        {
            ReDrawFilterGraph();

        }

        private void checkBoxCadence_CheckedChanged(object sender, EventArgs e)
        {
            ReDrawFilterGraph();

        }

        private void checkBoxAltitude_CheckedChanged(object sender, EventArgs e)
        {
            ReDrawFilterGraph();
        }

        private void checkBoxBalace_CheckedChanged(object sender, EventArgs e)
        {
            //CreateGraph(zedGraphCycle, Info, true, true, true, true, true, checkBoxBalace.Checked);
            //zedGraphCycle.AxisChange();
            //zedGraphCycle.Invalidate();
            //zedGraphCycle.Refresh();
        }

        private void checkBoxPower_CheckedChanged(object sender, EventArgs e)
        {
            ReDrawFilterGraph();
        }

        private void ReDrawFilterGraph()
        {
            CreateGraphHeartRate(zedGraphCycleHeartRate, Info, checkBoxHr.Checked);
            CreateSpeedGraph(zedGraphControlSpeed, Info, checkBoxSpeed.Checked);
            CreateGraphPower(zedGraphControlPower, Info, checkBoxPower.Checked);
            CreateGraphCadence(zedGraphControlCadence, Info, checkBoxCadence.Checked);
            CreateGraphAptitude(zedGraphControlAltitude, Info, checkBoxAltitude.Checked);
            zedGraphCycleHeartRate.AxisChange();
            zedGraphCycleHeartRate.Invalidate();
            zedGraphCycleHeartRate.Refresh();
            zedGraphControlSpeed.AxisChange();
            zedGraphControlSpeed.Invalidate();
            zedGraphControlSpeed.Refresh();
            zedGraphControlPower.AxisChange();
            zedGraphControlPower.Invalidate();
            zedGraphControlPower.Refresh();
            zedGraphControlAltitude.AxisChange();
            zedGraphControlAltitude.Invalidate();
            zedGraphControlAltitude.Refresh();
            zedGraphControlCadence.AxisChange();
            zedGraphControlCadence.Invalidate();
            zedGraphControlCadence.Refresh();
        }
    }
}
