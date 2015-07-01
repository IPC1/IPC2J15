<%@ Page Title="" Language="C#" MasterPageFile="~/EMPLEADO.master" AutoEventWireup="true" CodeFile="ESERVCLIENTE.aspx.cs" Inherits="ESERVCLIENTE" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 1935px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Casilla Internacional</td>
            <td style="width: 487px">
                <asp:TextBox ID="TextBox1" runat="server" Width="92px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" style="margin-left: 0px" Text="BUSCAR" OnClick="Button1_Click" />
&nbsp;&nbsp; </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <table style="width:100%;">
        <tr>
            <td style="width: 174px">Nueva Casilla Internacional</td>
            <td style="width: 163px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="PENDIENTES" />
            </td>
        </tr>
        <tr>
            <td style="width: 174px">Código de Cliente</td>
            <td style="width: 163px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="AUTORIZAR" OnClick="Button2_Click" Width="123px" />
            </td>
        </tr>
        <tr>
            <td style="width: 174px">&nbsp;</td>
            <td style="width: 163px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

