<%@ Page Title="" Language="C#" MasterPageFile="~/ADMINISTRADOR.master" AutoEventWireup="true" CodeFile="csvComision.aspx.cs" Inherits="CATEGORIAS" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder2">
    &nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="codSucursal" DataSourceID="SqlDataSource1" EnableModelValidation="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="codSucursal" HeaderText="codSucursal" InsertVisible="False" ReadOnly="True" SortExpression="codSucursal" />
            <asp:BoundField DataField="pais" HeaderText="pais" SortExpression="pais" />
            <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
            <asp:BoundField DataField="noEmpleados" HeaderText="noEmpleados" SortExpression="noEmpleados" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
            <asp:BoundField DataField="comision" HeaderText="comision" SortExpression="comision" />
            <asp:BoundField DataField="codSede" HeaderText="codSede" SortExpression="codSede" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:paqueteriaConnectionString %>" DeleteCommand="DELETE FROM [sucursal] WHERE [codSucursal] = @codSucursal" InsertCommand="INSERT INTO [sucursal] ([pais], [direccion], [noEmpleados], [telefono], [comision], [codSede], [nombre]) VALUES (@pais, @direccion, @noEmpleados, @telefono, @comision, @codSede, @nombre)" SelectCommand="SELECT * FROM [sucursal]" UpdateCommand="UPDATE [sucursal] SET [pais] = @pais, [direccion] = @direccion, [noEmpleados] = @noEmpleados, [telefono] = @telefono, [comision] = @comision, [codSede] = @codSede, [nombre] = @nombre WHERE [codSucursal] = @codSucursal">
        <DeleteParameters>
            <asp:Parameter Name="codSucursal" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="pais" Type="String" />
            <asp:Parameter Name="direccion" Type="String" />
            <asp:Parameter Name="noEmpleados" Type="Int32" />
            <asp:Parameter Name="telefono" Type="Int32" />
            <asp:Parameter Name="comision" Type="Int32" />
            <asp:Parameter Name="codSede" Type="Int32" />
            <asp:Parameter Name="nombre" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="pais" Type="String" />
            <asp:Parameter Name="direccion" Type="String" />
            <asp:Parameter Name="noEmpleados" Type="Int32" />
            <asp:Parameter Name="telefono" Type="Int32" />
            <asp:Parameter Name="comision" Type="Int32" />
            <asp:Parameter Name="codSede" Type="Int32" />
            <asp:Parameter Name="nombre" Type="String" />
            <asp:Parameter Name="codSucursal" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <table style="width:100%;">
        <tr>
            <td>AGREGAR NUEVA SUCURSAL</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td style="width: 138px">NOMBRE</td>
                        <td style="width: 126px">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 138px">PAIS</td>
                        <td style="width: 126px">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td style="width: 136px">DIRECCION</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 136px">EMPLEADOS</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 136px">
                            <table style="width:100%;">
                                <tr>
                                    <td>TELEFONO</td>
                                </tr>
                                <tr>
                                    <td>COMISION</td>
                                </tr>
                                <tr>
                                    <td>SEDE<br />
                                        <br />
                                        <br />
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table style="width:100%;">
                                <tr>
                                    <td>
                                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AGREGAR" />
            </td>
        </tr>
    </table>
&nbsp;
</asp:Content>

