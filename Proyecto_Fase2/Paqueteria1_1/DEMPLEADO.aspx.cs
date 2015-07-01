using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DEMPLEADO : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String savePath = @"C:\Users\Pau\Documents\GitHub\IPC2J15\Proyecto_Fase2\CSV\";
        if (FileUpload1.HasFile)
        {
            String fileName = FileUpload1.FileName;
            savePath += fileName;
            FileUpload1.SaveAs(savePath);
            parseCSV2(savePath);
            GridView1.DataBind();
            Response.Redirect("DEMPLEADO.aspx");
        }
    }
    public List<string[]> parseCSV2(string path)
    {
        List<string[]> parsedData = new List<string[]>();

        using (StreamReader readFile = new StreamReader(path))
        {
            string line;
            string[] row;

            while ((line = readFile.ReadLine()) != null)
            {
                row = line.Split(',');
                parsedData.Add(row);
                localhost.ServiceSoapClient servicio = new localhost.ServiceSoapClient();
                servicio.insertarEmpleado(row[1].ToString(),row[2].ToString(),Convert.ToInt32(row[3]),row[4].ToString(),row[5].ToString());
             }
            
        }
        return parsedData;
    }
    
}