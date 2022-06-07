using ClassDataAccess;
using ClassEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGraficaArbol
{
    public partial class Form1 : Form
    {
        Arbol arbol = new Arbol();
        Graphics papel;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            papel = pictureBox1.CreateGraphics();

            Nodo nodo = arbol.InsertarNodo(new Nodo(new Componente()
            {
                Clave = 6
            }), null);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 2 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 8 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 1 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 4 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 3 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 5 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 7 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 11 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 9 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 10 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 0 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = -1 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 12 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 14 }), nodo);

            Nodo encontrad = arbol.BuscarReferenciaAnteriorNodo(nodo, new Componente() { Clave = 3 });
            Componente hola = new Componente() { Clave = 8 };


            Graficador[] grafo = arbol.RecorrerArbol(nodo, false, 350, 80);
            string a = "hola";

            Pen lap = new Pen(Color.CornflowerBlue, 2);
            Pen lazo = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.Red);

            foreach (var item in grafo)
            {
                papel.DrawRectangle(lap, new Rectangle(Convert.ToInt32(item.x2), Convert.ToInt32(item.y2), 45, 30));
                papel.DrawLine(lazo, item.x1, item.y1, item.x2, item.y2);
                papel.DrawString(item.componente.Clave.ToString(), new Font("Arial", 10), brush, item.x2, item.y2);
            }

        }
    }
}
