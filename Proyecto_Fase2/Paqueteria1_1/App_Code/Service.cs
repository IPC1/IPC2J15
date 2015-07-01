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
        conexion.Close();
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
        conexion.Close();
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
        conexion.Close();
        return palabra;
    }


    [WebMethod]
    public void reservarCliente(string nombre, string apellido, int nit, int telefono, string direccion, int tarjeta, string usuario, int contraseña)
    {
       
        try
        {
            SqlConnection con = new SqlConnection(sqlConnectionString);
            con.Open();
            string consulta = "USE paqueteria;"
            + "SET identity_insert clienteAuto off;"
        + "INSERT INTO clienteAuto (nombre, apellido, nit, telefono, direccion, tarjeta, usuario, contraseña)"
        + "values ('" + nombre + "', '" + apellido + "'," + nit + ", " + telefono + ", '" + direccion + "', " + tarjeta + ", '" + usuario + "', "+contraseña+");";
            SqlDataAdapter adap = new SqlDataAdapter(consulta, con);
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception ex)
        {
        }
        
       
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
            con.Close();
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
            con.Close();
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
        conexion.Close();
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
        conexion.Close();
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
        sqlConn.Close();
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
        sqlConn.Close();
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
        sqlConn.Close();
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
        sqlConn.Close();
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
        sqlConn.Close();
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
        sqlConn.Close();
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
        sqlConn.Close();
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
        conexion.Close();
        return palabra;
    }

    [WebMethod]
    public int getComision(string nombre)
    {
        SqlConnection conexion = new SqlConnection();
        string sql = "USE paqueteria;"
      
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
        conexion.Close();
        return palabra;
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
        conexion.Close();
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
        conexion.Close();
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
        sqlConn.Close();
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
        con.Close();
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
        sqlConn.Close();
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
        conexion.Close();
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
        conexion.Close();
        return palabra;
    }


    [WebMethod]
    public DataSet cargarPaquetecasillaInter(int casilla)
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        SqlCommand comando = new SqlCommand();
        conexion.ConnectionString = sqlConnectionString;
        comando.Connection = conexion;
        conexion.Open();
        string consulta = "Select *from Paquete  WHERE casillaInternacional='" + casilla + "'";
        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        daClientes.Fill(dsClientes, "DetallePaquete");
        conexion.Close();
        return dsClientes;
    }

    [WebMethod]
    public void cargarEstadoPaquete(string estado, int paquete)
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        SqlCommand comando = new SqlCommand();
        conexion.ConnectionString = sqlConnectionString;
        comando.Connection = conexion;
        conexion.Open();
        string consulta = "UPDATE paquete SET estado= '"+estado+"' where codPaquete="+paquete+";";
        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        conexion.Close();
        daClientes.Fill(dsClientes, "DetallePaquete");
       
    }

    [WebMethod]
    public DataSet cargarCLIENTEcasilla(int casilla)
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        SqlCommand comando = new SqlCommand();
        conexion.ConnectionString = sqlConnectionString;
        comando.Connection = conexion;
        conexion.Open();
        string consulta = "SELECT * FROM cliente where casillaInternacional="+casilla;
        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        daClientes.Fill(dsClientes, "DetallePaquete");
        conexion.Close();
        return dsClientes;
    }

    [WebMethod]
    public DataSet cargarCLIENTEAUTOcasilla()
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        SqlCommand comando = new SqlCommand();
        conexion.ConnectionString = sqlConnectionString;
        comando.Connection = conexion;
        conexion.Open();
        string consulta = "SELECT * FROM clienteAuto";
        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        daClientes.Fill(dsClientes, "DetallePaquete");
        conexion.Close();
        return dsClientes;
    }

    [WebMethod]
    public void autorizarCliente(int codigoCliente, int casilla)
    {
        SqlConnection conexion = new SqlConnection(sqlConnectionString);
        SqlCommand comando = new SqlCommand();
        conexion.ConnectionString = sqlConnectionString;
        comando.Connection = conexion;
        conexion.Open();
        string consulta = "Use paqueteria;"
        +"SET identity_insert cliente on;"
        +"declare @casilla int ="+casilla+";"
        +"declare @nombre varchar (25)= (select nombre from clienteAuto where codCliente= "+codigoCliente+");"
        + "declare @apellido varchar (25)= (select apellido from clienteAuto where codCliente= " + codigoCliente + ");"
        + "declare @nit int= (select nit from clienteAuto where codCliente= " + codigoCliente + ");"
        + "declare @telefono int= (select telefono from clienteAuto where codCliente= " + codigoCliente + ");"
        + "declare @direccion varchar (25)= (select direccion from clienteAuto where codCliente= " + codigoCliente + ");"
        + "declare @tarjeta int= (select tarjeta from clienteAuto where codCliente= " + codigoCliente + ");"
        + "declare @usuario varchar (25)= (select usuario from clienteAuto where codCliente= " + codigoCliente + ");"
        + "declare @contraseña int= (select contraseña from clienteAuto where codCliente= " + codigoCliente + ");"
        + "INSERT INTO usuario (nombre, contraseña, tipo)"
        +"values (@usuario, @contraseña, 'cliente');"
        +"declare @codUsuario int= (select codUsuario from usuario where nombre= @usuario and contraseña=@contraseña);"
        + "INSERT INTO cliente (casillaInternacional, nombre, apellido, nit, telefono, direccion, tarjeta,  codUsuario)"
        +"values (@casilla, @nombre, @apellido, @nit, @telefono, @direccion, @tarjeta, @codUsuario);"
        + "delete  from clienteAuto where codCliente="+codigoCliente+";";
        SqlDataAdapter daClientes = new SqlDataAdapter(consulta, conexion);
        DataSet dsClientes = new DataSet();
        daClientes.Fill(dsClientes, "DetallePaquete");
        conexion.Close();
    }

    }
