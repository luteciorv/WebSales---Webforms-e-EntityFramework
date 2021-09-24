using System;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;

namespace WebSales___WebForms_e_EntityFramework.Views.Sellers
{
    public partial class Details : Page
    {
        // Context do banco de dados
        private readonly WebSalesContext _context = new WebSalesContext();

        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        /*
         * Retorna as informações do vendedor atual
         */
        public Seller LvSeller_GetData([QueryString("SellerId")] int? sellerId)
        {
            return _context.Seller.Find(sellerId);
        }

        /*
         * Retorna todos os registros de vendas associados a este vendedor
         */
        public IQueryable<SalesRecord> LvSalesRecords_GetData([QueryString("SellerId")] int? sellerId)
        {
            return _context.Seller.Find(sellerId).FindAllSellers().AsQueryable();
        }

        /*
        * Chamada quando o usuário clicar no botão "Editar" para editar as informações
        * do vendedor atual
        */
        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            // Pegar o id do vendedor atual
            int sellerId = int.Parse(Request.QueryString["SellerId"]);

            // Redirecionar o usuário para a página de edição
            Response.Redirect($"Edit.aspx?SellerId={sellerId}");
        }

        /*
        * Chamada quando o usuário clicar no botão "Remover" para remover da tabela
        * "Seller" o vendedor atual
        */
        protected void BtnRemove_Click(object sender, EventArgs e)
        {
            // Pegar o id do vendedor atual
            int sellerId = int.Parse(Request.QueryString["SellerId"]);

            // Redirecionar o usuário para a página de remoção
            Response.Redirect($"Delete.aspx?SellerId={sellerId}");
        }      
    }
}