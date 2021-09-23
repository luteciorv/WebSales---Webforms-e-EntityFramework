using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;

namespace WebSales___WebForms_e_EntityFramework.Views.Departments
{
    public partial class Details : System.Web.UI.Page
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

        // O tipo de retorno pode ser alterado para IEnumerable, no entanto, para dar suporte à paginação de
        // e classificação, os seguintes parâmetros devem ser adicionados:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public List<Seller> LvSellers_GetData([QueryString("DepartmentId")] int? departmentId)
        {
            return _context.Department.Find(departmentId).FindAllSellers();
        }


        /*
         * Chamada quando o usuário clicar no botão para editar este departamento
         */
        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            // Captar o Id do departamento
            int id = int.Parse(Request.QueryString["DepartmentId"]);

            // Redirecionar o usuário para a tela de edição
            Response.Redirect($"Edit.aspx?DepartmentId={id}");
        }


        /*
         * Chamada quando o usuário clicar no botão para remover este departamento
         */
        protected void BtnRemove_Click(object sender, EventArgs e)
        {
            // Captar o Id do departamento
            int id = int.Parse(Request.QueryString["DepartmentId"]);

            // Redirecionar o usuário para a tela de remoção
            Response.Redirect($"Delete.aspx?DepartmentId={id}");
        }
    }
}