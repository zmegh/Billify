using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillifyAPI.Models
{
    public class invoiceChartView
    {
        public double Unpaid { get; set; }
        public double Paid { get; set; }
        public double Pending { get; set; }
        public double Overdue { get; set; }
    }
}
