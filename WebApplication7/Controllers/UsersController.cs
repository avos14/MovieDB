using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/<controller>
        public List<User> Get()
        {
            List<User> ul = new List<User>();
            User u = new User();
            ul = u.Get();
            return ul;
        }
   
        // GET api/<controller>/5
        public HttpResponseMessage Get(string email, string password)
        {
            User u = new User();
            u = u.Get(email);
            if(u != null)
            {
                if (u.Password == password)
                    return Request.CreateResponse(HttpStatusCode.OK, u);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Incorrect Email or Password");

        }

        // POST api/<controller>
        public void Post([FromBody] User user)
        {
            user.insert();
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