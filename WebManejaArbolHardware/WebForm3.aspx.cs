using ClassBusinessLogic;
using ClassEntities;
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
                this.Label1.Text = this.ObtenerRecorrido(Transversa.PreOrder);
                this.Label2.Text = this.ObtenerRecorrido(Transversa.InOrder);
                this.Label3.Text = this.ObtenerRecorrido(Transversa.PostOrder);
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

        public string ObtenerRecorrido(Transversa transversa)
        {
            string cad = "Recorrido: ";
            Componente[] componentes=this.Negocios.MostrarComponentesPorOrden(transversa);
            foreach (var item in componentes)
            {
                if (item.Clave == componentes[componentes.Length-1].Clave)
                    cad += String.Format("[{0}]", item.Clave);
                else
                    cad += String.Format("[{0}] , ", item.Clave);
            }
            return cad;
        }





    }
}