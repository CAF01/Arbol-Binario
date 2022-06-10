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
                Clave = 6,Modelo="Patito"
            }), null);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 2,Modelo="patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 8, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 1 , Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 4, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 3, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 5, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 7, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 11, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 9, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 10, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 0, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = -1, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 12, Modelo = "patito" }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 14, Modelo = "patito" }), nodo);

            //Nodo encontrad = arbol.BuscarReferenciaAnteriorNodo(nodo, new Componente() { Clave = 3 });
            //Componente hola = new Componente() { Clave = 8 };


            

            //Pen lap = new Pen(Color.CornflowerBlue, 2);
            //Pen lazo = new Pen(Color.Black, 2);
            //Brush brush = new SolidBrush(Color.Red);

            //int x=70, y = 70;
            //Componente[] cadenas = arbol.Transversa_inOrder(nodo, Transversa.InOrder);
            //foreach (var item in cadenas)
            //{
            //    papel.DrawRectangle(lap, new Rectangle(x, y, 100, 40));
            //    papel.DrawString(item.Clave.ToString(), new Font("Arial", 12), brush, x + 3, y + 1);
            //    papel.DrawString(item.Modelo.ToString(), new Font("Arial", 10), brush, x + 3, y + 20);

            //    if (item != cadenas[cadenas.Length-1])
            //        papel.DrawLine(lazo, x+100, y + 15, x + 120, y + 15);
            //    x += 120;
            //}


            //Graficador[] grafo = arbol.RecorrerArbol(nodo, false, 350, 80);
            //string a = "hola";

            //foreach (var item in grafo)
            //{
            //    papel.DrawRectangle(lap, new Rectangle(Convert.ToInt32(item.x2), Convert.ToInt32(item.y2), 45, 30));
            //    papel.DrawLine(lazo, item.x1, item.y1, item.x2, item.y2);
            //    papel.DrawString(item.componente.Clave.ToString(), new Font("Arial", 10), brush, item.x2, item.y2);
            //}

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
