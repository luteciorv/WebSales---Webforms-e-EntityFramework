<%@ Page Title="Registros de Vendas - Busca Simples" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleSearch.aspx.cs" Inherits="WebSales___WebForms_e_EntityFramework.Views.SalesRecords.SimpleSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <h3>Busca Simples</h3>

        <asp:Label ID="lMinData_SimpleSearch" runat="server" CssClass="text-justify" Font-Bold="True" Font-Names="Segoe UI" Text="Data Mínima" />
        <asp:TextBox runat="server" ID="tbMinDate_SimpleSearch" MaxLength="10" placeholder="dd/mm/aaaa" Height="25px" Width="130px" />

        &nbsp;<asp:Label ID="lMaxData_SimpleSearch" runat="server" CssClass="text-justify" Font-Bold="True" Font-Names="Segoe UI" Text="Data Máxima" />
        <asp:TextBox runat="server" ID="tbMaxDate_SimplesSearch" MaxLength="10" placeholder="dd/mm/aaaa" Height="25px" Width="130px" Font-Names="Segoe UI" />

        <asp:Button ID="btnSimpleSearch" runat="server" Text="Pesquisar" OnClick="BtnSimpleSearch_Click" CssClass="btn" BackColor="#1DA3CF" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" Font-Names="Segoe UI" />
    </div>

    <br />
    <br />

    <div id="salesRecords">
        <asp:ListView ID="lvSalesRecords" runat="server" ItemType="WebSales___WebForms_e_EntityFramework.Models.SalesRecord"
            SelectMethod="LvSalesRecords_GetData" DataKeyNames="Id">

            <LayoutTemplate>
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" class="table table-striped table-dark">
                        <tr runat="server">
                            <th runat="server" scope="col"><asp:Label runat="server" ID="lTotalSalesPrice" Text="Total das Vendas:"/></th>
                            <th></th>
                            <th></th>
                            <th></th>
                            <th></th>
                            <th></th>
                        </tr>
                        
                        <tr runat="server">
                            <th runat="server" scope="col">Registro</th>
                            <th runat="server" scope="col">Data</th>
                            <th runat="server" scope="col">Vendedor</th>
                            <th runat="server" scope="col">Departamento</th>
                            <th runat="server" scope="col">Valor da Venda</th>
                            <th runat="server" scope="col">Situação</th>
                        </tr>
                        <tr id="itemPlaceholder" runat="server">
                        </tr>
                    </table>
                </td>
                
                <asp:Label runat="server" Text="Páginas" Font-Names="Segoe UI"/>
                <asp:DataPager ID="salesRecordsPage" runat="server" PagedControlID="lvSalesRecords" PageSize="10">
                    <Fields>
                        <asp:NumericPagerField ButtonCount="5" />
                    </Fields>
                </asp:DataPager>

            </LayoutTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="IdLabel" runat="server" Text="<%#: Item.Id %>" />
                    </td>

                    <td>
                        <asp:Label ID="NameLabel" runat="server" ><%#: Item.Date.ToString("dd/MM/yyyy") %></asp:Label>
                    </td>

                    <td>
                        <asp:Label ID="EmailLabel" runat="server" Text="<%#: Item.Seller.Name %>" />
                    </td>

                    <td>
                        <asp:Label ID="DepartmentLabel" runat="server" Text="<%#: Item.Seller.Department.Name %>" />
                    </td>

                    <td>
                        <asp:Label ID="Label1" runat="server" Text="<%#: Item.TotalPrice %>" />
                    </td>

                    <td>
                        <asp:Label ID="Label2" runat="server" Text="<%#: Item.Status %>" />
                    </td>             
                </tr>
            </ItemTemplate>

        </asp:ListView>
    </div>

</asp:Content>
