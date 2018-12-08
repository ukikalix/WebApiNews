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
                return database.TheNews.OrderBy(d => d.Post).ToList();
            }
        }

        // GET: api/News/5
        public News Get(int id)
        {
            using (var database = new Context())
            {
                return database.TheNews.Where(i => i.Id == id).FirstOrDefault();
            }
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
