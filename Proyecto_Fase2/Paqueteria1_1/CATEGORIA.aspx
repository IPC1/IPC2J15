<%@ Page Title="" Language="C#" MasterPageFile="~/ADMINISTRADOR.master" AutoEventWireup="true" CodeFile="CATEGORIA.aspx.cs" Inherits="CATEGORIA" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <table style="width:100%;">
        <tr>
            <td style="width: 149px">&nbsp;</td>
            <td class="auto-style4" style="width: 392px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 149px">CATEGORIA</td>
            <td class="auto-style4" style="width: 392px">
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="VER" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 149px">IMPUESTO</td>
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

