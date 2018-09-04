using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillifyAPI.Models
{
    public class payment
    {
        public int ID { get; set; }
        public int invoiceID { get; set; }
        public DateTime paymentDate { get; set; }
        public double paymentAmount { get; set; }
        public string paymentMethod { get; set; }
        public int paymentStatus { get; set; }
    }
}
