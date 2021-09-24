using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSales___WebForms_e_EntityFramework.Data;

namespace WebSales___WebForms_e_EntityFramework.Views.SalesRecords
{
    public partial class Index : System.Web.UI.Page
    {
        // Context do banco de dados
        private readonly WebSalesContext _context = new WebSalesContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
         * Chamada quando o usuário clicar no botão para realizar uma busca simples
         */
        protected void BtnSimpleSearch_Click(object sender, EventArgs e)
        {
            // Pegar as datas mínimas e máximas
            DateTime minDate = Convert.ToDateTime(tbMinDate_SimpleSearch.Text);
            DateTime maxDate = Convert.ToDateTime(tbMaxDate_SimplesSearch.Text);

            // Passar pela URL
            Response.Redirect($"SimpleSearch.aspx?MinDate={minDate:dd/MM/yyyy}&MaxDate={maxDate:dd/MM/yyyy}");
        }

        protected void BtnDepartmentSearch_Click(object sender, EventArgs e)
        {

        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}