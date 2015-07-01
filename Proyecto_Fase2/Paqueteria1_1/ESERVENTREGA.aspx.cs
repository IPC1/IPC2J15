using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ESERVENTREGA : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int casilla = Convert.ToInt32(TextBox1.Text);
        GridView1.DataSource = servicio.cargarPaquetecasillaInter(casilla);
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int casilla = Convert.ToInt32(TextBox2.Text);
        int paquete = Convert.ToInt32(TextBox1.Text);
        string estado = CheckBoxList1.SelectedItem.Text;
        servicio.cargarEstadoPaquete(estado, paquete);
        GridView1.DataSource = servicio.cargarPaquetecasillaInter(casilla);
        GridView1.DataBind();
    }
}