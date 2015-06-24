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
        +"SELECT codUsuario from usuario where  nombre= '"+nombre+"' and contraseña ='"+contraseña+"';";
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
        +"SET identity_insert cliente off;"
        +"INSERT INTO cliente (nombre, apellido, nit, telefono, direccion, tarjeta, codUsuario)"
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

    [WebMethod]
    public int VerificarUsuario(string nombre, string contraseña, string tipo)
    {
        SqlConnection conexion = new SqlConnection();
        string sql = "USE paqueteria;"
        + "declare @usuario int =(select codUsuario from usuario where nombre='" + nombre + "' and contraseña='" + contraseña + "' and tipo='" + tipo + "');"
        +"select casillaInternacional from cliente where codUsuario= @usuario";
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
    public string getCategoria()
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "select nombre from  categoria";
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
        DataSet dts = new DataSet();
        da.Fill(dts, "autor");
        DataTable dt = new DataTable();
        dt = dts.Tables["autor"];
        string palabra = "";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = palabra + "," + dr["nombre"].ToString();

        }
        return palabra;
    }

    [WebMethod]
    public string getSucursal()
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "select nombre from  sucursal";
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
        DataSet dts = new DataSet();
        da.Fill(dts, "autor");
        DataTable dt = new DataTable();
        dt = dts.Tables["autor"];
        string palabra = "";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = palabra + "," + dr["nombre"].ToString();

        }
        return palabra;
    }

   

    [WebMethod]
    public int getImpuesto(string nombre)
    {
        SqlConnection conexion = new SqlConnection();
        string sql = "USE paqueteria;"
        +"declare @cod int = (select codCategoria from Categoria where nombre= '"+nombre+"');"
        +"select impuesto from categoria where codCategoria= @cod";
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
    public int getComision(string nombre)
    {
        SqlConnection conexion = new SqlConnection();
        string sql = "USE paqueteria;"
      //  + "declare @codSucursal int= (select codSucursal from Sucursal where nombre= '" + nombre + "';"
        + "select comision from sucursal where  nombre= '" + nombre + "';";
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
    public string getCliente(int casilla)
    {
        string sql = "USE paqueteria;"
        + "select casillaInternacional, nombre, apellido, nit, telefono, direccion, tarjeta from cliente where  casillaInternacional= '" + casilla + "';";
        SqlConnection sqlConn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
        DataSet dts = new DataSet();
        da.Fill(dts, "autor");
        DataTable dt = new DataTable();
        dt = dts.Tables["autor"];
        string palabra = "";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = palabra + "," + dr["nombre"].ToString();

        }
        return palabra;
        /*string palabra="";
        using (connection)
        {
            SqlCommand command = new SqlCommand(
             sql,
              connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {   while (reader.Read())
                {
                     palabra = reader.GetInt32(0)+","+reader.GetString(1)+","+ reader.GetString(2)+","+reader.GetInt32(3)
                     +","+reader.GetInt32(4)+","+reader.GetString(5)+","+reader.GetInt32(6);
                }
                reader.NextResult();
            }
            return palabra; */
        }
    [WebMethod]
    public void insertarImpuesto(string categoria,int impuesto) //retorna el nuevo impuesto
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        string sql = "SET identity_insert usuario off;"
        + "UPDATE categoria SET impuesto=" + impuesto + "where nombre='" + categoria + "';";
        
       
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
    }


    [WebMethod]
    public void insertarComision(string sucursal, int comision) //retorna el nuevo impuesto
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        string sql = "SET identity_insert usuario off;"
        + "UPDATE sucursal SET comision=" + comision + "where nombre='" + sucursal + "';";


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
    }
    }
