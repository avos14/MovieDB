using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class SeriesController : ApiController
    {
        // GET api/<controller>
        public List<Series> Get()
        {
            List<Series> sl = new List<Series>();
            Series s = new Series();
            sl = s.Get();

            return sl;
        }

        // GET api/<controller>/5
        public List<string> Get(int id)
        {
            Series s = new Series();
            List<string> listSeries = s.Get(id);
            return listSeries;

        }
      
        // POST api/<controller>
        public void Post([FromBody] Series s)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}