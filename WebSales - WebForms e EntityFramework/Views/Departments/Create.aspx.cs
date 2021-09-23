using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;
using WebSales___WebForms_e_EntityFramework.Models.Exceptions;
using WebSales___WebForms_e_EntityFramework.Services;

namespace WebSales___WebForms_e_EntityFramework.Views.Departments
{
    public partial class Create : Page
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
            // Coletar o nome do departamento informado
            string name = tbName.Text;

            // instanciar o serviço de departamento
            DepartmentService departmentService = new DepartmentService(_context);

            // Criar um departamento
            Department newDepartment = new Department(name);

            // Tenta adicionar o departamento na tabela
            try
            {
                // Adicionar o departamento
                departmentService.AddDepartment(newDepartment);

                // Redirecionar o usuário para a tela principal de departamentos
                Response.Redirect("Index.aspx");
            }

            // Lida com a exceção
            catch (DepartmentException ex)
            {
                // Exibe no Label Warning o erro
                lWarning.Text = ex.Message;
            }
        }
    }
}