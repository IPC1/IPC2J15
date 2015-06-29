using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DCONTRATAR : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        TextBox21.Text = (string)(this.Session["Departamento"]);
        TextBox1.Text = (servicio.getcodDeptoNombre(TextBox21.Text)).ToString();

    }
    
}