using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    private static string sqlConnectionString = "Data Source=localhost;Initial Catalog=paqueteria;Integrated Security=True";
    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public int insertarUsuario(string nombre, string contraseña)
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        string sql = "SET identity_insert usuario off;"
        +"INSERT INTO usuario (nombre, contraseña, tipo)"
        +"values ('"+nombre+"', '"+contraseña+"', 'cliente');"
        +"SELECT usuario (codUsuario) where  nombre= '"+nombre+"' and contraseña ='"+contraseña+"';";
        //nuestro comando
        SqlCommand comando = new SqlCommand();
        //asignamos al objeto de conexión la cadena
        conexion.ConnectionString = sqlConnectionString;
        //indicamos al comando la conexión
        comando.Connection = conexion;
        //se abre la conexión
        conexion.Open();
        //asignamos al comando la consulta de COUNT
        comando.CommandText = sql;
        //guardamos el resultado en el TextBox txt_num_ventas
        int palabra = Convert.ToInt32(comando.ExecuteScalar());

        return palabra;
    }


    [WebMethod]
    public string insertarCliente(string nombre, string apellido, int nit, int telefono, string direccion, int tarjeta, int usuario)
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        string sql = "USE paqueteria;"
        +"SET identity_insert clientes off;"
        +"INSERT INTO cliente (nombre, apellidos, nit, telefono, direccion, tarjeta, codUsuario)"
        +"values ('"+nombre+"', '"+apellido+"',"+ nit+", "+telefono+", '"+direccion+"', "+tarjeta+", "+usuario+");"
        +"select casillaInternacional from cliente where codUsuario= "+usuario+";";
        //nuestro comando
        SqlCommand comando = new SqlCommand();
        //asignamos al objeto de conexión la cadena
        conexion.ConnectionString = sqlConnectionString;
        //indicamos al comando la conexión
        comando.Connection = conexion;
        //se abre la conexión
        conexion.Open();
        //asignamos al comando la consulta de COUNT
        comando.CommandText = sql;
        //guardamos el resultado en el TextBox txt_num_ventas
        string palabra = (comando.ExecuteScalar()).ToString();

        return palabra;
    }

}