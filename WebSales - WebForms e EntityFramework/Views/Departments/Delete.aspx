<%@ Page Title="Remover Departamento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="WebSales___WebForms_e_EntityFramework.Views.Departments.Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Remover</h2>
    <p>Departamento</p>
    <h4>Você tem certeza que deseja remover esse departamento?</h4>

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

    </div>

    <div>
        <asp:Button ID="btnRemove" runat="server" Text="Remover" OnClick="BtnRemove_Click" CssClass="btn" BackColor="#DF0000" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" />
    </div>
</asp:Content>
