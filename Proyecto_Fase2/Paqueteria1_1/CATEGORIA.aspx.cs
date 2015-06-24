using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CATEGORIA : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        string categoria = servicio.getSucursal();
        string[] stringSeparators = new string[] { "," };
        string[] resultado = categoria.Split(stringSeparators, StringSplitOptions.None);

        foreach (string s in resultado)
        {
            ListBox1.Items.Add(s);
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
          string categoria = ListBox1.SelectedValue.ToString();
          TextBox1.Text = servicio.getImpuesto(categoria).ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int impuesto = Convert.ToInt32(TextBox1.Text);
        string categoria = ListBox1.SelectedValue.ToString();
        servicio.insertarImpuesto(categoria, impuesto);
        TextBox1.Text = servicio.getImpuesto(categoria).ToString(); 
    }
}