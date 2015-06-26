<%@ Page Title="" Language="C#" MasterPageFile="~/CLIENTES.master" AutoEventWireup="true" CodeFile="CPAQUETES.aspx.cs" Inherits="CPAQUETES" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder2">
&nbsp;<asp:Label ID="Label1" runat="server" Text="Casilla Internacional: "></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Enabled="False" ReadOnly="True" Width="43px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="int" HeaderText="Paquete" ReadOnly="True" SortExpression="int" />
            <asp:BoundField HeaderText="Lote" />
            <asp:BoundField HeaderText="Estado" />
            <asp:BoundField HeaderText="Sucursal" />
        </Columns>
    </asp:GridView>
</asp:Content>

