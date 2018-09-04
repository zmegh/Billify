﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillifyAPI.Models
{
    public class customers
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string state { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
    }
}
