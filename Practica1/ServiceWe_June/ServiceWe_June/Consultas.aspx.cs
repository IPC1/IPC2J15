using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceWe_June
{
    public partial class Consultas : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resConsulta_Click(object sender, EventArgs e)
        {
            int carnet = Convert.ToInt32(TextBox1.Text);
            string libro = TextBox2.Text;
            int consulta = 0;
            if (libro == "" && carnet==0)
            {
                TextBox3.Text = "No hay datos que consultar";
            }
            else if (libro == "" && carnet != 0)
            {
                consulta= Convert.ToInt32(servicio.getReservasCarnet(carnet));
                TextBox3.Text = "El carnet "+carnet+" tiene " + consulta + " reservas.";
            }
            else if (carnet == 0 && libro != "")
            {
                consulta = Convert.ToInt32(servicio.getReservasLibro(libro));
                TextBox3.Text = "El libro "+libro+" tiene " + consulta + " reservas.";
            }
            else if (libro != "" && carnet != 0)
            {
                consulta = Convert.ToInt32(servicio.comprobarReserva(carnet, libro));
                if (consulta != 0)
                {
                    TextBox3.Text = "La reserva del carnet " + carnet + " para el libro " + libro + " SI existe";
                }
                else
                {
                    TextBox3.Text = "La reserva del carnet " + carnet + " para el libro " + libro + " NO existe";
                }
            }

            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void prestamos_Click(object sender, EventArgs e)
        {
            int carnet = Convert.ToInt32(TextBox1.Text);
            string libro = TextBox2.Text;
            int consulta = 0;
            if (libro == "" && carnet == 0)
            {
                TextBox3.Text = "No hay datos que consultar";
            }
            else if (libro == "" && carnet != 0)
            {
                consulta = Convert.ToInt32(servicio.getPrestamosCarnet(carnet));
                TextBox3.Text = "El carnet " + carnet + " tiene " + consulta + " prestamos actuales.";
            }
            else if (carnet == 0 && libro != "")
            {
                consulta = Convert.ToInt32(servicio.getPrestamosLibro(libro));
                TextBox3.Text = "El libro " + libro + " tiene " + consulta + " existencias en prestamo.";
            }
            else if (libro != "" && carnet != 0)
            {
                consulta = 0;// Convert.ToInt32(servicio.comprobarPrestamo(carnet, libro));
                if (consulta != 0)
                {
                    TextBox3.Text = "El prestamo del carnet " + carnet + " para el libro " + libro + " SI existe";
                }
                else
                {
                    TextBox3.Text = "El prestamo del carnet " + carnet + " para el libro " + libro + " NO existe";
                }
            }

            TextBox1.Text = "";
            TextBox2.Text = "";

        }

        protected void topFive_Click(object sender, EventArgs e)
        {
            int carnet = Convert.ToInt32(TextBox1.Text);
            string libro = TextBox2.Text;
            string top = servicio.TopFive();
            TextBox3.Text = "Los libros más vistos son: " + top;
        }
    }
}