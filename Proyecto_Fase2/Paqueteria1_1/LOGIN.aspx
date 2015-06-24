<%@ Page Title="" Language="C#" MasterPageFile="~/GENERAL.master" AutoEventWireup="true" CodeFile="LOGIN.aspx.cs" Inherits="LOGIN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 144px;
        }
        .auto-style5 {
            width: 174px;
        }
        .auto-style6 {
            width: 144px;
        }
        .auto-style7 {
            text-align: left;
            width: 251px;
        }
        .auto-style8 {
            height: 23px;
            text-align: left;
            width: 251px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="auto-style1">LOG IN&nbsp;</h1>
    <p class="auto-style1">
        &nbsp;</p>
    <p class="auto-style1">
        <table style="width:100%;">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style6">USUARIO</td>
                            <td class="auto-style7">
                                <asp:TextBox ID="TextBox1" runat="server" Width="238px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">CONTRASEÑA</td>
                            <td class="auto-style8">
                                <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="238px"></asp:TextBox>
                            </td>
                            <td class="auto-style2"></td>
                        </tr>
                        <tr>
                            <td class="auto-style6">ENTRAR COMO</td>
                            <td class="auto-style7">
                                <br />
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                    <asp:ListItem>cliente</asp:ListItem>
                                    <asp:ListItem>empleado</asp:ListItem>
                                    <asp:ListItem>administrador</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td>
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <asp:Button ID="loguear" runat="server" OnClick="loguear_Click" Text="LOG IN" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"  Width="525px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>

