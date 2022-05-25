using ClassEntities;

namespace ClassDataAccess
{
    public class Arbol
    {
        public Nodo Inicio { get; set; }
        public Nodo Referencia { get; set; }

        public Arbol()
        {
            this.Inicio = null;
        }

        public Nodo InsertarNodo(Nodo nuevoNodo, Nodo nodo)
        {
            Nodo temp;
            if(nodo==null)
            {
                return temp = nuevoNodo;
            }

            if(nuevoNodo.id < nodo.id)
                nodo.hijoIzquierdo = InsertarNodo(nuevoNodo, nodo.hijoIzquierdo);
            if (nuevoNodo.id > nodo.id)
                nodo.hijoDerecho = InsertarNodo(nuevoNodo, nodo.hijoDerecho);

            return nodo;

        }
    }
}
