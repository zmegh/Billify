using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillifyAPI.Models
{
    [Serializable]
    public class invoiceView
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("invoiceDate")]
        public string invoiceDate { get; set; }

        [JsonProperty("customer")]
        public string customer { get; set; }

        [JsonProperty("service")]
        public string service { get; set; }

        [JsonProperty("statusText")]
        public string statusText { get; set; }

        [JsonProperty("totalAmount")]
        public double totalAmount { get; set; }

        [JsonProperty("amountDue")]
        public double amountDue { get; set; }
    }
}
