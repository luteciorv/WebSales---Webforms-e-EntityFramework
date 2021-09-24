<%@ Page Title="Detalhes do Departamento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="WebSales___WebForms_e_EntityFramework.Views.Departments.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detalhes</h2>
    <p>Departamento</p>

    <hr />

    <div id="Department">
        <asp:ListView ID="lvDepartment" runat="server" ItemType="WebSales___WebForms_e_EntityFramework.Models.Department"
            SelectMethod="LvDepartment_GetData" DataKeyNames="Id">

            <LayoutTemplate>
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" class="table table-striped table-dark">
                        <tr runat="server">
                            <th runat="server" scope="col">Id</th>
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
                </tr>
            </ItemTemplate>

        </asp:ListView>

        <asp:ListView ID="lvSellers" runat="server" ItemType="WebSales___WebForms_e_EntityFramework.Models.Seller"
            SelectMethod="LvSellers_GetData" DataKeyNames="Id">

            <LayoutTemplate>
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" class="table table-striped table-dark">
                        <tr runat="server">
                            <th runat="server" scope="col">Id</th>
                            <th runat="server" scope="col">Vendedores Associados</th>
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
                </tr>

            </ItemTemplate>

        </asp:ListView>

        <div>
            <asp:Button ID="btnEdit" runat="server" Text="Editar" OnClick="BtnEdit_Click" CssClass="btn" BackColor="#126581" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" />
            <asp:Button ID="btnRemove" runat="server" Text="Remover" OnClick="BtnRemove_Click" CssClass="btn" BackColor="#DF0000" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" />
        </div>

    </div>

</asp:Content>
