<%@ Page Title="" Language="C#" MasterPageFile="~/EMPLEADO.master" AutoEventWireup="true" CodeFile="ESERVENTREGA.aspx.cs" Inherits="ESERVENTREGA" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 438px">
                <table style="width: 78%;">
                    <tr>
                        <td style="width: 126px">
                            <asp:Label ID="Label1" runat="server" Text="Casilla Internacional"></asp:Label>
                        </td>
                        <td style="width: 184px">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 126px">&nbsp;</td>
                        <td style="width: 184px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ver" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 126px">&nbsp;</td>
                        <td style="width: 184px">&nbsp;</td>
                    </tr>
                </table>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style3" style="width: 131px">&nbsp;Código Paquete</td>
                        <td style="width: 110px">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3" style="width: 131px">Estado</td>
                        <td style="width: 110px">
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                <asp:ListItem>Entregado</asp:ListItem>
                                <asp:ListItem>Perdido</asp:ListItem>
                                <asp:ListItem>Devuelto</asp:ListItem>
                            </asp:CheckBoxList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cambiar" OnClick="Button2_Click" />
            </td>
            <td class="auto-style3" style="width: 138px">
                <asp:GridView ID="GridView1" runat="server" style="margin-left: 0px">
                </asp:GridView>
            </td>
            <td>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <a href="ESERVICIO.aspx">VOLVER</a></td>
        </tr>
    </table>
</asp:Content>

