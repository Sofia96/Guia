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

    internal sealed class Configuration : DbMigrationsConfiguration<bsi24tallerbilly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(bsi24tallerbilly.Models.ApplicationDbContext context)
        {
            if (!context.WorkshopServices.Any(w => w.WorkshopServicesID == 1))
            {
                context.WorkshopServices.Add
                (
                    new WorkshopServices { ImageURL = null, Title = "Alineamiento" }
                );
            }
            context.SaveChanges();
        }
    }
}
