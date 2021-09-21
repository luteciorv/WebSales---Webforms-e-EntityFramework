using System;

namespace WebSales___WebForms_e_EntityFramework.Models.Exceptions
{
    public class DepartmentException : ApplicationException
    {
        // Atributos
        public string DepartmentName { get; }

        // Método construtor #1
        public DepartmentException() { }

        // Método construtor #2
        public DepartmentException(string message) : base(message) { }

        // Método construtor #3
        public DepartmentException(string message, Exception inner) : base(message, inner) { }

        // Método construtor #4
        public DepartmentException(string message, string departmentName) : this(message)
        {
            DepartmentName = departmentName;
        }
    }
}