using ClassDataAccess;
using ClassEntities;

namespace ClassBusinessLogic
{
    public class Negocios
    {
        public Arbol Arbol;
        public Negocios()
        {
            this.Arbol = new Arbol();
        }

        public bool ContieneValores()
        {
            bool flag;
            _ = this.Arbol.Referencia != null ? flag=true : flag=false;
            return flag;
        }

        public string RespaldaInformacion(string NomPath)
        {
            return this.Arbol.RespaldarInformacion(NomPath);
        }

        public bool RestaurarInformacion(string JsonFile)
        {
            return this.Arbol.RestaurarInformacion(JsonFile);
        }

        public Nodo AgregarComponente(Componente componente)
        {
            Nodo nodoReferencia = this.Arbol.Referencia;
            return this.Arbol.InsertarNodo(new Nodo(componente), nodoReferencia);
        }

        public Componente[] MostrarComponentesPorOrden(Transversa transversa)
        {
            Nodo nodoReferencia = this.Arbol.Referencia;
            Componente[] result=null;
            switch (transversa)
            {
                case Transversa.PreOrder:
                    result= this.Arbol.Transversa_preOrder(nodoReferencia,transversa);
                    break;
                case Transversa.InOrder:
                    result= this.Arbol.Transversa_inOrder(nodoReferencia, transversa);
                    break;
                case Transversa.PostOrder:
                    result = this.Arbol.Transversa_postOrder(nodoReferencia, transversa);
                    break;
                    //default:

                    //    break;
            }
            return result;
        }

        public Componente BuscarComponentePorClave(int clave)
        {
            Nodo nodoReferencia = this.Arbol.Referencia;
            return this.Arbol.BuscarNodo(nodoReferencia, clave);
        }

        public bool EliminarComponente(Componente componente)
        {
            if (this.ContieneValores())
            {
                bool bandera = false;
                Nodo nodoReferencia = this.Arbol.Referencia;

                _ = nodoReferencia.id == componente.Clave ? bandera = true : bandera = false;

                if (this.Arbol.BuscarNodo(nodoReferencia, componente.Clave) != null)
                {
                    Nodo DevuelveRaiz = this.Arbol.EliminarNodo(nodoReferencia, ref componente);
                    if (bandera)
                    {
                        this.Arbol.Referencia = DevuelveRaiz;
                    }
                    return true;
                }
            }
            return false;
        }

        public Graficador[] ObtenerCoordenadas(int x,int y)
        {
            Graficador[] graficadors=null;
            if(this.Arbol.Referencia!=null)
            {
                return this.Arbol.RecorrerArbol(this.Arbol.Referencia, false, x, y);
            }
            return graficadors;
        }
    }
}
