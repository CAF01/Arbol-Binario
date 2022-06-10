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
    public partial class WebForm4 : System.Web.UI.Page
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

        public void EnviaAlertas(string titulo, string msg, string tipo)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), titulo, String.Format("registro('{0}','{1}','{2}')", titulo, msg, tipo), true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string clave = TextBox1.Text;
            if(!String.IsNullOrEmpty(clave))
            {
                if (int.TryParse(clave, out int num))
                {
                    Componente componenteEncontrado = this.Negocios.BuscarComponentePorClave(num);
                    if (componenteEncontrado != null)
                    {
                        if (componenteEncontrado.Imagen_uno != "" || componenteEncontrado.Imagen_dos != "")
                        {
                            _ = componenteEncontrado.Imagen_uno != "" ? Image1.ImageUrl = "~/" + componenteEncontrado.Imagen_uno : Image1.ImageUrl = "";
                            _ = componenteEncontrado.Imagen_dos != "" ? Image2.ImageUrl = "~/" + componenteEncontrado.Imagen_dos : Image2.ImageUrl = "";
                        }
                        TBClave.Text = clave;
                        TBMarca.Text = componenteEncontrado.Marca;
                        TBDesc.Text = componenteEncontrado.Descripcion;
                        TBModelo.Text = componenteEncontrado.Modelo;
                        TBSerie.Text = componenteEncontrado.Serie;
                        TBCategoria.Text = componenteEncontrado.Categoria;
                    }
                    else
                    {
                        this.EnviaAlertas("Oops!", "No se encontró ningún componente con la clave " + clave, "info");

                        TBClave.Text = ""; TBMarca.Text = ""; TBDesc.Text = ""; TBModelo.Text = ""; TBSerie.Text = ""; TBCategoria.Text = "";
                        Image1.ImageUrl = "";
                        Image2.ImageUrl = "";
                    }
                }
                else
                    this.EnviaAlertas("Error", "Verifica que la clave sea valida, *solo se aceptan valores númericos*", "error");
                this.TextBox1.Text = "";
            }
            else
            {
                this.EnviaAlertas("¡Error!", "Ingresa la clave del componente", "error");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string clave = TextBox2.Text;
            if (!String.IsNullOrEmpty(clave))
            {
                if (int.TryParse(clave, out int num))
                {
                    if (this.Negocios.EliminarComponente(new Componente() { Clave = num }))
                        this.EnviaAlertas("Eliminado!", String.Format("El componente con clave: {0} se eliminó", num), "success");
                    else
                        this.EnviaAlertas("Oops!", "No se encontró ningún componente con la clave " + clave, "info");
                }
                else
                    this.EnviaAlertas("Error", "Verifica que la clave sea valida, *solo se aceptan valores númericos*", "error");
                this.TextBox2.Text = "";
            }
            else
            {
                this.EnviaAlertas("¡Error!", "Ingresa la clave del componente", "error");
            }
        }
    }
}