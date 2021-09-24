using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;
using WebSales___WebForms_e_EntityFramework.Models.Enums;
using WebSales___WebForms_e_EntityFramework.Models.Exceptions;
using WebSales___WebForms_e_EntityFramework.Services;

namespace WebSales___WebForms_e_EntityFramework.Views.Sellers
{
    public partial class Create : Page
    {
        // Context do banco de dados
        private readonly WebSalesContext _context = new WebSalesContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) { return; }

            PopulateDDLDepartment();
        }

        /*
         * Popula o DropDownList exibindo todos os departamentos criados 
         */
        private void PopulateDDLDepartment()
        {
            // Pegar todos os departamentos => Id, Nome
            var departments = _context.Department.Select(d => new { d.Id, d.Name }).ToList();

            // Associar o DataSource do DropDownList aos departamentos retornados
            ddlDepartments.DataSource = departments;

            // Associar Id e Nome
            ddlDepartments.DataValueField = "Id";
            ddlDepartments.DataTextField = "Name";

            // Atualizar
            ddlDepartments.DataBind();

            // Setar um valor padrão
            ddlDepartments.Items.Insert(0, new ListItem("--- Departamentos ---"));
        }

        /*
         * Chamada quando o usuário clicar no botão para adicionar um novo vendedor
         */
        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            // Declarar variáveis para coletar os dados
            string name = "";
            string email = "";
            DateTime birthDate = new DateTime();
            double salary = new double();
            int departmentId = new int();

            // Coletar os dados informados pelo usuário
            try
            {
                name = tbName.Text;
                email = tbEmail.Text;
                birthDate = new DateTime(int.Parse(tbDataYear.Text), int.Parse(tbDataMonth.Text), int.Parse(tbDataDay.Text));
                salary = double.Parse(tbSalary.Text);
                departmentId = int.Parse(ddlDepartments.SelectedValue);
            }

            catch (Exception)
            {
                lWarningGeral.Text = "Erro no formato de algum campo acima";
                return;
            }

            // Criar um vendedor
            Seller newSeller = new Seller(name, email, birthDate, salary, _context.Department.Find(departmentId));

            // Instanciar o serviço de vendedores
            SellerService sellerService = new SellerService(_context);

            // Tenta adicionar o vendedor na tabela
            try
            {
                // Adicionar o vemdedor
                sellerService.AddSeller(newSeller);

                // Redirecionar o usuário para a tela principal de vendedores
                Response.Redirect("Index.aspx");
            }

            // Lida com as possíveis exceções geradas
            catch (SellerException ex)
            {
                switch (ex.SellerField)
                {
                    case NewSellerField.Name:
                        {
                            lWarningName.Text = ex.Message;
                            break;
                        }

                    case NewSellerField.Email:
                        {

                            lWarningEmail.Text = ex.Message;
                            break;
                        }

                    case NewSellerField.BirthDate:
                        {
                            lWarningDate.Text = ex.Message;
                            break;
                        }

                    case NewSellerField.Salary:
                        {
                            lWarningSalary.Text = ex.Message;
                            break;
                        }

                    case NewSellerField.Department:
                        {
                            lWarningDepartment.Text = ex.Message;
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}