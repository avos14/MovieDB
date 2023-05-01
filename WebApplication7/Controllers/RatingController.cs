using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class RatingController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET returns rating for the specified series
        public float Get(int seriesId)
        {
            Rating r = new Rating();
            float rating = r.Get(seriesId);
            return rating;
        }

        [HttpGet]
        [Route("api/Rating/getUserRating")]
        public List<int> GetUR(int userId)
        {
            Rating r = new Rating();
            return r.GetUR(userId);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/Rating/UpdateUserRating")]
        public void UUR([FromBody] Rating r)
        {
            r.Update();
        }

        public void Post([FromBody] Rating r)
        {
            r.insert();
        }

        // PUT api/<controller>/5

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}