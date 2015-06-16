<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Prestamos.aspx.cs" Inherits="ServiceWe_June.Prestamos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="height: 30px">&nbsp;CARNET</td>
            <td style="width: 421px; height: 30px;">
                <asp:TextBox ID="TextBox1" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td style="height: 30px">
                <asp:Button ID="prestar" runat="server" Text="Prestar" Width="73px" />
            </td>
        </tr>
        <tr>
            <td>LIBRO</td>
            <td style="width: 421px">
                <asp:TextBox ID="TextBox2" runat="server" Width="262px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="comprobar" runat="server" Text="Comprobar Reserva" Width="122px" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 421px">&nbsp;</td>
            <td>
                <asp:Button ID="reservar" runat="server" Text="Reservar" Width="74px" />
            </td>
        </tr>
    </table>
</asp:Content>
