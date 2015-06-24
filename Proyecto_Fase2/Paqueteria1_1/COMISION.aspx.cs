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
        string categoria =servicio.getSucursal();
        string[] stringSeparators = new string[] { "," };
        string[] resultado = categoria.Split(stringSeparators, StringSplitOptions.None);
       
        foreach (string s in resultado)
        {
            ListBox1.Items.Add(s);
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int comision = Convert.ToInt32(TextBox1.Text);
        string sucursal = ListBox1.SelectedValue.ToString();
        servicio.insertarComision(sucursal, comision);
        TextBox1.Text = servicio.getComision(sucursal).ToString(); 

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string sucursal = ListBox1.SelectedValue;
        TextBox1.Text = servicio.getComision(sucursal).ToString();
        sucursal = ListBox1.SelectedValue;
        TextBox1.Text = sucursal;
       
    }
}