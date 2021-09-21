using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSales___WebForms_e_EntityFramework.Models
{
    public class Department
    {
        // Atributos
        [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O tamanho do campo {0} precisa estar entre {2} e {1}")]
        public string Name { get; set; }

        // Relacionamento => Vendedor
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        // Método construtor #1
        public Department() { }

        // Método construtor #2
        public Department(string name)
        {
            Name = name;
        }

        // Adiciona um vendedor 
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        // Remove um vendedor
        public void RemoveSeller(int id)
        {
            Sellers.Remove(FindSeller(id));
        }

        // Encontra e retorna o vendedor com o Id passado
        public Seller FindSeller(int id)
        {
            return Sellers.Where(s => s.Id == id).FirstOrDefault();
        }

        // Encontra e reotorna todos os vendedores
        public List<Seller> FindAllSellers()
        {
            return Sellers.ToList();
        }

        // Retorna a soma de todas as vendas dos vendedores
        public float TotalSales()
        {
            return Sellers.Select(s => s.TotalSales()).Sum();
        }
    }
}