<%@ Page Title="" Language="C#" MasterPageFile="~/DIRECTOR.master" AutoEventWireup="true" CodeFile="DBUSCAR.aspx.cs" Inherits="DBUSCAR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 155px">Codigo de Empleado</td>
            <td style="width: 165px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="BUSCAR" />
            </td>
        </tr>
        <tr>
            <td style="width: 155px">&nbsp;</td>
            <td style="width: 165px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>

