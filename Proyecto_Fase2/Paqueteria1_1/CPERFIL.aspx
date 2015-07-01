<%@ Page Title="" Language="C#" MasterPageFile="~/CLIENTES.master" AutoEventWireup="true" CodeFile="CPERFIL.aspx.cs" Inherits="CPERFIL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
&nbsp;<table style="width:100%;">
    <tr>
        <td>
            <table style="width:100%;">
                <tr>
                    <td style="width: 143px">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 0px" Text="GUARDAR" />
                    </td>
                    <td style="width: 279px">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="DESCARTAR" style="height: 26px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

