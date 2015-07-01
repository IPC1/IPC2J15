<%@ Page Title="" Language="C#" MasterPageFile="~/DIRECTOR.master" AutoEventWireup="true" CodeFile="DCONTRATAR.aspx.cs" Inherits="DCONTRATAR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    &nbsp;<asp:Label ID="Label1" runat="server" Text="Cod"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="DEPARTAMENTO"></asp:Label>
    &nbsp;&nbsp;<asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:paqueteriaConnectionString6 %>" DeleteCommand="DELETE FROM [empleado] WHERE [codEmpleado] = @codEmpleado" InsertCommand="INSERT INTO [empleado] ([nombre], [apellido], [dpi], [telefono], [direccion], [tipo], [sueldo], [codAsigSucursal], [codUsuario]) VALUES (@nombre, @apellido, @dpi, @telefono, @direccion, @tipo, @sueldo, @codAsigSucursal, @codUsuario)" SelectCommand="SELECT * FROM [empleado] WHERE ([tipo] = @tipo)" UpdateCommand="UPDATE [empleado] SET [nombre] = @nombre, [apellido] = @apellido, [dpi] = @dpi, [telefono] = @telefono, [direccion] = @direccion, [tipo] = @tipo, [sueldo] = @sueldo, [codAsigSucursal] = @codAsigSucursal, [codUsuario] = @codUsuario WHERE [codEmpleado] = @codEmpleado">
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
            <asp:ControlParameter ControlID="TextBox21" Name="tipo" PropertyName="Text" Type="String" />
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
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="codEmpleado" DataSourceID="SqlDataSource1" EnableModelValidation="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="codEmpleado" HeaderText="codEmpleado" InsertVisible="False" ReadOnly="True" SortExpression="codEmpleado" />
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
</asp:Content>

