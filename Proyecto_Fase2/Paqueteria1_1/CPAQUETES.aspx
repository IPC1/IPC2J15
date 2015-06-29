<%@ Page Title="" Language="C#" MasterPageFile="~/CLIENTES.master" AutoEventWireup="true" CodeFile="CPAQUETES.aspx.cs" Inherits="CPAQUETES" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder2">
&nbsp;<asp:Label ID="Label1" runat="server" Text="Casilla Internacional: "></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Enabled="False" ReadOnly="True" Width="43px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="codPaquete" DataSourceID="SqlDataSource2" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="codPaquete" HeaderText="codPaquete" InsertVisible="False" ReadOnly="True" SortExpression="codPaquete" />
            <asp:BoundField DataField="casillaInternacional" HeaderText="casillaInternacional" SortExpression="casillaInternacional" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:paqueteriaConnectionString5 %>" SelectCommand="SELECT [codPaquete], cliente.casillaInternacional FROM paquete, cliente where paquete.casillaInternacional = cliente.casillaInternacional"></asp:SqlDataSource>
&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:paqueteriaConnectionString3 %>" SelectCommand="SELECT [casillaInternacional], [nombre] FROM [cliente]"></asp:SqlDataSource>
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="codPaquete" DataValueField="casillaInternacional">
    </asp:DropDownList>
</asp:Content>

