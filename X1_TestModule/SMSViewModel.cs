﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X1_TestModule
{
    public class SMSViewModel
    {
        public string Api_version { get; set; }

        public string Message { get; set; }

        public string Id { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string Region { get; set; }

        public string Operator { get; set; }

        public string Date_created { get; set; }

        public string Date_sent { get; set; }

        public string Dlr_status { get; set; }

        public object Status_description { get; set; }

        public string Timezone { get; set; }

        public double Price { get; set; }

        public string Price_unit { get; set; }

        public int Code { get; set; }

        public int Status { get; set; }
    }
}
