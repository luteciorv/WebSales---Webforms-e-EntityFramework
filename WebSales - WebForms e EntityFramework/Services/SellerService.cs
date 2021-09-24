using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net.Mail;
using System.Web;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;
using WebSales___WebForms_e_EntityFramework.Models.Enums;
using WebSales___WebForms_e_EntityFramework.Models.Exceptions;

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

        // Adiciona um vendedor
        public void AddSeller(Seller seller)
        {
            // Verificar se o "nome" é válido
            if (seller.Name.Any(n => !char.IsLetter(n) && n != ' '))
            {
                throw new SellerException("Nome inválido", seller.Name, NewSellerField.Name);
            }

            // Verificar se o "email" é válido
            try
            {
                var baseEmail = new MailAddress(seller.Email);
            }

            catch (FormatException)
            {
                throw new SellerException("Email inválido", seller.Email, NewSellerField.Email);
            }

            // Verificar se o "salário" é válido
            if (seller.Salary <= 0f || seller.Salary >= 9999999)
            {
                throw new SellerException("Salário inválido", seller.Name, NewSellerField.Salary);
            }

            // Tentar adicionar o vendedor na tabela
            try
            {
                _context.Seller.Add(seller);
                _context.SaveChanges();
            }

            // Caso algum erro de atualização do banco de dados ocorra
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException("Erro ao adicionar vendedor no banco de dados", e.InnerException);
            }
        }

        // Remove um vendedor pelo Id
        public void RemoveSeller(int id)
        {
            // Verifica se existe algum vendedor com esse Id
            if (FindSeller(id) == null)
            {
                // Levantar uma exceção
                throw new DepartmentException("O id do vendedor informado não existe");
            }

            // Tenta remover o vendedor da tabela
            try
            {
                _context.Seller.Remove(FindSeller(id));
                _context.SaveChanges();
            }

            // Caso dê algum erro de atualização do banco de dados ocorra
            catch (DbUpdateConcurrencyException e)
            {
                throw new SellerException("Erro ao remover o vendedor do banco de dados", e.InnerException);
            }
        }

        // Atualiza um vendedor existe
        public void UpdateSeller(int id, Seller editedSeller)
        {
            // Verificar se o vendedor existe
            bool existsId = _context.Seller.Any(d => d.Id == id);

            if (!existsId)
            {
                throw new SellerException("O vendedor informado não existe", editedSeller.Name);
            }

            // Verificar se já existe algum vendedor com esse nome
            bool existsName = _context.Seller.Any(d => d.Name.ToLower().Contains(editedSeller.Name.ToLower()) && d.Id != id);

            if (existsName)
            {
                throw new SellerException("Já existe um vendedor com o nome informado", editedSeller.Name);
            }

            try
            {
                // Atribuir a informações do novo vendedor para o vendedor alvo
                Seller seller = _context.Seller.Find(id);
                seller.Name = editedSeller.Name;
                seller.Email = editedSeller.Email;
                seller.BirthDate = editedSeller.BirthDate;
                seller.Salary = editedSeller.Salary;
                seller.DepartmentId = editedSeller.Department.Id;
                seller.Department = editedSeller.Department;

                // Salvar no banco de dados
                _context.SaveChanges();
            }

            // Caso dê algum erro de atualização do banco de dados ocorra
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException("Erro ao adicionar vendedor no banco de dados", e.InnerException);
            }
        }
    }
}