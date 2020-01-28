using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiLagash.Models;

namespace WebApiLagash.Controllers
{
    public class ConsultasController : ApiController
    {
        // GET api/<controller>
        [Authorize(Roles = "Basic, Admin")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";

        }

        // POST api/<controller>        
        [Authorize(Roles = "Admin, User, Basic")]
        public Response<Report> Post([FromBody]Report value)
        {
            return new Response<Report>
            {
                Id = 1,
                Message = "Correcto",
                Object = new Report
                {
                    Id = 1,
                    Name = "Reporte"
                }
            };
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}