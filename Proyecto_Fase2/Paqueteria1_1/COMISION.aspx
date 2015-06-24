<%@ Page Title="" Language="C#" MasterPageFile="~/ADMINISTRADOR.master" AutoEventWireup="true" CodeFile="COMISION.aspx.cs" Inherits="CATEGORIAS" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <table style="width:100%;">
        <tr>
            <td style="width: 149px">&nbsp;</td>
            <td class="auto-style4" style="width: 392px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 149px">SUCURSAL</td>
            <td class="auto-style4" style="width: 392px">
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="VER" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 149px">COMISION</td>
            <td class="auto-style4" style="width: 392px">
                <asp:TextBox ID="TextBox1" runat="server" Width="178px"></asp:TextBox>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GUARDAR" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="DESCARTAR" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

