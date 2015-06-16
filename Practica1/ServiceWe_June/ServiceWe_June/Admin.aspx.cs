using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceWe_June
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void libro_Click(object sender, EventArgs e)
        {
            Server.Transfer("Libro.aspx");
        }

        protected void registro_Click(object sender, EventArgs e)
        {
            Server.Transfer("Registro.aspx");
        }

    }
}