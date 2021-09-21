namespace WebSales___WebForms_e_EntityFramework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebSales___WebForms_e_EntityFramework.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<WebSales___WebForms_e_EntityFramework.Data.WebSalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /*
         * Povoar o banco de dados
         */
        protected override void Seed(WebSalesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
