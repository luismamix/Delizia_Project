using System;
using Newtonsoft.Json;

namespace Delizia_Project.Models
{
    public class Tamanio
    {
        [JsonProperty("id_tamanio")]
        public int id_tamanio { set; get; }
        [JsonProperty("tamanio")]
        public string tamanio { set; get; }
        [JsonProperty("importe")]
        public double importe { set; get; }
    }
}
