<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WebSales___WebForms_e_EntityFramework.Views.Departments.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar</h2>
    <p>Departamento</p>

    <hr />

    <div class="form-group">
        <asp:Label ID="lName" runat="server" CssClass="text-justify" Font-Bold="True" Font-Names="Segoe UI" Text="Nome"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="tbName" Height="25px" Width="150px" />
        
        <asp:Label ID="lWarning" runat="server" BackColor="#CC0000" Font-Italic="True" Font-Names="Segoe UI" ForeColor="White"></asp:Label>
        
    </div>
  
    <div>
        <asp:Button ID="btnUpdate" runat="server" Text="Atualizar" OnClick="BtnUpdate_Click" CssClass="btn" BackColor="#1DA3CF" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" />
    </div>
</asp:Content>
