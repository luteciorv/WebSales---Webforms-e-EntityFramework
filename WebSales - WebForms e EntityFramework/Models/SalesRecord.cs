using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebSales___WebForms_e_EntityFramework.Models.Enums;

namespace WebSales___WebForms_e_EntityFramework.Models
{
    public class SalesRecord
    {
        // Atributos
        [Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:dd/MM/yyyy")]
        [Display(Name = "Data da venda")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(100, 1000000, ErrorMessage = "O campo {0} precisa estar entre {2} e {1}")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Valor total")]
        public float TotalPrice { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Situação")]
        public SaleStatus Status { get; set; }

        // Relacionamento => Vendedor
        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public Seller Seller { get; set; }

        // Método construtor #1
        public SalesRecord() { }

        // Método construtor #2
        public SalesRecord(DateTime date, float totalPrice, SaleStatus status, Seller seller)
        {
            Date = date;
            TotalPrice = totalPrice;
            Status = status;
            SellerId = seller.Id;
            Seller = seller;
        }
    }
}