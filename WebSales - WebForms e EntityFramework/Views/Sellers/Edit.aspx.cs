using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSales___WebForms_e_EntityFramework.Data;
using WebSales___WebForms_e_EntityFramework.Models;
using WebSales___WebForms_e_EntityFramework.Models.Enums;
using WebSales___WebForms_e_EntityFramework.Models.Exceptions;
using WebSales___WebForms_e_EntityFramework.Services;

namespace WebSales___WebForms_e_EntityFramework.Views.Sellers
{
    public partial class Edit : Page
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
         * do vendedor passado na URL
         */
        private void AssignFieldsValues()
        {
            // Pegar o ID da URL
            int sellerId = int.Parse(Request.QueryString["SellerId"]);

            // Pegar o departamento
            Seller seller = _context.Seller.Find(sellerId);

            // Associar os valores
            tbName.Text = seller.Name;
            tbEmail.Text = seller.Email;
            tbDataDay.Text = seller.BirthDate.Day.ToString();
            tbDataMonth.Text = seller.BirthDate.Month.ToString();
            tbDataYear.Text = seller.BirthDate.Year.ToString();
            tbSalary.Text = seller.Salary.ToString();

            // Pegar todos os departamentos => Id, Nome
            var departments = _context.Department.Select(d => new { d.Id, d.Name }).ToList();

            // Associar o DataSource do DropDownList aos departamentos retornados
            ddlDepartments.DataSource = departments;

            // Associar Id e Nome
            ddlDepartments.DataValueField = "Id";
            ddlDepartments.DataTextField = "Name";

            // Valor escolhido
            ddlDepartments.SelectedValue = seller.Department.Id.ToString();

            // Atualizar
            ddlDepartments.DataBind();
        }

        /*
         * Chamada quando o usuário clicar no botão para atualizar/salvar as novas
         * informações do departamento
         */
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Pegar o ID da URL do departamento alvo
            int sellerId = int.Parse(Request.QueryString["SellerId"]);
            
            // Declarar variáveis para coletar os dados
            string name;
            string email;
            DateTime birthDate = new DateTime();
            double salary;
            int departmentId;

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
            Seller editedSeller = new Seller(name, email, birthDate, salary, _context.Department.Find(departmentId));

            // Instancia o seviço dos vendedores
            SellerService sellerService = new SellerService(_context);

            try
            {
                // Atualizar as informações do vendedor
                sellerService.UpdateSeller(sellerId, editedSeller);
                // Redireciona o usuário para a página inicial dos departamentos
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