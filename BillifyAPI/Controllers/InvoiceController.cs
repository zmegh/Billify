using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BillifyAPI.Models;
using Microsoft.AspNetCore.Cors;

namespace BillifyAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyCorsPolicy")]
    public class InvoiceController : Controller
    {
        [HttpGet]
        public List<invoiceView> Get()
        {
            return Orm.GetAllInvoices();
        }

        [HttpGet]
        [Route("customers")]
        public List<customers> GetCustomer()
        {
            return Orm.Get<customers>();
        }

        [HttpGet]
        [Route("chart-data")]
        public List<chartData> EChartData()
        {
            List<invoiceChartView> chartData =  Orm.Get<invoiceChartView>();

            List<chartData> data = new List<chartData>();
            chartData item = new Models.chartData { value = chartData[0].Paid, name = "Paid" };
            data.Add(item);

            item = new Models.chartData { value = chartData[0].Unpaid, name = "Unpaid",  };
            data.Add(item);

            item = new Models.chartData { value = chartData[0].Pending, name = "Pending" };
            data.Add(item);

            item = new Models.chartData { value = chartData[0].Overdue, name = "Overdue" };
            data.Add(item);

            return data;
        }


        [HttpPostAttribute]
        [HttpOptions]
        [HttpPost]
        [Route("insert")]
        [EnableCors("MyCorsPolicy")]
        public JsonResult Insert([FromBody]invoiceView invoice)
        {
            if (invoice.customer ==null) return new JsonResult("{ result: invalid input}");

           long result = Orm.Insert<invoiceView>(invoice);

            return new JsonResult("{ result: " + 0 + " }");
        }

        // POST api/values
        [HttpPost]
        [Route("post")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
