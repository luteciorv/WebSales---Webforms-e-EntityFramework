using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSales___WebForms_e_EntityFramework.Models
{
    public class Seller
    {
        // Atributos
        [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} necessário.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} deve estar entre {2} e {1}")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} necessário")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:dd/MM/yyyy")]
        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Campo {0} necessário.")]
        [Range(1100, 1000000, ErrorMessage = "O valor do campo {0} deve estar entre {1} e {2}")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Salário")]
        public float Salary { get; set; }

        // Relacionamento => Departamento
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        // Relacionamento => Registros de Vendas
        public ICollection<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();

        // Método Construtor #1
        public Seller() { }

        // Método Construtor #2
        public Seller(string name, string email, DateTime birthDate, float salary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            DepartmentId = department.Id;
            Department = department;
        }

        // Adiciona um registro de vendas
        public void AddSalesRecord(SalesRecord salesRecord)
        {
            SalesRecords.Add(salesRecord);
        }

        // Remove um registro de venda pelo Id informado
        public void RemoveSalesRecord(int id)
        {
            SalesRecords.Remove(FindSalesRecord(id));
        }

        // Procura e retorna o registro de vendas pelo Id
        public SalesRecord FindSalesRecord(int id)
        {
            return SalesRecords.Where(sr => sr.Id == id).FirstOrDefault();
        }

        // Retorna o total de vendas
        public float TotalSales()
        {
            return SalesRecords.Select(sr => sr.TotalPrice).Sum();
        }
    }
}