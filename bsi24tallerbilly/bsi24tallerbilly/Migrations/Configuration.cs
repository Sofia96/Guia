namespace bsi24tallerbilly.Migrations
{
    using bsi24tallerbilly.Data.Entities;
    using bsi24tallerbilly.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Users.Any(u => u.CostarricanIDNumber == 116480546))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser
                {
                    CostarricanIDNumber = 116480546,
                    FullName = "Sergio Segura",
                    Email = "sergio31.96@gmail.com"
                };
                manager.Create(user, "g@u^E%a#S?&1");
            }

            if(!context.WorkshopServices.Any(w => w.WorkshopServicesID == 1))
            {
                context.WorkshopServices.Add
                (
                    new WorkshopServices { ImageURL = string.Empty, Title = "Alineamiento" }
                );
            }

            context.SaveChanges();
        }
    }
}
