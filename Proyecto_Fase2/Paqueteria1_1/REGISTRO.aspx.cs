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
    protected void REGISTRAR_Click(object sender, EventArgs e)
    {
        
        string nombre = TNOMBRE.Text;
        string apellido = TAPELLIDO.Text;
        string direccion = TDIRECCION.Text;
        string usuario = TUSUARIO.Text;
        int contraseña = Convert.ToInt32(TCONTRASEÑA.Text);
        int nit = Convert.ToInt32(TNIT.Text);
        int tarjeta = Convert.ToInt32(TTARJETA.Text);
        int telefono = Convert.ToInt32(TTELEFONO.Text);
        servicio.reservarCliente(nombre, apellido, nit, telefono, direccion, tarjeta, usuario, contraseña);

    }
}