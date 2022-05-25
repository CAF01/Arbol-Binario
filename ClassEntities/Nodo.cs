namespace ClassEntities
{
    public class Nodo
    {
        public int id { get; set; }

        public Componente componente { get; set; }
        public Nodo hijoIzquierdo {get; set;}
        public Nodo hijoDerecho { get; set;}

        public Nodo(Componente componente)
        {
            this.componente = componente;
            this.id = componente.Clave;
        }
    }
}
