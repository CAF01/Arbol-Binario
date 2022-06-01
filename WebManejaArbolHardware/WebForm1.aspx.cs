using ClassBusinessLogic;
using ClassEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
            if(!String.IsNullOrEmpty(TB1.Text) || !String.IsNullOrEmpty(TB2.Text) || !String.IsNullOrEmpty(TB3.Text) ||
                !String.IsNullOrEmpty(TB4.Text) || !String.IsNullOrEmpty(TB5.Text) || !String.IsNullOrEmpty(TB6.Text))
            {
                this.Negocios.AgregarComponente(new Componente()
                {
                    Clave = Convert.ToInt32(TB1.Text),
                    Categoria = TB2.Text,
                    Marca = TB3.Text,
                    Modelo = TB4.Text,
                    Serie = TB5.Text,
                    Descripcion = TB6.Text
                });
                MessageBox.Show("Éxito: Componente agregado");
                TB1.Text = ""; TB2.Text = ""; TB3.Text = ""; TB4.Text = ""; TB5.Text = ""; TB6.Text = "";
            }
            else
            {
                MessageBox.Show("Error: Campos incompletos");
            }

            
        }
    }
}