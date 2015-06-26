using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CATEGORIAS : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
  
    
    protected void Page_Load(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        string categoria = servicio.getSede();
        string[] stringSeparators = new string[] { "," };
        string[] resultado = categoria.Split(stringSeparators, StringSplitOptions.None);

        foreach (string s in resultado)
        {
            ListBox1.Items.Add(s);
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string nombre = TextBox1.Text;
        string pais = TextBox2.Text;
        string direccion= TextBox3.Text;
        int empleados = Convert.ToInt32(TextBox4.Text);
        int telefono = Convert.ToInt32(TextBox6.Text);
        int comision =Convert.ToInt32( TextBox7.Text);
        string sede = ListBox1.SelectedItem.Text;
        servicio.insertarSucursal(nombre, pais, direccion, empleados, telefono, comision, sede);
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
    }
    
    
}