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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().Map(m =>
            {
                m.Properties(n => new { n.Id, n.Post, n.Title, n.Content, n.Thumbnail });
                m.ToTable("News");
            })
            .HasKey<int>(pk => pk.Id);
            
            modelBuilder.Entity<News>().Property(n => n.Id).IsRequired();
            modelBuilder.Entity<News>().Property(n => n.Title).IsRequired();
            modelBuilder.Entity<News>().Property(n => n.Content).IsRequired();
            modelBuilder.Entity<News>().Property(n => n.Post).IsRequired();

        }
    }
}