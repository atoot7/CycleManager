﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTrainerManagement.Models
{
    public static class MasterStaticClass
    {
        public static List<HrData> hrdataList { get; set; }
        public static ParamInfos paramInfo { get; set; }
        public static string SelectionDate { get; set; }
        public static string SelectionEndDate { get; set; }
    }
}
