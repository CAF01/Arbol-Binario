﻿using ClassDataAccess;
using ClassEntities;

namespace ClassBusinessLogic
{
    public class Negocios
    {
        private Arbol Arbol;
        public Negocios()
        {
            this.Arbol = new Arbol();
        }

        public Nodo AgregarComponente(Componente componente)
        {
            Nodo nodoReferencia = this.Arbol.Referencia;
            return this.Arbol.InsertarNodo(new Nodo(componente), nodoReferencia);
        }

        public string[] MostrarComponentesPorOrden(Transversa transversa)
        {
            Nodo nodoReferencia = this.Arbol.Referencia;
            string[] result=null;
            switch (transversa)
            {
                case Transversa.PreOrder:
                    result= this.Arbol.Transversa_preOrder(nodoReferencia,transversa);
                    break;
                case Transversa.InOrder:
                    result= this.Arbol.Transversa_preOrder(nodoReferencia, transversa);
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

        public Nodo EliminarComponente(Componente componente)
        {
            bool bandera = false;
            Nodo nodoReferencia= this.Arbol.Referencia;

            _=nodoReferencia.id == componente.Clave ? bandera = true : bandera = false;

            if (this.Arbol.BuscarNodo(nodoReferencia, componente.Clave) != null)
            {
                Nodo DevuelveRaiz=this.Arbol.EliminarNodo(nodoReferencia, ref componente);
                if (bandera)
                    this.Arbol.Referencia = DevuelveRaiz;
                return DevuelveRaiz;
            }

            return null;
        }
    }
}
