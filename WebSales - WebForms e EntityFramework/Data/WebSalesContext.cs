using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebSales___WebForms_e_EntityFramework.Models;

namespace WebSales___WebForms_e_EntityFramework.Data
{
    public class WebSalesContext : DbContext
    {
        // Método construtor #1
        public WebSalesContext() : base("WebSales - Webforms e EF") { }

        // Tabelas
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}