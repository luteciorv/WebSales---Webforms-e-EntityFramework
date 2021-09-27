<%@ Page Title="Registros de Vendas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebSales___WebForms_e_EntityFramework.Views.SalesRecords.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Registros de Vendas</h1>
    
    <br />
    
    <p>
        <asp:Button ID="btnCreate" runat="server" Text="Adicionar" OnClick="BtnCreate_Click" CssClass="btn" BackColor="#1DA3CF" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" Font-Names="Segoe UI" />
    </p>
    
    <div>
        <h3>Buscar os Registros de vendas entre</h3>

        <asp:Label ID="lMinData_SimpleSearch" runat="server" CssClass="text-justify" Font-Bold="True" Font-Names="Segoe UI" Text="Data Mínima" />
        <asp:TextBox runat="server" ID="tbMinDate_SimpleSearch" MaxLength="10" placeholder="dd/mm/aaaa" Height="25px" Width="200px" />

        <br />

        <asp:Label ID="lMaxData_SimpleSearch" runat="server" CssClass="text-justify" Font-Bold="True" Font-Names="Segoe UI" Text="Data Máxima" />
        <asp:TextBox runat="server" ID="tbMaxDate_SimplesSearch" MaxLength="10" placeholder="dd/mm/aaaa" Height="25px" Width="200px" Font-Names="Segoe UI" />

        <asp:Button ID="btnSimpleSearch" runat="server" Text="Pesquisar" OnClick="BtnSimpleSearch_Click" CssClass="btn" BackColor="#1DA3CF" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" Font-Names="Segoe UI" />
    </div>

    <br />
    <br />
</asp:Content>
