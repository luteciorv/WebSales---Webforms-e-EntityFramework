using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;
using WebSales___WebForms_e_EntityFramework.Services;

namespace WebSales___WebForms_e_EntityFramework.Views.SalesRecords
{
    public partial class SimpleSearch : System.Web.UI.Page
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

        /*
        * Retorna todos os registros de vendas
        */
        public IQueryable<SalesRecord> LvSalesRecords_GetData()
        {
            // Pegar as datas mínimas e máximas da URL
            DateTime minDate = Convert.ToDateTime(Request.QueryString["MinDate"]);
            DateTime maxDate = Convert.ToDateTime(Request.QueryString["MaxDate"]);

            // Instanciar serviço de registro de vendas
            SalesRecordService salesRecordService = new SalesRecordService(_context);

            // Registros de vendas
            var salesRecords = salesRecordService.FindAllSalesRecords().Where(sr => sr.Date >= minDate && sr.Date <= maxDate);

            // Valor total das vendas
            Label label = (Label)lvSalesRecords.FindControl("lTotalSalesPrice") ;
            label.Text = $"Valor total das vendas: R$ {salesRecords.Sum(sr => sr.TotalPrice)}";

            // Retornar os registros de vendas correspondentes
            return salesRecords.AsQueryable();
        }
    }
}