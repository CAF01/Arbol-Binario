using ClassBusinessLogic;
using ClassEntities;
using System;
using System.Windows.Forms;

namespace WebManejaArbolHardware
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Negocios Negocios;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                this.Negocios = new Negocios();
                Session["Negocios"] = Negocios;
            }
            else
            {
                this.Negocios = (Negocios)Session["Negocios"];
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TB1.Text) || !String.IsNullOrEmpty(TB2.Text) || !String.IsNullOrEmpty(TB3.Text) ||
                !String.IsNullOrEmpty(TB4.Text) || !String.IsNullOrEmpty(TB5.Text) || !String.IsNullOrEmpty(TB6.Text))
            {
                //guardarImgs

                this.Negocios.AgregarComponente(new Componente()
                {
                    Clave = Convert.ToInt32(TB1.Text),
                    Categoria = TB2.Text,
                    Marca = TB3.Text,
                    Modelo = TB4.Text,
                    Serie = TB5.Text,
                    Descripcion = TB6.Text
                });
                this.EnviaAlertas("¡Éxito!", "Componente agregado.", "success");
                TB1.Text = ""; TB2.Text = ""; TB3.Text = ""; TB4.Text = ""; TB5.Text = ""; TB6.Text = "";
            }
            else
            {
                this.EnviaAlertas("¡Error!", "Verifique los campos.", "error");
            }

        }

        public void EnviaAlertas(string titulo,string msg,string tipo)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), titulo, "registro('"+titulo+"','" + msg + "','"+tipo+"')", true);
        }

        public void GuardarImagenes()
        {
            if (FileUpload1.HasFile || FileUpload2.HasFile)
            {
                if (FileUpload1.HasFile)
                {

                }
                if (FileUpload2.HasFile)
                {

                }
            }
        }
    }
}