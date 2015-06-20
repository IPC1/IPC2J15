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
        string contraseña = TCONTRASEÑA.Text;
        int nit = Convert.ToInt32(TNIT.Text);
        int tarjeta = Convert.ToInt32(TTARJETA.Text);
        int telefono = Convert.ToInt32(TTELEFONO.Text);
        int cod = servicio.insertarUsuario(nombre, contraseña);
        servicio.insertarCliente(nombre, apellido, nit, telefono, direccion, tarjeta, cod);

    }
}