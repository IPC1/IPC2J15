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
    public int insertarEmpleado(string apellido, string nombre, int sueldo, string sucursal, string departamento)//insertar empleado en csv, devuelve el codigo de empleado
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        string sql = "USE paqueteria;"
        + "SET identity_insert empleado off;"
        +"declare @codDepto int = (select codDepto from departamento where nombre= '"+departamento+"');"
        + "declare @codSucursal int = (select codSucursal from sucursal where nombre= '" + sucursal + "');"
        + "declare @codAsigSucursal int = (select codAsigSucursal  FROM asigSucursal where codDepto=@codDepto and  codSucursal = @codSucursal)"
        + "declare @nombre varchar(25) = '"+nombre+"';"
        + "declare @contraseña int = (ABS(CAST(NEWID() as binary(6)) % 100000) + 1);"
        + "INSERT INTO usuario (nombre, contraseña, tipo)"
        + "values (@nombre, @contraseña, 'empleado');"
        + "declare @usuario int =(SELECT codUsuario from usuario where  nombre= @nombre and contraseña =@contraseña);"
        + "INSERT INTO empleado (apellido, nombre, sueldo, codUsuario, codAsigSucursal)"
        + "values ('" + apellido + "', '" + nombre + "'," + sueldo + ", @usuario, @codAsigSucursal);"
        + "select codEmpleado from empleado where codUsuario= @usuario;";
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

        return Convert.ToInt32(palabra);
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
    public void reservarCliente(string nombre, string apellido, int nit, int telefono, string direccion, int tarjeta, string usuario, int contraseña)
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        string sql = "USE paqueteria;"
        + ""
        + "INSERT INTO clientesAuto (nombre, apellido, nit, telefono, direccion, tarjeta, usuario, coontraseña)"
        + "values ('" + nombre + "', '" + apellido + "'," + nit + ", " + telefono + ", '" + direccion + "', " + tarjeta + ", '" + usuario + "', "+contraseña+");";
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
    }
    [WebMethod]
    public string insertarSucursal(string nombre, string pais, string direccion, int noEmpleados, int telefono, int comision,  string sede)
    {
        string vel = "";
        try
        {
            SqlConnection con = new SqlConnection(sqlConnectionString);
            con.Open();
            string consulta = "USE paqueteria;"
        +"SET identity_insert sucursal off;"
            +"declare @sede int =(select codSede from sede where nombre='"+sede+"');"
            +"Insert into sucursal (nombre, pais,direccion, noEmpleados, telefono,comision,codSede)"
            +"Values ('" + nombre + "','" + pais + "','" + direccion + "','" + noEmpleados + "','" + telefono + "','" + comision + "', @sede)";
            SqlDataAdapter adap = new SqlDataAdapter(consulta, con);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            vel = "no se pudo" + ex;
        }
        return vel;
    }

    [WebMethod]
    public string insertarCategoria(string nombre, int impuesto)
    {
        string vel = "";
        try
        {
           SqlConnection con = new SqlConnection(sqlConnectionString);
            con.Open();
            string consulta = "Insert into categoria (nombre, impuesto) Values ('" + nombre + "','" + impuesto + "')";
            SqlDataAdapter adap = new SqlDataAdapter(consulta, con);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            vel = "no se pudo" + ex;
        }
        return vel;
    }


    
    [WebMethod]
    public int VerificarCliente(string nombre, string contraseña, string tipo)//devuelve la casilla internacional del cliente
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
    public int VerificarEmpleadp(string nombre, string contraseña, string tipo)//devuelve el codigo del empleado
    {
        SqlConnection conexion = new SqlConnection();
        string sql = "USE paqueteria;"
        + "declare @usuario int =(select codUsuario from usuario where nombre='" + nombre + "' and contraseña='" + contraseña + "' and tipo='" + tipo + "');"
        + "select codEmpleado from empleado where codUsuario= @usuario";
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
    public string getDeptoAsigSucursal(int codAsigSucursal) //devuelve el nombre del departamento de una asigSucursal
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "declare @depto int= (select codDepto from asigSucursal where codAsigSucursal= "+codAsigSucursal+");"
        +"select nombre from  departamento where codDepto=@depto";
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
        DataSet dts = new DataSet();
        da.Fill(dts, "autor");
        DataTable dt = new DataTable();
        dt = dts.Tables["autor"];
        string palabra = "";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = dr["nombre"].ToString();

        }
        return palabra;
    }

    [WebMethod]
    public int getcodDeptoNombre(string depto) //devuelve el nombre del departamento de una asigSucursal
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "select codDepto from  departamento where nombre='"+depto+"'";
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
        DataSet dts = new DataSet();
        da.Fill(dts, "departamento");
        DataTable dt = new DataTable();
        dt = dts.Tables["departamento"];
        string palabra = "";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = dr["codDepto"].ToString();

        }
        return Convert.ToInt32(palabra);
    }

    [WebMethod]
    public string getTipocodEmpleado(int empleado) //devuelve el nombre del departamento de una asigSucursal
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "select tipo from  empleado where codEmpleado='" + empleado + "'";
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
        DataSet dts = new DataSet();
        da.Fill(dts, "empleado");
        DataTable dt = new DataTable();
        dt = dts.Tables["empleado"];
        string palabra = "";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = dr["tipo"].ToString();

        }
        return palabra;
    }
    [WebMethod]
    public int getAsigSucursalCodEmpleado(int empleado) //devuelve el codAsigSucursal a partir de un codigo de empleado
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "select codAsigSucursal from empleado where codEmpleado= " + empleado + ";";
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
        DataSet dts = new DataSet();
        da.Fill(dts, "empleado");
        DataTable dt = new DataTable();
        dt = dts.Tables["empleado"];
        string palabra = "";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = dr["codAsigSucursal"].ToString();

        }
        return Convert.ToInt32(palabra);
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
    public string getSede()
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "select nombre from  sede";
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
    public List<string> getCliente(int casilla)
    {
            List<string> datos = new List<string>();
            SqlCommand comando = new SqlCommand();
        string sql = "USE paqueteria;"
        + "select casillaInternacional, nombre, apellido, nit, telefono, direccion, tarjeta from cliente where  casillaInternacional= '" + casilla + "';";
            comando.CommandText = sql;
            SqlConnection conexion = new SqlConnection(sqlConnectionString);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    datos.Add(Convert.ToString(lector.GetInt32(0)));
                    datos.Add(lector.GetString(1));
                    datos.Add(lector.GetString(2));
                    datos.Add(Convert.ToString(lector.GetInt32(2)));
                    datos.Add(Convert.ToString(lector.GetInt32(3)));
                    datos.Add(lector.GetString(4));
                    datos.Add(Convert.ToString(lector.GetInt32(5)));
                }
            }
            return datos;
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


    [WebMethod]
    public string getcodPaquetes(int casilla)//paquetes de un cliente en un string separado por comas
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "select codPaquete from  paquete where casillaInternacional ='"+casilla+"';";
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
        DataSet dts = new DataSet();
        da.Fill(dts, "paquete");
        DataTable dt = new DataTable();
        dt = dts.Tables["paquete"];
        string palabra="";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = palabra + "," + dr["codPaquete"].ToString();

        }
        return palabra;
    }

    [WebMethod]
    public string getcodLote(int paquete)// codigo de lotes en los que a estado un paquete en un string separado por comas
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "select codLote from  asigLote where codPaquete ='" + paquete + "';";
        SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
        DataSet dts = new DataSet();
        da.Fill(dts, "asigLote");
        DataTable dt = new DataTable();
        dt = dts.Tables["asigLote"];
        string palabra = "";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = palabra + "," + dr["codLote"].ToString();

        }
        return palabra;
    }

    [WebMethod]
    public string getcodEstadoLote(int lote)//codigo de estado de un lote por fecha en un string separados por comas
    {
        SqlConnection con = new SqlConnection(sqlConnectionString);
        string sql = "select codEstado from  historial where codLote ='" + lote + "'"
            +"order by fecha;";
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet dts = new DataSet();
        da.Fill(dts, "historial");
        DataTable dt = new DataTable();
        dt = dts.Tables["historial"];
        string palabra = "";
        foreach (DataRow dr in dt.Rows)
        {
            palabra = palabra + "," + dr["codEstado"].ToString();

        }
        return palabra;
    }


    [WebMethod]
    public string getcodSucursalAsig(int lote)//cod de la asignacion del estado por fecha en un string separado por comas
    {
        SqlConnection sqlConn = new SqlConnection(sqlConnectionString);
        string sql = "select codSucursal from  historial where codLote ='" + lote + "'"
            + "order by fecha;";
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
    public string getEstadoHistorial(int historial)// estado de un codEstado 
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        string sql = "select estado from  historial where codEstado ='" + historial + "'";
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
    public string getSucursalEstado(int codSucursal)//nombre de la sucursal segun su codigo
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        string sql = "select nombre from  sucursal where codSucursal ='" + codSucursal + "'";
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
