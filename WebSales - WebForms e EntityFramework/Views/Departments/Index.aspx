<%@ Page Title="Departamentos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebSales___WebForms_e_EntityFramework.Views.Departments.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Departamentos</h1>
    <p>
        <asp:Button ID="btnCreate" runat="server" Text="Adicionar" OnClick="BtnCreate_Click" CssClass="btn" BackColor="#1DA3CF" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" />
    </p>

    <div id="Departments">
        <asp:ListView ID="lvDepartments" runat="server" ItemType="WebSales___WebForms_e_EntityFramework.Models.Department"
            SelectMethod="LvDepartments_GetData" DataKeyNames="Id">

            <LayoutTemplate>
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" class="table table-striped table-dark">
                        <tr runat="server">
                            <th runat="server" scope="col">Id</th>
                            <th runat="server" scope="col">Nome</th>
                            <th runat="server" scope="col"></th>
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
                        <a id="EditLink" href="Edit.aspx?DepartmentId=<%#:Item.Id %>">Editar</a>
                        <a id="DetailsLink" href="Details.aspx?DepartmentId=<%#:Item.Id %>">Detalhes</a>
                        <a id="DeleteLinks" href="Delete.aspx?DepartmentId=<%#:Item.Id %>">Excluir</a>
                    </td>
                </tr>
            </ItemTemplate>

        </asp:ListView>
    </div>
</asp:Content>
