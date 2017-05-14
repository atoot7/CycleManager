using CycleTrainerManagement.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTrainerManagement.DataReader
{
    public class DataLoader
    {

        public static ReadInfo Reader(string[] data)
        {
            //var read = AppDomain.CurrentDomain.BaseDirectory+"data.hrm";
            ReadInfo info = new ReadInfo();
            //string filePath = @read;

            if (data.Any() && data != null)
            {
                info = processfile(data);
                return info;
            }
            else
            {
                return info;
            }
        }

        static ReadInfo processfile(string[] filelines)
        {
            ReadInfo readInfo = new ReadInfo();
            ParamInfos paramInfos = new ParamInfos();
            List<HrData> ListHrData = new List<HrData>();
            try
            {
                //string filecontent = File.ReadAllText(filePath);
                //string[] filelines = File.ReadAllLines(filePath);
                var VersionLineParts = filelines.FirstOrDefault(x => x.Contains("Version=")).Split('=');
                var SModeParts = filelines.FirstOrDefault(x => x.Contains("SMode=")).Split('=');
                var MaxHrParts = filelines.FirstOrDefault(x => x.Contains("MaxHR=")).Split('=');
                var RestHrPars = filelines.FirstOrDefault(x => x.Contains("RestHR=")).Split('=');
                var Vo2MaxParts = filelines.FirstOrDefault(x => x.Contains("VO2max=")).Split('=');
                var WeightParts = filelines.FirstOrDefault(x => x.Contains("Weight=")).Split('=');
                var MonitorParts = filelines.FirstOrDefault(x => x.Contains("Monitor=")).Split('=');
                var DateParts = filelines.FirstOrDefault(x => x.Contains("Date=")).Split('=');
                var StartTimeParts = filelines.FirstOrDefault(x => x.Contains("StartTime=")).Split('=');
                var LengthParts = filelines.FirstOrDefault(x => x.Contains("Length=")).Split('=');
                var IntervalParts = filelines.FirstOrDefault(x => x.Contains("Interval=")).Split('=');


                paramInfos.Version = VersionLineParts[VersionLineParts.Length - 1];
                paramInfos.MaxHr = MaxHrParts[MaxHrParts.Length - 1];
                paramInfos.RestHr = RestHrPars[RestHrPars.Length - 1];
                paramInfos.VO2Max = Vo2MaxParts[Vo2MaxParts.Length - 1];
                paramInfos.Weight = WeightParts[WeightParts.Length - 1];
                paramInfos.SMode = SModeParts[SModeParts.Length - 1];
                paramInfos.Monitor = MonitorParts[MonitorParts.Length - 1];
                paramInfos.StartDateWorkOut = DateParts[DateParts.Length - 1];
                paramInfos.StartTime = StartTimeParts[StartTimeParts.Length - 1];
                paramInfos.LengthWorkOut = LengthParts[LengthParts.Length - 1];
                paramInfos.Interval = IntervalParts[LengthParts.Length - 1];

                bool startNote = false;
                bool startHrData = false;
                StringBuilder sb = new StringBuilder();
                foreach (var line in filelines)
                {
                    if (string.Equals(line, "[IntTimes]"))
                    {
                        startNote = false;
                    }
                    if (startNote)
                    {
                        sb.Append(line).Append(" ");
                    }
                    if (string.Equals(line, "[Note]"))
                    {
                        startNote = true;
                    }

                    if (startHrData)
                    {
                        var HrDataSplit = line.Split('\t');
                        ListHrData.Add(new HrData()
                        {
                            HeartRate = HrDataSplit[0],
                            SpeedInKMH = (int.Parse(HrDataSplit[1]) / 10).ToString(),
                            Cadence = HrDataSplit[2],
                            Altitude = HrDataSplit[3],
                            PowerInWatt = HrDataSplit[4],
                            PowerBalancePaddalIndex = HrDataSplit[5]
                        });
                    }


                    if (string.Equals(line, "[HRData]"))
                    {
                        startHrData = true;
                    }
                }
                startHrData = false;
                paramInfos.Note = sb.ToString();
                var temp = DateTime.ParseExact(paramInfos.StartDateWorkOut, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                paramInfos.StartDateWorkOut = temp.ToString("yyyy/MM/dd");
                readInfo.Params = paramInfos;
                readInfo.HrDataList = ListHrData;
                return readInfo;
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                return readInfo;
            }

        }
    }
}
