<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="ServiceWe_June.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 126px">CARNET</td>
            <td style="width: 517px">
                <asp:TextBox ID="TextBox1" runat="server" Width="252px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="resConsulta" runat="server" Text="Reservas" Width="105px" OnClick="resConsulta_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 126px">LIBRO</td>
            <td style="width: 517px">
                <asp:TextBox ID="TextBox2" runat="server" Width="252px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="prestamos" runat="server" Text="Prestamos" Width="80px" OnClick="prestamos_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 126px">&nbsp;</td>
            <td style="width: 517px">
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" Width="498px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <asp:Button ID="topFive" runat="server" Text="Top Five" Width="103px" OnClick="topFive_Click" />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
