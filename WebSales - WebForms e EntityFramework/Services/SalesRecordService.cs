using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;

namespace WebSales___WebForms_e_EntityFramework.Services
{
    public class SalesRecordService
    {
        // Context do banco de dados
        public readonly WebSalesContext _context;

        // Método construtor #1
        public SalesRecordService(WebSalesContext context)
        {
            _context = context;
        }

        // Encontra e retorna um registro de venda pelo Id
        public SalesRecord FindSalesRecord(int id)
        {
            return _context.SalesRecord.Find(id);
        }

        // Encontra e retorna todos os resgistros de vendas
        public List<SalesRecord> FindAllSalesRecords()
        {
            return _context.SalesRecord.ToList();
        }

        // Adiciona um registro de venda
        public void AddSalesRecord(SalesRecord salesRecord)
        {
            _context.SalesRecord.Add(salesRecord);
            _context.SaveChanges();
        }

        // Remove um registro de vendas pelo seu Id
        public void RemoveSalesRecord(int id)
        {
            _context.SalesRecord.Remove(FindSalesRecord(id));
            _context.SaveChanges();
        }
    }
}