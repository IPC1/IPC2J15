using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ServiceWe_June
{
    public partial class Devoluciones : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void devolver_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
            servicio.deletePrestamo(devolverLibro.Text, Convert.ToInt32(devolverCarnet.Text));
        }
    }
}