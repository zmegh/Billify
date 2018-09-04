using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillifyAPI.Models
{
    public class invoices
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("invoiceDate")]
        public string invoiceDate { get; set; }

        [JsonProperty("customerId")]
        public string customerId { get; set; }

        [JsonProperty("service")]
        public string service { get; set; }

        [JsonProperty("statusId")]
        public string statusId { get; set; }

        [JsonProperty("totalAmount")]
        public double totalAmount { get; set; }

        [JsonProperty("amountDue")]
        public double amountDue { get; set; }
    }
}
