using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class GenresController : ApiController
    {
        public List<SeriesScore> Get(int user)
        {
            Genre g = new Genre();
            return g.get(user);
        }


        // POST api/<controller>
        public void Post([FromBody] Genre g)
        {
            g.insert();
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