using ClassBusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI.WebControls;

namespace WebManejaArbolHardware
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Negocios Negocios;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Negocios"] != null)
                {
                    this.Negocios = (Negocios)Session["Negocios"];
                }
                else
                {
                    this.Negocios = new Negocios();
                    Session["Negocios"] = Negocios;
                }
            }
            else
            {
                this.Negocios = (Negocios)Session["Negocios"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)//Restaurar Datos con Archivo
        {
            if(DropDownList1.SelectedIndex>0)
            {
                string JsonFile = File.ReadAllText(Server.MapPath("~/Backups/" + DropDownList1.SelectedItem.Value));
                if (this.Negocios.RestaurarInformacion(JsonFile))
                    this.EnviaAlertas("¡Completado!", "Se ha restaurado la información", "success");
                else
                    this.EnviaAlertas("¡Error!", "La información no se recupero", "error");
            }
            else
            {
                this.EnviaAlertas("¡Error!", "Debe seleccionar un archivo de restauración", "error");
            }
        }

        protected void LocalizarArchivos()
        {
            string[] filesLoc = Directory.GetFiles(Server.MapPath("~/Backups/"));
            List<ListItem> files = new List<ListItem>();
            foreach (string file in filesLoc)
            {
                files.Add(new ListItem(Path.GetFileName(file)));
            }
            DropDownList1.Items.Clear();
            if (files.Count>0)
            {
                DropDownList1.Items.Add("Seleccionar archivo");
                DropDownList1.Visible = true;
                foreach (var item in files)
                {
                    DropDownList1.Items.Add(item.Text);
                }
            }
            else
            {
                DropDownList1.Visible = false;
                this.EnviaAlertas("Oops!", "No se encontaron archivos de restauración", "info");
            }
            
        }



        protected void Button2_Click(object sender, EventArgs e)//Guardar un archivo de datos
        {
            if (this.Negocios.ContieneValores() && !string.IsNullOrEmpty(TB1.Text))
            {
                string ArchivoNombre = TB1.Text;
                if (ArchivoNombre.Contains(".") || ArchivoNombre.Contains(","))
                    this.EnviaAlertas("¡Error!", "El nombre del archivo no debe contener símbolos", "error");
                else
                {
                    string JsonFile = this.Negocios.RespaldaInformacion(ArchivoNombre);
                    if (!String.IsNullOrEmpty(JsonFile))
                    {
                        File.WriteAllText(Server.MapPath("~/Backups/" + ArchivoNombre + ".json"), JsonFile);
                        this.EnviaAlertas("¡Éxito!", "Los datos se han guardado correctamente", "success");
                    }
                    else
                    {
                        this.EnviaAlertas("¡Error!", "Algo fallo al momento de respaldar la información", "error");
                    }
                    TB1.Text = "";
                }
            }
            else
                this.EnviaAlertas("¡Error!", "No hay datos disponibles para guardar", "error");
        }

        public void EnviaAlertas(string titulo, string msg, string tipo)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), titulo, String.Format("registro('{0}','{1}','{2}')", titulo, msg, tipo), true);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.LocalizarArchivos();
        }
    }
}