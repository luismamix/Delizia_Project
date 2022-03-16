using System;
using Newtonsoft.Json;
namespace Delizia_Project.Models
{
    public class Contenido
    {
        [JsonProperty("id_contenido")]
        public String id_contenido { get; set; }
        [JsonProperty("fecha")]
        public String fecha { get; set; }
        [JsonProperty("hora")]
        public String hora { get; set; }
        [JsonProperty("nombre")]
        public String nombre { get; set; }
        [JsonProperty("tamanio")]
        public String tamanio { get; set; }
        [JsonProperty("masa")]
        public String masa { get; set; }
        [JsonProperty("tipo")]
        public String tipo { get; set; }
        [JsonProperty("anadir")]
        public String anadir { get; set; }
        [JsonProperty("pedido")]
        public String pedido { get; set; }
        [JsonProperty("ver")]
        public String ver { get; set; }
    }
}
