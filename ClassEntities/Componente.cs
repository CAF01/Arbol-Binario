namespace ClassEntities
{
    public class Componente
    {
        public int Clave { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Descripcion { get; set; }
        //public object Imagen_uno { get; set; }
        //public object Imagen_dos { get; set; }


        public Componente RetornarDatos()
        {
            return new Componente()
            {
                Clave = Clave,
                Categoria = Categoria,
                Marca = Marca,
                Modelo = Modelo,
                Serie = Serie,
                Descripcion = Descripcion
            };
        }

        //public bool InsertarImagen()
        //{

        //}
    }
}
