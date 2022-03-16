using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delizia_Project.Models;
using Xamarin.Forms;

namespace Delizia_Project
{
    public partial class MainPage : ContentPage
    {
        public List<Pizza> pizzas;
        public MainPage()
        {
            InitializeComponent();
            pizzas = new List<Pizza>();
            //this.dummy.Text = CultureInfo.CurrentUICulture.Name;
            this.btn_añadir.Clicked += async (sender, args) =>
            {
             
                if (this.picker_especialidad.SelectedIndex != -1 &&
                    this.picker_masa.SelectedIndex != -1 &&
                    this.picker_tamanio.SelectedIndex != -1 &&
                    validarHora() && validarNombre())
                {
                    Pizza pizza = new Pizza();
                    pizza.fecha = this.fecha.Text;
                    pizza.hora = this.hora.Time.ToString();
                    pizza.nombre = this.nombre.Text;
                    Especialidad espe = (Especialidad)picker_especialidad.SelectedItem;
                    pizza.especialidad = espe.tipo;
                    pizza.importe += espe.importe;
                    Masa ma = (Masa)picker_masa.SelectedItem;
                    pizza.masa = ma.masa;
                    pizza.importe += ma.importe;
                    Tamanio ta = (Tamanio)picker_tamanio.SelectedItem;
                    pizza.tamanio = ta.tamanio;
                    pizza.importe += ta.importe;
                    pizzas.Add(pizza);
                    this.cantidad.Text = "(" + pizzas.Count + ")";
                    await DisplayAlert("Info", "Pizza añadida.", "Aceptar");
                    
                }
                else
                {
                    await DisplayAlert("Warning", "Error de validación, por favor revisa el formulario.", "Cerrar");
                    
                }
            };
            this.btn_pedido.Clicked += async (sender, args) =>
            {
                if(pizzas.Count > 0)
                {
                    //await DisplayAlert("Info", "Ver pedido.", "Aceptar");
                    //await Navigation.PushAsync(new VentanaPedido(pizzas));
                    //await NavigationPage(new VentanaPedido(pizzas));
                    //VentanaPedido ventana2 = new VentanaPedido(pizzas);
                    //new NavigationPage(new VentanaPedido(pizzas));
                    await Navigation.PushAsync(new VentanaPedido(pizzas));
                }
                else
                {
                    await DisplayAlert("Warning", "Error, añade alguna pizza al pedido ", "Cerrar");
                }
            };

        }

        public bool validarNombre()
        {
            if (string.IsNullOrEmpty(this.nombre.Text))
                return false;
            else
                return true;
        }

        public bool validarHora()
        {

            if (this.hora.Time >= DateTime.Now.TimeOfDay)
            {
                return true;
            } else
            {
                return false;
            }

        }
    }
}
