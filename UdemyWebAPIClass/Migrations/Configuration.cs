namespace UdemyWebAPIClass.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UdemyWebAPIClass.Models.UdemyWebAPIClassContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UdemyWebAPIClass.Models.UdemyWebAPIClassContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Contacts.AddOrUpdate(new Contacts[] {
              new Contacts { Id = 0, FirstName = "Andrew", LastName= "Peters" },
              new Contacts { Id = 1, FirstName = "Brice", LastName ="Lambson" },
              new Contacts { Id = 2, FirstName = "Rowan", LastName = "Miller" }
            });

        }
    }
}
