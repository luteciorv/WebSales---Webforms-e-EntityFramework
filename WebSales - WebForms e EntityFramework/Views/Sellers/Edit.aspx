<%@ Page Title="Editar Vendedor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WebSales___WebForms_e_EntityFramework.Views.Sellers.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar</h2>
    <p>Vendedor</p>

    <hr />

    <div class="form-group">
        <div>
            <asp:Label ID="lName" runat="server" CssClass="text-justify" Font-Bold="True" Font-Names="Segoe UI" Text="Nome" />
            <br />
            <asp:TextBox runat="server" ID="tbName" Height="25px" Width="150px" />

            <asp:Label ID="lWarningName" runat="server" BackColor="#CC0000" Font-Italic="True" Font-Names="Segoe UI" ForeColor="White" />
        </div>

        <br />

        <div>
            <asp:Label ID="lEmail" runat="server" CssClass="text-justify" Font-Bold="True" Font-Names="Segoe UI" Text="Email" />
            <br />
            <asp:TextBox runat="server" ID="tbEmail" Height="25px" Width="150px" />

            <asp:Label ID="lWarningEmail" runat="server" BackColor="#CC0000" Font-Italic="True" Font-Names="Segoe UI" ForeColor="White" />
        </div>

        <br />

        <div>
            <asp:Table ID="Table1" runat="server" CellSpacing="2">
                <asp:TableRow Font-Bold="true" Font-Size="16px" Font-Names="Sugoe UI" HorizontalAlign="Center" Width="70px">
                    <asp:TableCell>
                        Dia
                    </asp:TableCell>
                    <asp:TableCell>
                        Mês
                    </asp:TableCell>
                    <asp:TableCell>
                        Ano
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow HorizontalAlign="Center">
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="tbDataDay" MaxLength="2" Height="25px" Width="50px" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox runat="server" ID="tbDataMonth" MaxLength="2" Height="25px" Width="50px" />
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox runat="server" ID="tbDataYear" MaxLength="4" Height="25px" Width="100px" />
                    </asp:TableCell></asp:TableRow></asp:Table><div>
                <asp:Label ID="lWarningDate" runat="server" BackColor="#CC0000" Font-Italic="True" Font-Names="Segoe UI" ForeColor="White" />
            </div>

        </div>

        <br />

        <div>
            <asp:Label ID="lSalary" runat="server" CssClass="text-justify" Font-Bold="True" Font-Names="Segoe UI" Text="Salário (R$)" />
            <br />
            <asp:TextBox runat="server" ID="tbSalary" Height="25px" Width="150px" />

            <asp:Label ID="lWarningSalary" runat="server" BackColor="#CC0000" Font-Italic="True" Font-Names="Segoe UI" ForeColor="White" />
            <br />
        </div>

        <br />

        <div>
            <asp:Label ID="lDepartment" runat="server" CssClass="text-justify" Font-Bold="True" Font-Names="Segoe UI" Text="Departamento" />
            <br />
            <asp:DropDownList ID="ddlDepartments" runat="server" />

            <asp:Label ID="lWarningDepartment" runat="server" BackColor="#CC0000" Font-Italic="True" Font-Names="Segoe UI" ForeColor="White" />
        </div>

    </div>

    <br />

    <asp:Label ID="lWarningGeral" runat="server" BackColor="#CC0000" Font-Italic="True" Font-Names="Segoe UI" ForeColor="White" />

    <div>
        <asp:Button ID="btnUpdate" runat="server" Text="Atualizar" OnClick="BtnUpdate_Click" CssClass="btn" BackColor="#1DA3CF" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="White" /></div>

</asp:Content>
