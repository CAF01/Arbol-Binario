using ClassBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebManejaArbolHardware
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Negocios Negocios;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Negocios"]!=null)
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

            if(this.Negocios.ContieneValores())
            {
                this.Image1.ImageUrl = "Recorridos.aspx";
                this.Image2.ImageUrl = "Recorridos1.aspx";
                this.Image3.ImageUrl = "Recorridos2.aspx";
            }
            else
            {
                this.EnviaAlertas("Información", "Aún no existen datos de componentes registrados", "info");
            }
        }

        public void EnviaAlertas(string titulo, string msg, string tipo)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), titulo, String.Format("registro('{0}','{1}','{2}')", titulo, msg, tipo), true);
        }




    }
}