using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ESERVCLIENTE : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = servicio.cargarCLIENTEAUTOcasilla();
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int casilla = Convert.ToInt32(TextBox2.Text);
        int cliente = Convert.ToInt32(TextBox3.Text);
        servicio.autorizarCliente(cliente, casilla);
        GridView1.DataSource = servicio.cargarCLIENTEAUTOcasilla();
        GridView1.DataBind();
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int casilla = Convert.ToInt32(TextBox1.Text);
        GridView1.DataSource = servicio.cargarCLIENTEcasilla(casilla);
        GridView1.DataBind();
    }
}