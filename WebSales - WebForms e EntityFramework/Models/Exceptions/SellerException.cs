using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSales___WebForms_e_EntityFramework.Models.Exceptions
{
    public class SellerException : ApplicationException
    {
        // Atributos
        public string SellerName { get; }

        // Método construtor #1
        public SellerException() { }

        // Método construtor #2
        public SellerException(string message) : base(message) { }

        // Método construtor #3
        public SellerException(string message, Exception inner) : base(message, inner) { }

        // Método construtor #4
        public SellerException(string message, string sellerName) : this(message)
        {
            SellerName = sellerName;
        }
    }
}