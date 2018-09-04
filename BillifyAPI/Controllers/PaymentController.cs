using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using BillifyAPI.Models;

namespace BillifyAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyCorsPolicy")]
    public class PaymentController : Controller
    {
        [HttpGet]
        public List<payment> Get()
        {
            return Orm.Get<payment>();
        }

        [HttpGet("{invoideID}")]
        public List<payment> Get(int invoideID)
        {
            return Orm.Get<payment>();
        }
    }
}