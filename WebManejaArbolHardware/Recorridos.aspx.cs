using ClassBusinessLogic;
using ClassEntities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebManejaArbolHardware
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        Negocios Negocios;
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(2200, 110);

            Graphics g = Graphics.FromImage(bitmap);
            
            if (Session["Negocios"] != null)
            {
                this.Negocios = (Negocios)Session["Negocios"];
                this.MostrarRecorrido(this.Negocios.MostrarComponentesPorOrden(Transversa.PreOrder), g,bitmap.Width,bitmap.Height);
                Response.ContentType = "image/jpeg";

                bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
                Response.End();
            }

        }

        public void MostrarRecorrido(Componente[] listaComponentes,Graphics graphics,int x,int y)
        {
            graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, x, y));
            if(listaComponentes!=null)
            {
                Pen lap = new Pen(Color.CornflowerBlue, 2);
                Pen lazo = new Pen(Color.Black, 1);
                Brush brush = new SolidBrush(Color.Red);

                x = 35; 
                y = 50;
                foreach (var item in listaComponentes)
                {
                    graphics.DrawRectangle(lap, new Rectangle(x, y, 100, 40));
                    graphics.DrawString(item.Clave.ToString(), new Font("Arial", 12), brush, x + 3, y + 1);
                    graphics.DrawString(item.Modelo.ToString(), new Font("Arial", 10), brush, x + 3, y + 20);

                    if (item != listaComponentes[listaComponentes.Length - 1])
                        graphics.DrawLine(lazo, x + 100, y + 15, x + 120, y + 15);
                    x += 120;
                }
            }
            
        }
    }
}