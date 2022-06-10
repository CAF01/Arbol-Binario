using ClassEntities;
using System.IO;
using System.Text.Json;

namespace ClassDataAccess
{
    public class Arbol
    {
        public Nodo Referencia;

        private int contNodos=0;
        private int recorrer = 0;
        private int i= 0;

        private bool inicia = false;

        private Componente[] componentesPreOrder;
        private Componente[] componentesInOrder;
        private Componente[] componentesPostOrder;

        private Graficador[] graficador;

        public Arbol()
        {
            this.Referencia = null;
            //this.Inicio = null;
        }

        public string RespaldarInformacion(string NombreArchivo)
        {
            string JsonFile=null;
            if (this.Referencia!=null && contNodos>0)
            {
                Respaldo respaldo = new Respaldo() { Referencia=this.Referencia,contNodos=this.contNodos};
                JsonFile=JsonSerializer.Serialize(respaldo);
            }
            return JsonFile;
        }

        public bool RestaurarInformacion(string JsonFile)
        {
            Respaldo respaldo = JsonSerializer.Deserialize<Respaldo>(JsonFile);
            if(respaldo.Referencia!=null && respaldo.contNodos>0)
            {
                this.Referencia = respaldo.Referencia;
                this.contNodos=respaldo.contNodos;
                this.recorrer = 0;
                this.i = 0;
                this.inicia = true;
                return true;
            }
            return false;
        }

        public Nodo InsertarNodo(Nodo nuevoNodo, Nodo nodo)
        {
            Nodo temp;
            if(nodo==null)
            {
                if(!this.inicia)
                {
                    this.inicia = true;
                    this.Referencia = nuevoNodo;
                }
                contNodos++;
                return temp = nuevoNodo;
            }

            if(nuevoNodo.id < nodo.id)
                nodo.hijoIzquierdo = InsertarNodo(nuevoNodo, nodo.hijoIzquierdo);
            if (nuevoNodo.id > nodo.id)
                nodo.hijoDerecho = InsertarNodo(nuevoNodo, nodo.hijoDerecho);
            return nodo;

        }
        public Componente[] Transversa_preOrder(Nodo raiz, Transversa transversa)
        {
            if (recorrer == 0)
                componentesPreOrder = new Componente[contNodos];
            
            if (contNodos>0 && recorrer!=contNodos)
            {
                componentesPreOrder[recorrer] = raiz.componente;

                recorrer++;

                if (raiz.hijoIzquierdo!=null)
                {
                    Transversa_preOrder(raiz.hijoIzquierdo,transversa);
                }

                if(raiz.hijoDerecho!=null)
                {
                    Transversa_preOrder(raiz.hijoDerecho,transversa);
                }
                if(recorrer==contNodos)
                {
                    recorrer = 0;
                }
            }
            if (recorrer == 0 && contNodos > 0)
                return this.imprimirComponentes(transversa);
            return null;
        }
        public Componente[] Transversa_inOrder(Nodo raiz, Transversa transversa)
        {
            if (recorrer == 0)
                componentesInOrder = new Componente[contNodos];

            if (contNodos > 0 && recorrer != contNodos)
            {
                
                if (raiz.hijoIzquierdo != null)
                {
                    Transversa_inOrder(raiz.hijoIzquierdo, transversa);
                }

                componentesInOrder[recorrer] = raiz.componente;
                recorrer++;

                if (raiz.hijoDerecho != null)
                {
                    Transversa_inOrder(raiz.hijoDerecho,transversa);
                }
                if (recorrer == contNodos)
                {
                    recorrer = 0;
                    
                }
            }
            if(recorrer==0 && contNodos>0)
                return this.imprimirComponentes(transversa);
            return null;
        }
        public Componente[] Transversa_postOrder(Nodo raiz,Transversa transversa)
        {
            if (recorrer == 0)
                componentesPostOrder = new Componente[contNodos];

            if (contNodos > 0 && recorrer != contNodos)
            {

                if (raiz.hijoIzquierdo != null)
                {
                    Transversa_postOrder(raiz.hijoIzquierdo,transversa);
                }

                if (raiz.hijoDerecho != null)
                {
                    Transversa_postOrder(raiz.hijoDerecho,transversa);
                }

                componentesPostOrder[recorrer] = raiz.componente;
                recorrer++;

                if (recorrer == contNodos)
                {
                    recorrer = 0;
                }
            }
            if (recorrer == 0 && contNodos > 0)
                return this.imprimirComponentes(transversa);
            return null;

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
        public Nodo EliminarNodo(Nodo raiz, ref Componente componente)
        {

            if (raiz == null || componente==null)
                return null;
            if(componente!=null)
                if (componente.Clave < raiz.id)
                    raiz.hijoIzquierdo = EliminarNodo(raiz.hijoIzquierdo, ref componente);
            if(componente!=null)    
                if (componente.Clave > raiz.id)
                    raiz.hijoDerecho = EliminarNodo(raiz.hijoDerecho, ref componente);
                

            //0 nodos izquierdo & derecho
            if(raiz.hijoIzquierdo==null && raiz.hijoDerecho==null && componente!=null)
            {
                raiz = null;
                contNodos--;
                componente = null;
                return raiz;
            }

            //1 nodo / iz || der
            if ((raiz.hijoIzquierdo == null || raiz.hijoDerecho == null) && componente != null)
            {
                Nodo Refanterior = null;
                if (raiz.hijoIzquierdo == null)
                {
                    Refanterior = this.BuscarReferenciaAnteriorNodo(this.Referencia, componente);
                    if(Refanterior!=null)
                    {
                        if(Refanterior.hijoIzquierdo.componente.Clave == componente.Clave)//actualizados - 08/06
                        {
                            Refanterior.hijoIzquierdo = raiz.hijoDerecho;
                            Refanterior.hijoIzquierdo.id = raiz.hijoIzquierdo.componente.Clave;
                        }
                            
                    }
                    if(Refanterior!=null)
                    {
                        if(Refanterior.hijoDerecho.componente.Clave == componente.Clave)//actualizados - 08/06
                        {
                            Refanterior.hijoDerecho = raiz.hijoDerecho;
                            Refanterior.hijoDerecho.id = Refanterior.hijoDerecho.componente.Clave;
                        }
                            
                    }
                    //Refanterior.hijoDerecho = raiz.hijoDerecho; ESTE ES EL ORIGINAL
                    //Refanterior.hijoDerecho.hijoDerecho = otro;
                }
                if(raiz.hijoDerecho==null)
                {
                    Refanterior = this.BuscarReferenciaAnteriorNodo(this.Referencia, componente);
                    if (Refanterior != null && Refanterior.hijoIzquierdo!=null)
                    {
                        if(Refanterior.hijoIzquierdo.componente.Clave == componente.Clave)
                        {
                            Refanterior.hijoIzquierdo = raiz.hijoIzquierdo;
                            Refanterior.hijoIzquierdo.id = Refanterior.hijoIzquierdo.componente.Clave;
                        }
                            
                    }
                    if (Refanterior != null && Refanterior.hijoDerecho != null)
                    {
                        if(Refanterior.hijoDerecho.componente.Clave == componente.Clave)
                        {
                            Refanterior.hijoDerecho = raiz.hijoIzquierdo;
                            Refanterior.hijoDerecho.id = Refanterior.hijoDerecho.componente.Clave;
                        }
                            
                    }
                    //Refanterior.hijoIzquierdo = raiz.hijoIzquierdo; ORIGINAL
                }
                componente = null;
                contNodos--;
                if (raiz.hijoIzquierdo == null)
                    return raiz.hijoDerecho;
                if(raiz.hijoDerecho == null)
                    return raiz.hijoIzquierdo;
            }

            //2 Nodos hijos
            else
            {
                if (componente != null)
                {
                    Nodo MontadoSobreRaiz = raiz;
                    MontadoSobreRaiz.componente = this.BuscaMinimoValor(raiz.hijoDerecho);
                    MontadoSobreRaiz.id = MontadoSobreRaiz.componente.Clave;
                    componente = MontadoSobreRaiz.componente;
                    raiz.hijoDerecho = this.EliminarNodo(raiz.hijoDerecho, ref componente);
                    //componente = raiz.componente;
                    componente = null;
                }

            }
            if(contNodos==0)//Ya no hay referencia sobre raiz original
                inicia = false;
            return raiz;
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

            if (raiz.hijoIzquierdo != null && raiz.id > componente.Clave)
                referencia = BuscarReferenciaAnteriorNodo(raiz.hijoIzquierdo, componente);

            if (raiz.hijoDerecho != null && raiz.id < componente.Clave)
                referencia = BuscarReferenciaAnteriorNodo(raiz.hijoDerecho, componente);

            return referencia;
        }
        public Componente BuscaMinimoValor(Nodo raiz)
        {
            Nodo Montado = null;
            Componente minimoComponente = null;
            if (raiz == null)
                return minimoComponente;

            Montado = raiz;
            minimoComponente = Montado.componente;
            while (Montado.hijoIzquierdo != null)
            {
                Montado = Montado.hijoIzquierdo;
                minimoComponente = Montado.componente;
            }
            //if (Montado.hijoDerecho != null)
            //{
            //    while (Montado.hijoDerecho != null)
            //    {
            //        Montado = Montado.hijoDerecho;
            //        minimoComponente = Montado.componente;
            //    }
            //}

            return minimoComponente;
        }
        //public Nodo BuscarUltimoNodo(Nodo raiz)
        //{
        //    if (raiz == null)
        //        return null;

        //    this.Referencia = raiz;
        //    while (this.Referencia.hijoIzquierdo != null)
        //    {
        //        this.Referencia = this.Referencia.hijoIzquierdo;
        //    }
        //    while(this.Referencia.hijoDerecho!=null)
        //    {
        //        this.Referencia=this.Referencia.hijoDerecho;
        //    }

        //    return this.Referencia;

        //}
        public Componente[] imprimirComponentes(Transversa transversa)
        {
            switch (transversa)
            {
                case Transversa.PreOrder:
                    if (this.componentesPreOrder != null)
                    {
                        return this.componentesPreOrder;
                        //cadena = new string[contNodos];
                        //for (int a = 0; a < contNodos; a++)
                        //{
                        //    cadena[a] = this.componentesPreOrder[a].Clave.ToString();
                        //}
                    }
                    break;
                case Transversa.InOrder:
                    if (this.componentesInOrder != null)
                    {
                        return this.componentesInOrder;
                        //cadena = new string[contNodos];
                        //for (int a = 0; a < contNodos; a++)
                        //{
                        //    cadena[a] = this.componentesInOrder[a].Clave.ToString();
                        //}
                    }
                    break;
                case Transversa.PostOrder:
                    if (this.componentesPostOrder != null)
                    {
                        return this.componentesPostOrder;
                        //cadena = new string[contNodos];
                        //for (int a = 0; a < contNodos; a++)
                        //{
                        //    cadena[a] = this.componentesPostOrder[a].Clave.ToString();
                        //}
                    }
                    break;
            }
            return null;
        }
        public Graficador[] RecorrerArbol(Nodo raiz,bool dir,float x,float y)
        {
            Nodo referencia = raiz;
            if (i == 0 && raiz != null)
            {
                graficador = new Graficador[contNodos];
                //la mitad de la pantalla, deberia ser el centro
            }

            if (contNodos > 0 && i < contNodos)
            {
                graficador[i] = new Graficador();
                graficador[i].componente = referencia.componente;
                graficador[i].x1 = x;
                graficador[i].y1 = y;
                if (!dir)
                {
                    x -= 240;
                    graficador[i].x2 = x;
                }
                    
                if (dir)
                {
                    x += 300;
                    graficador[i].x2 = x;
                }
                y += 200;

                graficador[i].y2 = y;
                if(i==0)
                {
                    x += 240;
                    y -= 200;
                    graficador[i].y2 = y;
                    graficador[i].x2 = x;
                }
                if(this.Referencia.hijoIzquierdo!=null)
                    if(this.Referencia.hijoIzquierdo.id==raiz.id)
                    {
                        x -= 400;
                        y += 225;
                        graficador[i].y2 = y;
                        graficador[i].x2 = x;
                    }
                if(this.Referencia.hijoDerecho!=null)
                    if(this.Referencia.hijoDerecho.id==raiz.id)
                    {
                        x += 400;
                        y += 325;
                        graficador[i].y2 = y;
                        graficador[i].x2 = x;
                    }
                i++;

                if (raiz.hijoIzquierdo != null)
                {
                    RecorrerArbol(raiz.hijoIzquierdo,false,x,y);
                }

                if (raiz.hijoDerecho != null)
                {
                    RecorrerArbol(raiz.hijoDerecho,true,x,y);
                }

            }
            if (i == contNodos)
                i = 0;
            return graficador;

        }
    }
}



