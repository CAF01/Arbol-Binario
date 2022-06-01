using ClassDataAccess;
using ClassEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();

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
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 9}), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 10 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 0 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = -1 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 12 }), nodo);
            arbol.InsertarNodo(new Nodo(new Componente() { Clave = 14 }), nodo);

            //Nodo encontrad = arbol.BuscarReferenciaAnteriorNodo(nodo, new Componente() { Clave = 3 });
            //Componente hola = new Componente() { Clave =89 };
            //Nodo eliminar = arbol.EliminarNodo(nodo, ref hola);
            //arbol.Transversa_inOrder(nodo);

            //string[] cadenas = arbol.imprimirComponentes();
            //foreach (var item in cadenas)
            //{
            //    Console.WriteLine(item);
            //}
            //Componente abc = arbol.BuscarComponente(nodo, -2);
            //string jd = abc.Clave.ToString();
            //arbol.Transversa_preOrder(nodo);
            //arbol.Transversa_inOrder(nodo);
            //arbol.Transversa_postOrder(nodo);



            Console.ReadKey();
        }
    }
}
