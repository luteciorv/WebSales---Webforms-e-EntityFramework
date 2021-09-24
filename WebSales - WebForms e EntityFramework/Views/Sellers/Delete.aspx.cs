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

namespace WebSales___WebForms_e_EntityFramework.Views.Sellers
{
    public partial class Delete : Page
    {
        // Context do banco de dados
        private readonly WebSalesContext _context = new WebSalesContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
        * Retorna o vendedor associado ao Id passado na URL
        */
        public Seller LvSeller_GetData([QueryString("SellerId")] int? sellerId)
        {
            return _context.Seller.Find(sellerId);
        }


        /*
        * Chamada quando o usuário clicar no botão para remover o vendedor
        */
        protected void BtnRemove_Click(object sender, EventArgs e)
        {
            // Pegar o Id do vendedor na URL
            int sellerId = int.Parse(Request.QueryString["SellerId"]);

            // Instanciar o serviço do vendedor
            SellerService sellerService = new SellerService(_context);

            // Remover o vendedor
            sellerService.RemoveSeller(sellerId);

            // Redirecionar o usuário para a página inicial dos vendedores
            Response.Redirect("Index.aspx");
        }
    }
}