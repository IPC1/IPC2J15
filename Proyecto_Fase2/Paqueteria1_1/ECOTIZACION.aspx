<%@ Page Title="" Language="C#" MasterPageFile="~/EMPLEADO.master" AutoEventWireup="true" CodeFile="ECOTIZACION.aspx.cs" Inherits="ECOTIZACION" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="height: 23px">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style2" style="width: 151px">PESO</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Width="121px"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2" style="width: 151px">CATEGORIA</td>
                        <td>
                            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2" style="width: 151px">VALOR</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td style="height: 23px"></td>
            <td style="height: 23px"></td>
        </tr>
        <tr>
            <td>&nbsp;SUCURSAL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;<table style="width:100%;">
                    <tr>
                        <td style="width: 145px">&nbsp;COMISION</td>
                        <td>
                <asp:TextBox ID="TextBox4" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 145px">COSTO TOTAL&nbsp;&nbsp;</td>
                        <td>
                            <asp:TextBox ID="TextBox5" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 145px">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="CALCULAR" runat="server" OnClick="CALCULAR_Click" Text="CALCULAR" />
            </td>
        </tr>
    </table>
</asp:Content>

