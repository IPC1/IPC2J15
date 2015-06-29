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
    protected void loguear_Click(object sender, EventArgs e)
    {
        string usuario = TextBox1.Text;
        string contraseña = TextBox2.Text;
        string tipo = RadioButtonList1.SelectedItem.Value;
        int ID;
         if (tipo == "cliente")
            {
                ID = servicio.VerificarCliente(usuario, contraseña, tipo);
                if (ID != 0)
                {
                    Server.Transfer("CPAQUETES.aspx");
                    this.Session["ID"] = ID;
                    this.Session["Name"] = usuario;
                }

            }
         else
         {
            ID = servicio.VerificarEmpleadp(usuario, contraseña, tipo);
            if (ID != 0)
            {        
                if (tipo == "empleado")
                    {
                        int asigSucursal = servicio.getAsigSucursalCodEmpleado(ID);
                        this.Session["Departamento"] = servicio.getDeptoAsigSucursal(asigSucursal);
                        string departamento= (string)(this.Session["Departamento"]);
                        if(departamento=="Registro"){
                            Server.Transfer("EREGISTRO.aspx");
                        }else if (departamento=="Servicio al Cliente"){
                            Server.Transfer("ESERVICIO.aspx");
                        }else if (departamento=="Bodega"){
                            Server.Transfer("EBODEGA.aspx");
                        }
                        
                    }
                    else if (tipo == "administrador")
                    {
                        string admin = servicio.getTipocodEmpleado(ID);
                        if (tipo == admin)
                        {
                            Server.Transfer("APERFIL.aspx");
                            ID = Convert.ToInt32(servicio.VerificarEmpleadp(usuario, contraseña, tipo));
                        }
                        else
                        {
                            TextBox3.Text = "Usuario no encontrado como administrador"+admin+ID;
                        }
                       
                    }
                    else if (tipo == "director")
                    {
                        string director =  servicio.getTipocodEmpleado(ID);
                        if (tipo == director)
                        {
                        Server.Transfer("DIRECTOR.aspx");
                        int asigSucursal= servicio.getAsigSucursalCodEmpleado(ID);
                        this.Session["Departamento"] = servicio.getDeptoAsigSucursal(asigSucursal);
                        }
                        else
                        {
                            TextBox3.Text = "Usuario no encontrado como director" + director + ID;
                        }
                        

                    }
                this.Session["ID"] = ID;
                this.Session["Name"] = usuario;
            }
            else
            {
                TextBox3.Text = "Usuario no encontrado"+ID;
            }
         }
             
    }
    
}