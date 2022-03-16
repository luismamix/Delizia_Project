using System;
using Newtonsoft.Json;

namespace Delizia_Project.Models
{
    public class Masa
    {
        [JsonProperty("id_masa")]
        public int id_masa { set; get; }
        [JsonProperty("masa")]
        public string masa { set; get; }
        [JsonProperty("importe")]
        public double importe { set; get; }
    }
}
