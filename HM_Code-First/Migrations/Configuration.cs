namespace HM_Code_First.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HM_Code_First.BookStore>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HM_Code_First.BookStore";
        }

        protected override void Seed(HM_Code_First.BookStore context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
