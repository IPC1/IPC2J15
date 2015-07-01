using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CPERFIL : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        //string categoria = Convert.ToInt32(this.Session["UserId"]);
       // string palabra= servicio.getCliente(categoria);
        string[] stringSeparators = new string[] { "," };
       // string[] resultado = categoria.Split(stringSeparators, StringSplitOptions.None);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int casilla = Convert.ToInt32(Session["UserID"]);
        GridView1.DataSource = servicio.cargarCLIENTEcasilla(casilla);
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}