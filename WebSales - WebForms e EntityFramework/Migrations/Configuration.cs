namespace WebSales___WebForms_e_EntityFramework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebSales___WebForms_e_EntityFramework.Data;
    using WebSales___WebForms_e_EntityFramework.Models;
    using WebSales___WebForms_e_EntityFramework.Models.Enums;

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

            // Departamentos
            Department d1 = new Department("Computadores");
            Department d2 = new Department("Eletrónicos");
            Department d3 = new Department("Moda");
            Department d4 = new Department("Livros");

            // Vendedores
            Seller s1 = new Seller("Luís Felipe", "lutecio@gmail.com", new DateTime(2000, 2, 26), 1500.00, d1);
            Seller s2 = new Seller("Marcos Vinicius", "marcosv@gmail.com", new DateTime(2002, 4, 15), 2500.75, d1);
            Seller s3 = new Seller("Ana Maria", "anamaria@gmail.com", new DateTime(1995, 1, 1), 1500, d2);
            Seller s4 = new Seller("Rosângela", "rosa@gmail.com", new DateTime(1990, 3, 20), 1500.40, d2);
            Seller s5 = new Seller("Matheus", "matheus@gmail.com", new DateTime(2004, 6, 14), 3493.50, d3);
            Seller s6 = new Seller("Carolina", "carol@gmail.com", new DateTime(2000, 7, 29), 2700.3, d3);
            Seller s7 = new Seller("Elisa", "elisa@gmail.com", new DateTime(1999, 10, 30), 1970.5, d4);
            Seller s8 = new Seller("Bernardo Vasconselo", "bernardo@gmail.com", new DateTime(2001, 12, 9), 3000.0, d4);

            // Registros de vendas
            SalesRecord sr1 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord sr3 = new SalesRecord(new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s8);
            SalesRecord sr4 = new SalesRecord(new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s7);
            SalesRecord sr5 = new SalesRecord(new DateTime(2018, 09, 21), 3000.0, SaleStatus.Pending, s7);
            SalesRecord sr6 = new SalesRecord(new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord sr7 = new SalesRecord(new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord sr8 = new SalesRecord(new DateTime(2018, 09, 11), 4000.0, SaleStatus.Pending, s4);
            SalesRecord sr9 = new SalesRecord(new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord sr10 = new SalesRecord(new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord sr11 = new SalesRecord(new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord sr12 = new SalesRecord(new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord sr13 = new SalesRecord(new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord sr14 = new SalesRecord(new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord sr15 = new SalesRecord(new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s6);
            SalesRecord sr16 = new SalesRecord(new DateTime(2018, 10, 5), 2000.0, SaleStatus.Pending, s4);
            SalesRecord sr17 = new SalesRecord(new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord sr18 = new SalesRecord(new DateTime(2018, 10, 24), 6000.0, SaleStatus.Canceled, s7);
            SalesRecord sr19 = new SalesRecord(new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord sr20 = new SalesRecord(new DateTime(2018, 10, 15), 8000.0, SaleStatus.Canceled, s6);
            SalesRecord sr21 = new SalesRecord(new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord sr22 = new SalesRecord(new DateTime(2018, 10, 24), 4000.0, SaleStatus.Pending, s4);
            SalesRecord sr23 = new SalesRecord(new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s7);
            SalesRecord sr24 = new SalesRecord(new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s8);
            SalesRecord sr25 = new SalesRecord(new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord sr26 = new SalesRecord(new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord sr27 = new SalesRecord(new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord sr28 = new SalesRecord(new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s6);
            SalesRecord sr29 = new SalesRecord(new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord sr30 = new SalesRecord(new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s8);

            // Adicionar nas tabelas
            context.Department.AddOrUpdate(d1, d2, d3, d4);
            context.Seller.AddOrUpdate(s1, s2, s3, s4, s5, s6, s7, s8);
            context.SalesRecord.AddOrUpdate(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10,
                sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20, sr21, sr22, sr23, 
                sr24, sr25, sr26, sr27, sr28, sr29, sr30);

            // Salvar
            context.SaveChanges();
        }
    }
}
