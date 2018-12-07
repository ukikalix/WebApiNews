using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiNews.Models;

namespace WebApiNews.Controllers
{
    public class NewsController : ApiController
    {
        // GET: api/News
        public List<News> Get()
        {
            using (var database = new Context())
            {
                return database.TheNews.ToList();
            }
        }

        // GET: api/News/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/News
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/News/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/News/5
        public void Delete(int id)
        {
        }
    }
}
