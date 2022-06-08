using ClassBusinessLogic;
using ClassEntities;
using System;
using System.IO;
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
            if (!String.IsNullOrEmpty(TB1.Text) || !String.IsNullOrEmpty(TB2.Text) || !String.IsNullOrEmpty(TB3.Text) ||
                !String.IsNullOrEmpty(TB4.Text) || !String.IsNullOrEmpty(TB5.Text) || !String.IsNullOrEmpty(TB6.Text))
            {
                string path1 = "";
                string path2 = "";
                if(this.GuardarImagenes(ref path1, ref path2))
                {
                    this.Negocios.AgregarComponente(new Componente()
                    {
                        Clave = Convert.ToInt32(TB1.Text),
                        Categoria = TB2.Text,
                        Marca = TB3.Text,
                        Modelo = TB4.Text,
                        Serie = TB5.Text,
                        Descripcion = TB6.Text,
                        Imagen_uno=path1,
                        Imagen_dos=path2
                    });
                    this.EnviaAlertas("¡Éxito!", "Componente agregado.", "success");
                    TB1.Text = ""; TB2.Text = ""; TB3.Text = ""; TB4.Text = ""; TB5.Text = ""; TB6.Text = "";
                }
            }
            else
            {
                this.EnviaAlertas("¡Error!", "Verifique los campos.", "error");
            }

        }

        public void EnviaAlertas(string titulo,string msg,string tipo)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), titulo, String.Format("registro('{0}','{1}','{2}')", titulo, msg, tipo), true);
            //Page.ClientScript.RegisterStartupScript(this.GetType(), titulo, "registro('"+titulo+"','" + msg + "','"+tipo+"')", true);
        }

        //            Image1.ImageUrl = "~/" + imgPath;

        public bool GuardarImagenes(ref string path1, ref string path2)
        {
            string extension;
            string imgName;
            string imgPath = "img/components/";
            bool exito = true;

            int imgSize;

            if (FileUpload1.HasFile || FileUpload2.HasFile)
            {
                if (FileUpload1.HasFile)
                {
                    extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
                    if (extension.ToLower() == ".jpg" || extension.ToLower()==".png")
                    {
                        imgName=FileUpload1.FileName;
                        imgSize = FileUpload1.PostedFile.ContentLength;
                        if(imgSize>102400)
                        {
                            exito = false;
                            this.EnviaAlertas("¡Error!", "La primera imagen es demasiado grande", "error");
                        }
                        else
                        {
                            path1 = imgPath + imgName;
                            FileUpload1.SaveAs(Server.MapPath(path1));
                        }
                    }
                    else
                    {
                        exito = false;
                        this.EnviaAlertas("¡Info!", "Solo se aceptan extensiones de imagen .jpg / .png", "info");
                    }
                        
                }
                if (FileUpload2.HasFile)
                {
                    extension = Path.GetExtension(FileUpload2.PostedFile.FileName);
                    if (extension.ToLower() == ".jpg" || extension.ToLower() == ".png")
                    {
                        imgName = FileUpload2.FileName;
                        imgSize = FileUpload2.PostedFile.ContentLength;
                        if (imgSize > 102400)
                        {
                            exito = false;
                            this.EnviaAlertas("¡Error!", "La segunda imagen es demasiado grande", "error");
                        }
                        else
                        {
                            path2 = imgPath + imgName;
                            FileUpload2.SaveAs(Server.MapPath(path2));
                        }
                    }
                    else
                    {
                        exito = false;
                        this.EnviaAlertas("¡Info!", "Solo se aceptan extensiones de imagen .jpg / .png", "info");
                    }
                        
                }
            }
            return exito;
        }
    }
}