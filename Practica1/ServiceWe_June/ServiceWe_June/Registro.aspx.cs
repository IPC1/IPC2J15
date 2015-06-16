using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceWe_June
{
    public partial class Registro : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio.insertCarnet(TextBox1.Text, Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text));
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

    }
}