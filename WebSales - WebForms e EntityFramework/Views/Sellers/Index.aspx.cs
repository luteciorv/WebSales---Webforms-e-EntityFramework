using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;
using WebSales___WebForms_e_EntityFramework.Services;

namespace WebSales___WebForms_e_EntityFramework.Views.Sellers
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

        // O tipo de retorno pode ser alterado para IEnumerable, no entanto, para dar suporte à paginação de
        // e classificação, os seguintes parâmetros devem ser adicionados:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Seller> LvSellers_GetData()
        {
            // Instanciar serviço do departamento
            SellerService sellerService = new SellerService(_context);

            // Pegar todos os departamentos
            var query = sellerService.FindAllSellers().AsQueryable();

            // Retornar
            return query;
        }
    }
}