<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Libro.aspx.cs" Inherits="ServiceWe_June.Libro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width:100%;">
        <tr>
            <td>NOMBRE</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="367px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>EXISTENCIAS</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="366px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>PAGINAS</td>
                    </tr>
                    <tr>
                        <td>TEMA</td>
                    </tr>
                    <tr>
                        <td>AUTOR</td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" Width="361px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" Width="364px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox5" runat="server" Width="363px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registrar" />
            </td>
        </tr>
    </table>
</asp:Content>
