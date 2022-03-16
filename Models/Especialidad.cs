using System;
using Newtonsoft.Json;
namespace Delizia_Project.Models

{
    public class Especialidad
    {
        [JsonProperty("id_tipo")]
        public int id_tipo { set; get; }
        [JsonProperty("tipo")]
        public string tipo { set; get; }
        [JsonProperty("importe")]
        public double importe { set; get; }

    }
}
