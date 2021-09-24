using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;
using WebSales___WebForms_e_EntityFramework.Services;

namespace WebSales___WebForms_e_EntityFramework.Views.Departments
{
    public partial class Index : Page
    {
        // Context do banco de dados
        private readonly WebSalesContext _context = new WebSalesContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
         * Chamada quando o usuário clicar no botão para adicionar um novo departamento
         */
        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            // Redirecionar o usuário para a página de criação do departamento
            Response.Redirect("Create.aspx");
        }

        /*
        * Retorna todos os departamentos
        */
        public IQueryable<Department> LvDepartments_GetData()
        {
            // Instanciar serviço do departamento
            DepartmentService departmentService = new DepartmentService(_context);

            // Pegar todos os departamentos
            var query = departmentService.FindAllDepartments().AsQueryable();

            // Retornar
            return query;
        }
    }
}