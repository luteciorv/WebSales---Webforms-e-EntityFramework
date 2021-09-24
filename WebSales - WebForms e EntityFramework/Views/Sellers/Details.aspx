<%@ Page Title="Detalhes do Vendedor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="WebSales___WebForms_e_EntityFramework.Views.Sellers.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Detalhes</h2>
    <p>Vendedor</p>

    <hr />

    <div id="Seller">
        <asp:ListView ID="lvSeller" runat="server" ItemType="WebSales___WebForms_e_EntityFramework.Models.Seller"
            SelectMethod="LvSeller_GetData" DataKeyNames="Id">

            <LayoutTemplate>
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" class="table table-striped table-dark">
                        <tr runat="server">
                            <th runat="server" scope="col">Identificação</th>
                            <th runat="server" scope="col">Nome</th>
                            <th runat="server" scope="col">Email</th>
                            <th runat="server" scope="col">Data de nascimento</th>
                            <th runat="server" scope="col">Salário</th>
                            <th runat="server" scope="col">Departamento</th>
                        </tr>
                        <tr id="itemPlaceholder" runat="server">
                        </tr>
                    </table>
                </td>

            </LayoutTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text="<%#: Item.Id %>" />
                    </td>

                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text="<%#: Item.Name %>" />
                    </td>

                    <td>
                        <asp:Label ID="Label1" runat="server" Text="<%#: Item.Email %>" />
                    </td>

                    <td>
                        <asp:Label ID="Label2" runat="server"><%#: Item.BirthDate.ToString("dd/MM/yyyy") %></asp:Label>
                    </td>

                    <td>
                        <asp:Label ID="Label3" runat="server" Text="<%#: Item.Salary %>" />
                    </td>

                    <td>
                        <asp:Label ID="Label4" runat="server" Text="<%#: Item.Department.Name %>" />
                    </td>
                </tr>
            </ItemTemplate>

        </asp:ListView>

        <asp:ListView ID="lvSalesRecords" runat="server" ItemType="WebSales___WebForms_e_EntityFramework.Models.SalesRecord"
            SelectMethod="LvSalesRecords_GetData" DataKeyNames="Id">

            <LayoutTemplate>
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" class="table table-striped table-dark">
                        <tr runat="server">
                            <th runat="server" scope="col">Identificação dos Registros de Vendas</th>
                            <th runat="server" scope="col">Data da venda</th>
                        </tr>
                        <tr id="itemPlaceholder" runat="server">
                        </tr>
                    </table>
                </td>

            </LayoutTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text="<%#: Item.Id %>" />
                    </td>

                    <td>
                        <asp:Label ID="NameLabel" runat="server"><%#: Item.Date.ToString("dd/MM/yyyy") %></asp:Label>
                    </td>
                </tr>

            </ItemTemplate>

        </asp:ListView>

        <div>
            <asp:Button ID="btnEdit" runat="server" Text="Editar" OnClick="BtnEdit_Click" CssClass="btn" BackColor="#126581" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" />
            <asp:Button ID="btnRemove" runat="server" Text="Remover" OnClick="BtnRemove_Click" CssClass="btn" BackColor="#DF0000" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" />
        </div>

    </div>

</asp:Content>
