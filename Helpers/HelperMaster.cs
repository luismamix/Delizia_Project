using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Delizia_Project.Models;
using Newtonsoft.Json;

namespace Delizia_Project.Helpers
{
    public class HelperMaster
    {
        
       
        //private const string DireccionApi = "https://apiempleadosspgs.azurewebsites.net/";
        private const string DireccionApi = "https://webluispizzeria.azurewebsites.net/";

        private HttpClient CrearCliente()
        {
            //HttpClient CLASE q  hace la peticion (de tipo json) al Web Api
            HttpClient clientehttp = new HttpClient();
            clientehttp.DefaultRequestHeaders.Accept.Clear();
            clientehttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return clientehttp;
        }

        //funcion asincrona q llama a funcion asincrona.
        public async Task<List<Especialidad>> GetEspecialidades()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            //CREAMOS LA PETICION
            String peticion = DireccionApi + $"Especialidades";
            //OBJ DE TIPO URI
            var uri = new Uri(string.Format(peticion, string.Empty));
            //aqui hacemos la peticion 
            HttpClient client = CrearCliente();
            //guardamos la respuesta
            var respuesta = await client.GetAsync(uri);
            //si la respuesta es ok (200)
            if (respuesta.IsSuccessStatusCode)
            {   //parseamos a string json
                var contenido = await respuesta.Content.ReadAsStringAsync();
                //deserializamos en un obj Doctor.
                especialidades = JsonConvert.DeserializeObject<List<Especialidad>>(contenido);

            }
            return especialidades;
        }

        //funcion asincrona q llama a funcion asincrona.
        public async Task<List<Masa>> GetMasas()
        {
            List<Masa> masas = new List<Masa>();
            //CREAMOS LA PETICION
            String peticion = DireccionApi + $"Masas";
            //OBJ DE TIPO URI
            var uri = new Uri(string.Format(peticion, string.Empty));
            //aqui hacemos la peticion 
            HttpClient client = CrearCliente();
            //guardamos la respuesta
            var respuesta = await client.GetAsync(uri);
            //si la respuesta es ok (200)
            if (respuesta.IsSuccessStatusCode)
            {   //parseamos a string json
                var contenido = await respuesta.Content.ReadAsStringAsync();
                //deserializamos en un obj Doctor.
                masas = JsonConvert.DeserializeObject<List<Masa>>(contenido);

            }
            return masas;
        }

        //funcion asincrona q llama a funcion asincrona.
        public async Task<List<Tamanio>> GetTamanios()
        {
            List<Tamanio> tamanios = new List<Tamanio>();
            //CREAMOS LA PETICION
            String peticion = DireccionApi + $"Tamanios";
            //OBJ DE TIPO URI
            var uri = new Uri(string.Format(peticion, string.Empty));
            //aqui hacemos la peticion 
            HttpClient client = CrearCliente();
            //guardamos la respuesta
            var respuesta = await client.GetAsync(uri);
            //si la respuesta es ok (200)
            if (respuesta.IsSuccessStatusCode)
            {   //parseamos a string json
                var contenido = await respuesta.Content.ReadAsStringAsync();
                //deserializamos en un obj Doctor.
                tamanios = JsonConvert.DeserializeObject<List<Tamanio>>(contenido);

            }
            return tamanios;
        }

        //funcion asincrona q llama a funcion asincrona.
        public async Task<Contenido> GetContenido()
        {
            Contenido  contenido  = new Contenido();

            //CREAMOS LA PETICION
            string locale = CultureInfo.CurrentUICulture.Name;
            string lang = "";
            switch (locale)
            {
                case "fr-FR":
                    lang = "FR";
                    break;
                case "es-US":
                case "es-ES":
                    lang = "ES";
                    break;
                case "it-IT":
                    lang = "IT";
                    break;
                default:
                    break;
            }
            String peticion = DireccionApi + $"Contenidos/" + lang;
            //OBJ DE TIPO URI
            var uri = new Uri(string.Format(peticion, string.Empty));
            //aqui hacemos la peticion 
            HttpClient client = CrearCliente();
            //guardamos la respuesta
            var respuesta = await client.GetAsync(uri);
            //si la respuesta es ok (200)
            if (respuesta.IsSuccessStatusCode)
            {   //parseamos a string json
                var magic = await respuesta.Content.ReadAsStringAsync();
                //deserializamos en un obj Doctor.
                contenido = JsonConvert.DeserializeObject<Contenido>(magic);

            }
            return contenido;
        }
    }
}

