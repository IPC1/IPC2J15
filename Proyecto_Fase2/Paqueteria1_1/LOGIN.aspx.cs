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
                    
                    this.Session["ID"] = ID;
                    this.Session["Name"] = usuario;
                    Server.Transfer("CPERFIL.aspx");
                }

            }
         else
         {
            ID = servicio.VerificarEmpleadp(usuario, contraseña, tipo);
            if (ID != 0)
            {
                this.Session["ID"] = ID;
                this.Session["Name"] = usuario;
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
                            
                            TextBox3.Text = (this.Session["ID"]).ToString();
                            Server.Transfer("APERFIL.aspx");
                        }
                        else
                        {
                            TextBox3.Text = "Usuario no encontrado como administrador";
                        }
                       
                    }
                    else if (tipo == "director")
                    {
                        string director =  servicio.getTipocodEmpleado(ID);
                        if (tipo == director)
                        {
                        
                        int asigSucursal= servicio.getAsigSucursalCodEmpleado(ID);
                        this.Session["Departamento"] = servicio.getDeptoAsigSucursal(asigSucursal);
                        Server.Transfer("DPERFIL.aspx");
                        }
                        else
                        {
                            TextBox3.Text = "Usuario no encontrado como director";
                        }
                        

                    }
                
            }
            else
            {
                TextBox3.Text = "Usuario no encontrado"+ID;
            }
         }
             
    }
    
}