using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LOGIN : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void loguear_Click(object sender, EventArgs e)
    {
        string usuario = TextBox1.Text;
        string contraseña = TextBox2.Text;
        string tipo = RadioButtonList1.SelectedItem.Value;
        int verificacion= servicio.VerificarUsuario(usuario, contraseña, tipo);
        if (verificacion != 0)
        {
            if (tipo == "cliente")
            {
                Server.Transfer("CPAQUETES.aspx");
            }
            else if (tipo == "empleado")
            {
                Server.Transfer("EMPLEADO.aspx");
            }
            else if (tipo == "administrador")
            {
                Server.Transfer("ADMIN.aspx");
            }
            this.Session["UserID"] = verificacion;
            this.Session["UserName"] = usuario;
        }
        else
        {
            TextBox3.Text = "Error en los datos, volver a introducirlos.";
        }
        
    }
    
}