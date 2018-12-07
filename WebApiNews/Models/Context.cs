using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiNews.Models
{
    public class Context : DbContext
    {
        public Context()
               : base("ApiConnection")
        {
        }
        public DbSet<News> TheNews { get; set; }
    }
}