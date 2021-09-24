<%@ Page Title="Deletar Vendedor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="WebSales___WebForms_e_EntityFramework.Views.Sellers.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Remover</h2>
    <p>Vendedor</p>
    <h4>Você tem certeza que deseja remover esse vendedor?</h4>

    <hr />

   <div id="Sellers">
        <asp:ListView ID="lvSeller" runat="server" ItemType="WebSales___WebForms_e_EntityFramework.Models.Seller"
            SelectMethod="LvSeller_GetData" DataKeyNames="Id">

            <LayoutTemplate>
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" class="table table-striped table-dark">
                        <tr runat="server">
                            <th runat="server" scope="col">Identificação</th>
                            <th runat="server" scope="col">Nome</th>
                            <th runat="server" scope="col">Email</th>
                            <th runat="server" scope="col">Departamento</th>
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
                        <asp:Label ID="EmailLabel" runat="server" Text="<%#: Item.Email %>" />
                    </td>

                    <td>
                        <asp:Label ID="DepartmentLabel" runat="server" Text="<%#: Item.Department.Name %>" />
                    </td>                    
                </tr>
            </ItemTemplate>

        </asp:ListView>
    </div>

    <div>
        <asp:Button ID="btnRemove" runat="server" Text="Remover" OnClick="BtnRemove_Click" CssClass="btn" BackColor="#DF0000" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" />
    </div>

</asp:Content>
