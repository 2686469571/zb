namespace ConsoleApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApplication2.DataAccessLayer.BloggingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleApplication2.DataAccessLayer.BloggingContext";
        }

        protected override void Seed(ConsoleApplication2.DataAccessLayer.BloggingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
