<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ServiceWe_June.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width:100%;">
        <tr>
            <td>NOMBRE</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="356px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>DPI</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="355px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>TELEFONO</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="359px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Registrar" />
            </td>
        </tr>
    </table>
</asp:Content>
