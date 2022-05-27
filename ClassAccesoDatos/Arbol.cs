using ClassEntities;

namespace ClassDataAccess
{
    public class Arbol
    {
        public Nodo Inicio { get; set; }

        //public Nodo Referencia { get; set; }

        private int contNodos=0;
        private int recorrer = 0;

        private Componente[] componentesPreOrder;
        private Componente[] componentesInOrder;
        private Componente[] componentesPostOrder;

        public Arbol()
        {
            this.Inicio = null;
        }

        public Nodo InsertarNodo(Nodo nuevoNodo, Nodo nodo)
        {
            Nodo temp;
            if(nodo==null)
            {
                contNodos++;
                return temp = nuevoNodo;
            }

            if(nuevoNodo.id < nodo.id)
                nodo.hijoIzquierdo = InsertarNodo(nuevoNodo, nodo.hijoIzquierdo);
            if (nuevoNodo.id > nodo.id)
                nodo.hijoDerecho = InsertarNodo(nuevoNodo, nodo.hijoDerecho);
            return nodo;

        }

        public void Transversa_preOrder(Nodo raiz)
        {
            if (recorrer == 0)
                componentesPreOrder = new Componente[contNodos];
            
            if (contNodos>0 && recorrer!=contNodos)
            {
                componentesPreOrder[recorrer] = raiz.componente;

                recorrer++;

                if (raiz.hijoIzquierdo!=null)
                {
                    Transversa_preOrder(raiz.hijoIzquierdo);
                }

                if(raiz.hijoDerecho!=null)
                {
                    Transversa_preOrder(raiz.hijoDerecho);
                }
                if(recorrer==contNodos)
                {
                    recorrer = 0;
                }
            }
        }

        public void Transversa_inOrder(Nodo raiz)
        {
            if (recorrer == 0)
                componentesInOrder = new Componente[contNodos];

            if (contNodos > 0 && recorrer != contNodos)
            {
                
                if (raiz.hijoIzquierdo != null)
                {
                    Transversa_inOrder(raiz.hijoIzquierdo);
                }

                componentesInOrder[recorrer] = raiz.componente;
                recorrer++;

                if (raiz.hijoDerecho != null)
                {
                    Transversa_inOrder(raiz.hijoDerecho);
                }
                if (recorrer == contNodos)
                {
                    recorrer = 0;
                }
            }

        }

        public void Transversa_postOrder(Nodo raiz)
        {
            if (recorrer == 0)
                componentesPostOrder = new Componente[contNodos];

            if (contNodos > 0 && recorrer != contNodos)
            {

                if (raiz.hijoIzquierdo != null)
                {
                    Transversa_postOrder(raiz.hijoIzquierdo);
                }

                if (raiz.hijoDerecho != null)
                {
                    Transversa_postOrder(raiz.hijoDerecho);
                }

                componentesPostOrder[recorrer] = raiz.componente;
                recorrer++;

                if (recorrer == contNodos)
                {
                    recorrer = 0;
                }
            }

        }

        public Componente BuscarNodo(Nodo raiz,int clave)
        {
            Nodo montado;
            Componente encontrado=null;
            if (raiz != null)
            {
                if (raiz.id == clave)
                    encontrado = raiz.componente;
                else
                {
                    if(raiz.id > clave)
                    {
                        if(raiz.hijoIzquierdo!=null)
                        {
                            montado = raiz.hijoIzquierdo;
                            encontrado = BuscarNodo(montado, clave);
                        }
                        else
                            return encontrado;
                        
                    }
                    if (raiz.id < clave)
                    {
                        if (raiz.hijoDerecho != null)
                        {
                            montado = raiz.hijoDerecho;
                            encontrado = BuscarNodo(montado, clave);
                        }
                        else
                            return encontrado;
                    }
                }
            }
            return encontrado;
        }

        public Nodo EliminarNodo(Nodo raiz, Componente componente)
        {

            if (raiz == null)
                return null;
            if (componente.Clave < raiz.id)
                raiz.hijoIzquierdo = EliminarNodo(raiz.hijoIzquierdo, componente);
            if (componente.Clave > raiz.id)
                raiz.hijoDerecho = EliminarNodo(raiz.hijoDerecho, componente);
            else
            {
                //0 nodos izquierdo & derecho
                if(raiz.hijoIzquierdo==null && raiz.hijoDerecho==null)
                {
                    raiz = null;
                    return null;
                }
                //1 nodo / iz || der
                
            }
            return null;
        }

        public Nodo BuscarReferenciaAnteriorNodo(Nodo raiz,Componente componente)
        {
            Nodo referencia=null;
            if (raiz == null)
                return null;

            if (raiz.hijoIzquierdo != null)
                if (raiz.hijoIzquierdo.id == componente.Clave)
                    return raiz;

            if (raiz.hijoDerecho != null)
                if (raiz.hijoDerecho.id == componente.Clave)
                    return raiz;

            if (raiz.hijoIzquierdo != null && raiz.id < componente.Clave)
                referencia = BuscarReferenciaAnteriorNodo(raiz, componente);

            if (raiz.hijoDerecho != null && raiz.id > componente.Clave)
                referencia = BuscarReferenciaAnteriorNodo(raiz, componente);

            return referencia;
        }




    }
}
