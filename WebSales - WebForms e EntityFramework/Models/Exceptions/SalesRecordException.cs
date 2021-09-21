using System;

namespace WebSales___WebForms_e_EntityFramework.Models.Exceptions
{
    public class SalesRecordException : ApplicationException
    {
        // Atributos
        public int SalesRecordId { get; }

        // Método construtor #1
        public SalesRecordException() { }

        // Método construtor #2
        public SalesRecordException(string message) : base(message) { }

        // Método construtor #3
        public SalesRecordException(string message, Exception inner) : base(message, inner) { }

        // Método construtor #4
        public SalesRecordException(string message, int salesRecordId) : this(message)
        {
            SalesRecordId = salesRecordId;
        }
    }
}