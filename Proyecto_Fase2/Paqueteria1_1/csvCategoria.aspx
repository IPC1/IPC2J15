<%@ Page Title="" Language="C#" MasterPageFile="~/ADMINISTRADOR.master" AutoEventWireup="true" CodeFile="csvCategoria.aspx.cs" Inherits="CSV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
&nbsp;&nbsp;
    <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AGREGAR" />
&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="codCategoria" DataSourceID="SqlDataSource1" EnableModelValidation="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="codCategoria" HeaderText="codCategoria" InsertVisible="False" ReadOnly="True" SortExpression="codCategoria" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="impuesto" HeaderText="impuesto" SortExpression="impuesto" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:paqueteriaConnectionString %>" DeleteCommand="DELETE FROM [categoria] WHERE [codCategoria] = @codCategoria" InsertCommand="INSERT INTO [categoria] ([nombre], [impuesto]) VALUES (@nombre, @impuesto)" SelectCommand="SELECT * FROM [categoria]" UpdateCommand="UPDATE [categoria] SET [nombre] = @nombre, [impuesto] = @impuesto WHERE [codCategoria] = @codCategoria">
        <DeleteParameters>
            <asp:Parameter Name="codCategoria" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="nombre" Type="String" />
            <asp:Parameter Name="impuesto" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nombre" Type="String" />
            <asp:Parameter Name="impuesto" Type="Int32" />
            <asp:Parameter Name="codCategoria" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
&nbsp;
</asp:Content>

