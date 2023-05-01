using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class EpisodesController : ApiController
    {
        // GET api/<controller>
       public List<Episode> Get()
        {
            Episode e = new Episode();
            List<Episode> el = e.Get();
            return el;
        }
      
        // GET api/<controller>/5
        public List<Episode> Get(string series, int id)
        {
            Episode e = new Episode();
            List<Episode> episodes = e.Get(series, id);
            return episodes;
        }

        // POST api/<controller>
        public void Post([FromBody] Episode episode)
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