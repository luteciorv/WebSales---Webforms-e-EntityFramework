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
    public partial class Update : Page
    {
        // Context do banco de dados
        private readonly WebSalesContext _context = new WebSalesContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) { return; }

            AssignFieldsValues();
        }

        /*
         * Associa a cada campo da tela seus respectivos valores de acordo com o id
         * do departamento passado pela URL
         */
        private void AssignFieldsValues()
        {
            // Pegar o ID da URL
            int departmentId = int.Parse(Request.QueryString["DepartmentId"]);

            // Pegar o departamento
            Department department = _context.Department.Find(departmentId);

            // Associar os valores
            tbName.Text = department.Name;
        }

        /*
         * Chamada quando o usuário clicar no botão para atualizar/salvar as novas
         * informações do departamento
         */
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Pegar o ID da URL do departamento alvo
            int departmentId = int.Parse(Request.QueryString["DepartmentId"]);

            // Novo departamento
            Department newDepartment = new Department(tbName.Text);

            // Instancia o seviço dos departamentos
            DepartmentService departmentService = new DepartmentService(_context);

            try
            {
                // Atualizar as informações do departamento
                departmentService.UpdateDepartment(departmentId, newDepartment);
            }

            catch(DepartmentException ex)
            {
                lWarning.Text = ex.Message;
                return;
            }

            // Redireciona o usuário para a página inicial dos departamentos
            Response.Redirect("Index.aspx");
        }
    }
}