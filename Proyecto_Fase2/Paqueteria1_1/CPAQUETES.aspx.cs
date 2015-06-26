using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CPAQUETES : System.Web.UI.Page
{
    localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    
    {
        //selecciona los paquetes de un cliente
        string casilla = (string)(Session["ID"]);
        TextBox1.Text = casilla;
        string[] paquetes;
        string codPaquetes = servicio.getcodPaquetes(Convert.ToInt32(casilla));
        paquetes=codPaquetes.Split(',');
        
        //obtiene una lista del ultimo lote de cada paquete
        List<string> lote = new List<string>();
        string valor;
        string cadena;
        string[] split;
        foreach(string element in  paquetes){
            cadena = servicio.getcodLote(Convert.ToInt32(element));
            split = cadena.Split(',');
            valor = split.GetValue(0).ToString();
            lote.Add(valor);
        }

        //lista del codigo del ultimo estado de cada lote
        List<string> codEstado = new List<string>();
        foreach (string element in lote)
        {
            cadena = servicio.getcodEstadoLote(Convert.ToInt32(element));
            split = cadena.Split(',');
            valor = split.GetValue(0).ToString();
            codEstado.Add(valor);
        }

        //lista del nombre de la ultima sucursal de cada lote
        List<string> Sucursal = new List<string>();
        string nombre;
        foreach (string element in codEstado)
        {
            cadena = servicio.getcodSucursalAsig(Convert.ToInt32(element));
            split = cadena.Split(',');
            valor = split.GetValue(0).ToString();
            nombre = servicio.getSucursalEstado(Convert.ToInt32(valor));
            Sucursal.Add(nombre);
        }
        
        //lista del ultimo estado de cada lote
        List<string> estado = new List<string>();
        foreach (string element in codEstado)
        {
            valor= servicio.getEstadoHistorial(Convert.ToInt32(element));
            estado.Add(valor);
        }
        insertarValores(paquetes,lote,estado,Sucursal);
    }

    public void insertarValores(string[] paquetes, List<string> lote, List<string> estado, List<string> sucursal)
    {
        DataTable table = new DataTable("Tabla1");
        DataRow row = table.NewRow();
        int i = 0;
        foreach (string element in paquetes)
        {
         row["Paquete"] = element;
         row["Lote"] = lote.ElementAt(i);
         row["Estado"] = estado.ElementAt(i);
         row["Sucursal"] = sucursal.ElementAt(i);
         table.Rows.Add(row);
         i++;
        }
       
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
}