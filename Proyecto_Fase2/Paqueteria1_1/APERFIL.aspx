<%@ Page Title="" Language="C#" MasterPageFile="~/ADMINISTRADOR.master" AutoEventWireup="true" CodeFile="APERFIL.aspx.cs" Inherits="APERFIL" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder2">
&nbsp;<asp:Label ID="Label1" runat="server" Text="CodAdministrador"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="codEmpleado" DataSourceID="SqlDataSource1" EnableModelValidation="True" AllowSorting="True">
    <Columns>
        <asp:BoundField DataField="codEmpleado" HeaderText="codEmpleado" SortExpression="codEmpleado" InsertVisible="False" ReadOnly="True" />
        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
        <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
        <asp:BoundField DataField="dpi" HeaderText="dpi" SortExpression="dpi" />
        <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
        <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
        <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
        <asp:BoundField DataField="sueldo" HeaderText="sueldo" SortExpression="sueldo" />
        <asp:BoundField DataField="codAsigSucursal" HeaderText="codAsigSucursal" SortExpression="codAsigSucursal" />
        <asp:BoundField DataField="codUsuario" HeaderText="codUsuario" SortExpression="codUsuario" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:paqueteriaConnectionString2 %>" SelectCommand="SELECT * FROM [empleado] WHERE ([codEmpleado] = @codEmpleado)" DeleteCommand="DELETE FROM [empleado] WHERE [codEmpleado] = @codEmpleado" InsertCommand="INSERT INTO [empleado] ([nombre], [apellido], [dpi], [telefono], [direccion], [tipo], [sueldo], [codAsigSucursal], [codUsuario]) VALUES (@nombre, @apellido, @dpi, @telefono, @direccion, @tipo, @sueldo, @codAsigSucursal, @codUsuario)" UpdateCommand="UPDATE [empleado] SET [nombre] = @nombre, [apellido] = @apellido, [dpi] = @dpi, [telefono] = @telefono, [direccion] = @direccion, [tipo] = @tipo, [sueldo] = @sueldo, [codAsigSucursal] = @codAsigSucursal, [codUsuario] = @codUsuario WHERE [codEmpleado] = @codEmpleado">
    <DeleteParameters>
        <asp:Parameter Name="codEmpleado" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="nombre" Type="String" />
        <asp:Parameter Name="apellido" Type="String" />
        <asp:Parameter Name="dpi" Type="Int32" />
        <asp:Parameter Name="telefono" Type="Int32" />
        <asp:Parameter Name="direccion" Type="String" />
        <asp:Parameter Name="tipo" Type="String" />
        <asp:Parameter Name="sueldo" Type="Int32" />
        <asp:Parameter Name="codAsigSucursal" Type="Int32" />
        <asp:Parameter Name="codUsuario" Type="Int32" />
    </InsertParameters>
    <SelectParameters>
        <asp:ControlParameter ControlID="TextBox1" Name="codEmpleado" PropertyName="Text" Type="Int32" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="nombre" Type="String" />
        <asp:Parameter Name="apellido" Type="String" />
        <asp:Parameter Name="dpi" Type="Int32" />
        <asp:Parameter Name="telefono" Type="Int32" />
        <asp:Parameter Name="direccion" Type="String" />
        <asp:Parameter Name="tipo" Type="String" />
        <asp:Parameter Name="sueldo" Type="Int32" />
        <asp:Parameter Name="codAsigSucursal" Type="Int32" />
        <asp:Parameter Name="codUsuario" Type="Int32" />
        <asp:Parameter Name="codEmpleado" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>

