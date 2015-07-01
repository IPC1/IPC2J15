using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DBUSCAR : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int casilla = Convert.ToInt32(TextBox1.Text);
        GridView1.DataSource = servicio.cargarCLIENTEcasilla(casilla);
        GridView1.DataBind();
    }
}