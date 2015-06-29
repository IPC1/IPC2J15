using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LOGOUT : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Session["ID"] = "";
        this.Session["Name"] = "";
        this.Session["Departamento"] = "";
        Server.Transfer("LOGIN.aspx");
    }
}