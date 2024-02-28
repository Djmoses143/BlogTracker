namespace Project_ClassLibrary.Migrations
{
    using Project_ClassLibrary_DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project_ClassLibrary_DAL.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Project_ClassLibrary_DAL.BlogDbContext context)
        {
            context.AdminInfo.Add(new AdminInfo { EmailId = "djmoses@admin.com", Password = "1234" });
            context.SaveChanges();
            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
