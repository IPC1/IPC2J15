<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="ServiceWe_June.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 126px">CARNET</td>
            <td style="width: 517px">
                <asp:TextBox ID="TextBox1" runat="server" Width="252px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="resConsulta" runat="server" Text="Reservas" Width="105px" />
            </td>
        </tr>
        <tr>
            <td style="width: 126px">LIBRO</td>
            <td style="width: 517px">
                <asp:TextBox ID="TextBox2" runat="server" Width="252px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="prestamos" runat="server" Text="Prestamos" Width="80px" />
            </td>
        </tr>
        <tr>
            <td style="width: 126px">&nbsp;</td>
            <td style="width: 517px">&nbsp;</td>
            <td>
                <asp:Button ID="topFive" runat="server" Text="Top Five" Width="103px" />
            </td>
        </tr>
    </table>
</asp:Content>
