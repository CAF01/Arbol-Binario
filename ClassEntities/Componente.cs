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
        public string Imagen_uno { get; set; }
        public string Imagen_dos { get; set; }


        public Componente RetornarDatos()
        {
            return new Componente()
            {
                Clave = Clave,
                Categoria = Categoria,
                Marca = Marca,
                Modelo = Modelo,
                Serie = Serie,
                Descripcion = Descripcion,
                Imagen_uno = Imagen_uno,
                Imagen_dos = Imagen_dos
            };
        }

        //public bool InsertarImagen()
        //{

        //}
    }
}
