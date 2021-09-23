using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;
using WebSales___WebForms_e_EntityFramework.Services;

namespace WebSales___WebForms_e_EntityFramework.Views.Departments
{
    public partial class Delete : Page
    {
        // Context do banco de dados
        private readonly WebSalesContext _context = new WebSalesContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // O tipo de retorno pode ser alterado para IEnumerable, no entanto, para dar suporte à paginação de
        // e classificação, os seguintes parâmetros devem ser adicionados:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public Department LvDepartment_GetData([QueryString("DepartmentId")] int? departmentId)
        {
            // Retornar
            return _context.Department.Find(departmentId);
        }

        /*
        * Chamada quando o usuário clicar no botão para remover o departamento
        */
        protected void BtnRemove_Click(object sender, EventArgs e)
        {
            // Pegar o Id do departamento pela URL
            int id = int.Parse(Request.QueryString["DepartmentId"]);

            // Instanciar o serviço do departamento
            DepartmentService departmentService = new DepartmentService(_context);

            // Remover o departamento
            departmentService.RemoveDepartment(id);

            // Redirecionar o usuário para a página inicial dos departamentos
            Response.Redirect("Index.aspx");
        }
    }
}