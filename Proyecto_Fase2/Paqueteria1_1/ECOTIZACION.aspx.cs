using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ECOTIZACION : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        string categoria = servicio.getCategoria();
        string[] stringSeparators = new string[] { "," };
        string[] resultado = categoria.Split(stringSeparators, StringSplitOptions.None);

        foreach (string s in resultado)
        {
            ListBox1.Items.Add(s);
        }
        ListBox2.Items.Clear();
        string sucursal = servicio.getSucursal();
        resultado = sucursal.Split(stringSeparators, StringSplitOptions.None);
        foreach (string s in resultado)
        {
            ListBox2.Items.Add(s);
        }
    }
    protected void CALCULAR_Click(object sender, EventArgs e)
    {
        int peso = Convert.ToInt32(TextBox1.Text);
        string categoria = ListBox1.SelectedValue.ToString();
        string sucursal = ListBox2.SelectedValue.ToString();
        int impuesto = servicio.getImpuesto(categoria);
        int valor = Convert.ToInt32(TextBox3.Text);
        double costo = (peso * 5) + (impuesto * valor / 100);
        double comision = servicio.getComision(sucursal);
        TextBox4.Text = comision.ToString();
        comision = (comision * valor / 100);
        double costoT = costo + comision;
        TextBox5.Text = costoT.ToString();
    }
}