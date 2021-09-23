using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;

namespace WebSales___WebForms_e_EntityFramework.Services
{
    public class SellerService
    {
        // Context do banco de dados
        public readonly WebSalesContext _context;

        // Método construtor #1
        public SellerService(WebSalesContext context)
        {
            _context = context;
        }

        // Encontra e retorna um vendedor pelo seu Id
        public Seller FindSeller(int id)
        {
            return _context.Seller.Find(id);
        }

        // Encontra e retorna todos os vendedores
        public List<Seller> FindAllSellers()
        {
            return _context.Seller.ToList();
        }
             
        // Adicionar um vendedor
        public void AddSeller(Seller seller)
        {
            _context.Seller.Add(seller);
            _context.SaveChanges();
        }

        // Remove um vendedor pelo Id
        public void RemoveSeller(int id)
        {
            _context.Seller.Remove(FindSeller(id));
            _context.SaveChanges();
        }
    }
}