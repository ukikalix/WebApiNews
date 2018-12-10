namespace WebApiNews.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiNews.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiNews.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApiNews.Models.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            System.Collections.Generic.List<News> items = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.List<News>>(System.IO.File.ReadAllText(string.Concat(AppDomain.CurrentDomain.BaseDirectory, "../data.json")));

            foreach (News item in items)
            {
                context.TheNews.AddOrUpdate(item);
            }
            context.SaveChanges();
        }
    }
}
