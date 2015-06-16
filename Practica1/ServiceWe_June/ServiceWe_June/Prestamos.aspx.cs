using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceWe_June
{
    public partial class Prestamos : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void prestar_Click(object sender, EventArgs e)
        {
            string libro = TextBox2.Text;
            int carnet = Convert.ToInt32(TextBox1.Text);
            int texto = Convert.ToInt32(TextBox1.Text);
            int prestamos = Convert.ToInt32(servicio.getPrestamosCarnet(texto)) ;
            
            if (prestamos < 6)
            {
                int reserva = Convert.ToInt32(servicio.comprobarReserva(carnet, libro));
                if (reserva != 0)
                {
                    servicio.deleteReserva(libro, carnet);
                    servicio.insertPrestamo(libro, carnet);
                }
                else
                {
                    servicio.insertPrestamo(libro, carnet);
                }
                
            }
            else
            {
                Aviso.Text = "No puede prestar más de 5 libros";
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void reservar_Click(object sender, EventArgs e)
        {
            string libro = TextBox2.Text;
            int carnet = Convert.ToInt32(TextBox1.Text); 
            int reservas = Convert.ToInt32(servicio.getReservasLibro(TextBox2.Text));
            int existencias = Convert.ToInt32(servicio.getTomosLibros(TextBox2.Text));
            if (reservas < existencias)
            {
                servicio.insertReserva(libro, carnet);
            }
            else
            {
                Aviso.Text = "Ya hay reservas para cada una de las existencias";
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void comprobar_Click(object sender, EventArgs e)
        {
            string libro = TextBox2.Text;
            int carnet = Convert.ToInt32(TextBox1.Text); 
            int reserva = Convert.ToInt32(servicio.comprobarReserva(carnet, libro));
            if (reserva != 0)
            {
                Aviso.Text = "La reserva con carnet no." + carnet + " para el libro" + libro + "SI existe.";
            }else{
                Aviso.Text = "NO existe La reserva con carnet no." + carnet + " para el libro" + libro ;
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string libro = TextBox2.Text;
            int carnet = Convert.ToInt32(TextBox1.Text);
            int reserva = Convert.ToInt32(servicio.comprobarReserva(carnet, libro));
            if (reserva != 0)
            {
                servicio.deleteReserva(libro, carnet);
            }
            else
            {
                Aviso.Text = "No hay reservas con esos datos";
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}