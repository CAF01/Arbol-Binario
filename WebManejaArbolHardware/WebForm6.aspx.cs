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
    public partial class WebForm6 : System.Web.UI.Page
    {
        Negocios Negocios;
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(5000, 4500);

            Graphics g = Graphics.FromImage(bitmap);

            if (Session["Negocios"] != null)
            {
                this.Negocios = (Negocios)Session["Negocios"];
                this.ImprimirArbol(this.Negocios.ObtenerCoordenadas(2500,150), g, bitmap.Width, bitmap.Height);
                Response.ContentType = "image/jpeg";

                bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
                Response.End();
            }

        }

        public void ImprimirArbol(Graficador[] componentes, Graphics graphics, int x, int y)
        {
            graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, x, y));

            Pen lap = new Pen(Color.CornflowerBlue, 2);
            Pen lazo = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Red);
            Brush brush1 = new SolidBrush(Color.BlueViolet);

            foreach (var item in componentes)
            {
                graphics.DrawRectangle(lap, new Rectangle(Convert.ToInt32(item.x2), Convert.ToInt32(item.y2), 200, 100));
                graphics.DrawLine(lazo, item.x1, item.y1, item.x2, item.y2);
                graphics.DrawString(item.componente.Clave.ToString(), new Font("Arial", 25), brush, item.x2, item.y2);
                graphics.DrawString(String.Format("Modelo: {0}",item.componente.Modelo.ToString()), new Font("Arial", 20), brush1, item.x2, item.y2 + 30);
                graphics.DrawString(String.Format("Marca: {0}", item.componente.Marca.ToString()), new Font("Arial", 20), brush1, item.x2, item.y2 + 60);
            }
        }
    }
}