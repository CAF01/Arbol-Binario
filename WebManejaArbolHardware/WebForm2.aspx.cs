using ClassBusinessLogic;
using System;
using System.IO;
using System.Text.Json;

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

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (this.Negocios.ContieneValores() && !string.IsNullOrEmpty(TB1.Text))
            {
                string ArchivoNombre = TB1.Text;
                if (ArchivoNombre.Contains(".") || ArchivoNombre.Contains(","))
                    this.EnviaAlertas("¡Error!", "El nombre del archivo no debe contener símbolos","error");
                else
                {
                    string datosJson = JsonSerializer.Serialize(this.Negocios.DevuelveRaizOriginal());
                    File.WriteAllText(Server.MapPath("~/Backups/" + ArchivoNombre + ".json"), datosJson);

                    this.EnviaAlertas("¡Éxito!", "Los datos se han guardado correctamente", "success");
                }
            }
            else
                this.EnviaAlertas("¡Error!", "No hay datos disponibles para guardar", "error");
        }

        public void EnviaAlertas(string titulo, string msg, string tipo)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), titulo, String.Format("registro('{0}','{1}','{2}')", titulo, msg, tipo), true);
        }
    }
}