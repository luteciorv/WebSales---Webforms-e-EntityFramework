using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;

namespace WebSales___WebForms_e_EntityFramework.Services
{
    public class DepartmentService
    {
        // Context do banco de dados
        private readonly WebSalesContext _context;

        // Método construtor #1
        public DepartmentService(WebSalesContext context)
        {
            _context = context;
        }

        // Encontra e retorna um departamento pelo Id
        public Department FindDepartment(int id)
        {
            return _context.Department.Find(id);
        }

        // Encontra e retorna todos os departamentos
        public List<Department> FindAllDepartments()
        {
            return _context.Department.ToList();
        }

        // Adiciona um departamento
        public void AddDepartment(Department department)
        {
            _context.Department.Add(department);
            _context.SaveChanges();
        }

        // Remove um departamento pelo seu Id
        public void RemoveDepartment(int id)
        {
            _context.Department.Remove(FindDepartment(id));
            _context.SaveChanges();
        }       
    }
}