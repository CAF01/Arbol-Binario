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
                Clave = 2
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

            Console.ReadKey();
        }
    }
}
