﻿using System;
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
        [Route("api/News")]
        public List<News> GetRecents()
        {
            using (var database = new Context())
            {
                return database.TheNews.OrderByDescending(d => Guid.NewGuid()).Take(3).ToList();
            }
        }

        // GET: api/NewsAll
        [Route("api/NewsAll")]
        public List<News> GetAll()
        {
            using (var database = new Context())
            {
                return database.TheNews.OrderByDescending(d => d.Post).ToList();
            }
        }

        // GET: api/NewsAll/kword
        [HttpGet]
        [Route("api/NewsAll/{kword}")]
        public List<News> Search(string kword)
        {
            using (var database = new Context())
            {
                return database.TheNews.OrderByDescending(d => d.Post).Where(t => t.Title.Contains(kword)).ToList();
            }
        }

        // GET: api/News/5
        [Route("api/News/{id}")]
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
