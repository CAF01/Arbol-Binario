using ClassDataAccess;
using ClassEntities;
using System;
using System.Text.Json;

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
            //Componente hola = new Componente() { Clave = 8 };

            string Json = JsonSerializer.Serialize<Arbol>(arbol);
            
            
            Arbol nuevo=JsonSerializer.Deserialize<Arbol>(Json);

            //Graficador[] grafo = arbol.RecorrerArbol(nodo, false,100,35);



            //string[] cadenas = arbol.Transversa_inOrder(nodo, Transversa.InOrder);
            //foreach (var item in cadenas)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("||||||||||||||||||||||||||");
            //cadenas = arbol.Transversa_preOrder(nodo, Transversa.PreOrder);
            //foreach (var item in cadenas)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("||||||||||||||||||||||||||");
            //cadenas = arbol.Transversa_postOrder(nodo, Transversa.PostOrder);
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
