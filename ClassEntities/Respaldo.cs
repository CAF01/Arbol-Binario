using System.Text.Json.Serialization;

namespace ClassEntities
{
    
    public class Respaldo
    {
        public Nodo Referencia { get; set; }
        public int contNodos { get; set; }

        [JsonConstructor]
        public Respaldo()
        {
        }
    }
}
