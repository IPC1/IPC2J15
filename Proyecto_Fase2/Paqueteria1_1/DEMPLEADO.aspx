<%@ Page Title="" Language="C#" MasterPageFile="~/DIRECTOR.master" AutoEventWireup="true" CodeFile="DEMPLEADO.aspx.cs" Inherits="DEMPLEADO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EnableModelValidation="True">
    <Columns>
        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
        <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
        <asp:BoundField DataField="dpi" HeaderText="dpi" SortExpression="dpi" />
        <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
        <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
        <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
        <asp:BoundField DataField="sueldo" HeaderText="sueldo" SortExpression="sueldo" />
        <asp:BoundField DataField="Expr1" HeaderText="Expr1" SortExpression="Expr1" />
        <asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:paqueteriaConnectionString6 %>" SelectCommand="SELECT empleado.nombre, empleado.apellido, empleado.dpi, empleado.telefono, empleado.direccion, empleado.tipo, empleado.sueldo, usuario.nombre AS Expr1, usuario.contraseña FROM empleado INNER JOIN usuario ON empleado.codUsuario = usuario.codUsuario"></asp:SqlDataSource>
</asp:Content>

