using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;
using WebSales___WebForms_e_EntityFramework.Models.Exceptions;

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
            // Verifica se já existe um departamento com esse nome
            if (_context.Department.Where(d => d.Name == department.Name).Any())
            {
                // Levantar uma exceção
                throw new DepartmentException("Já existe um departamento com o nome informado", department.Name);
            }

            // Tentar adicionar o departamento a tabela
            try
            {
                _context.Department.Add(department);
                _context.SaveChanges();
            }

            // Caso dê algum erro de atualização do banco de dados ocorra
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException("Erro ao adicionar departamento no banco de dados", e.InnerException);
            }
        }

        // Remove um departamento pelo seu Id
        public void RemoveDepartment(int id)
        {
            // Verifica se existe algum departamento com esse Id
            if (FindDepartment(id) == null)
            {
                // Levantar uma exceção
                throw new DepartmentException("O id do departamento informado não existe");
            }

            // Tentar remover o departamento da tabela
            try
            {
                _context.Department.Remove(FindDepartment(id));
                _context.SaveChanges();
            }

            // Caso dê algum erro de atualização do banco de dados ocorra
            catch (DbUpdateConcurrencyException e)
            {
                throw new DepartmentException("Erro ao remover o departamento do banco de dados", e.InnerException);
            }
        }

        // Atualiza um departamento existente
        public void UpdateDepartment(int id, Department newDepartment)
        {
            // Verificar se o departamento existe
            bool existsId = _context.Department.Any(d => d.Id == id);           

            if (!existsId)
            {
                throw new DepartmentException("O departamento informado não existe", newDepartment.Name);
            }

            // Verificar se já existe algum departamento com esse nome
            bool existsName = _context.Department.Any(d => d.Name.ToLower().Contains(newDepartment.Name.ToLower()) && d.Id != id);

            if (existsName)
            {
                throw new DepartmentException("Já existe um departamento com o nome informado", newDepartment.Name);
            }

            try
            {
                // Atribuir a informações do novo departamento para o departamento alvo
                Department department = _context.Department.Find(id);
                department.Name = newDepartment.Name;

                // Salvar no banco de dados
                _context.SaveChanges();
            }

            // Caso algum erro de atualização no banco de dados ocorra
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException("Erro ao adicionar departamento no banco de dados", e.InnerException);
            }
        }
    }
}