<%@ Page Title="" Language="C#" MasterPageFile="~/GENERAL.master" AutoEventWireup="true" CodeFile="REGISTRO.aspx.cs" Inherits="LOGIN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 65px;
        }
        .auto-style2 {
            width: 68px;
        }
        .auto-style3 {
            width: 67px;
        }
        .auto-style4 {
            width: 233px;
        }
        .auto-style5 {
            width: 234px;
        }
        .auto-style6 {
            width: 236px;
        }
        .auto-style7 {
            width: 65px;
            height: 26px;
        }
        .auto-style8 {
            width: 233px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style10 {
            width: 541px;
        }
        .auto-style11 {
            width: 69px;
        }
        .auto-style12 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <h1 class="auto-style12">REGISTRO</h1>
    <br />
    <br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style10">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style4">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7">&nbsp;</td>
                        <td class="auto-style8">
                            <asp:Label ID="NOMBRE" runat="server" Text="NOMBRE"></asp:Label>
                        </td>
                        <td class="auto-style9">
                            <asp:TextBox ID="TNOMBRE" runat="server" style="margin-left: 17px" Width="212px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style4">
                            <asp:Label ID="APELLIDO" runat="server" Text="APELLIDO"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TAPELLIDO" runat="server" style="margin-left: 17px" Width="210px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style5">
                            <asp:Label ID="NIT" runat="server" Text="NIT"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TNIT" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-left: 0px" Width="206px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style5">
                            <asp:Label ID="DIRECCION" runat="server" Text="DIRECCION"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TDIRECCION" runat="server" Width="203px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td class="auto-style5">
                            <asp:Label ID="TARJETA" runat="server" Text="TARJETA"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TTARJETA" runat="server" Width="206px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style6">
                            <asp:Label ID="TELEFONO" runat="server" Text="TELEFONO"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TTELEFONO" runat="server" Width="206px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style6">
                            <asp:Label ID="USUARIO" runat="server" Text="USUARIO"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TUSUARIO" runat="server" Width="204px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style6">
                            <asp:Label ID="CONTRASEÑA" runat="server" Text="CONTRASEÑA"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TCONTRASEÑA" runat="server" Width="204px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>
                            <asp:Button ID="REGISTRAR" runat="server" Height="27px" Text="REGISTRAR" Width="94px" OnClick="REGISTRAR_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

