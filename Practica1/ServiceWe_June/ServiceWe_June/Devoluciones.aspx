<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Devoluciones.aspx.cs" Inherits="ServiceWe_June.Devoluciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width:100%;">
        <tr>
            <td>CARNET</td>
            <td style="width: 420px">
                <asp:TextBox ID="devolverCarnet" runat="server" Width="267px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 30px">LIBRO</td>
            <td style="width: 420px; height: 30px">
                <asp:TextBox ID="devolverLibro" runat="server" Width="270px"></asp:TextBox>
            </td>
            <td style="height: 30px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 420px">&nbsp;</td>
            <td>
                <asp:Button ID="devolver" runat="server" Text="Devolver" OnClick="devolver_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
