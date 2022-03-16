using System;
using System.Collections.Generic;
using Delizia_Project.Models;
using Xamarin.Forms;

namespace Delizia_Project
{
    public partial class VentanaPedido : ContentPage
    {
        public VentanaPedido(List<Pizza> listado_pizzas)
        {
            InitializeComponent();
            double total = 0;
         
            lbltitulo.Text = "Recogida: " + listado_pizzas[0].hora + " - " + listado_pizzas[0].fecha ;
            lblnombre.Text = "Nombre: " + listado_pizzas[0].nombre;
            this.tabla.RowDefinitions = new RowDefinitionCollection();
            this.tabla.ColumnDefinitions = new ColumnDefinitionCollection();
            //pintar en un grid.
            //4columnas
            for (int i = 0; i< 4; i++)
            {
                this.tabla.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            }
            //pizzas(count) nº de filas
            for (int i = 0; i< listado_pizzas.Count; i++)
            {
                this.tabla.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }

            //ENCABEZADO
            tabla.Children.Add(new Label
            {
                Text = "Especialidad",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.OrangeRed,
                //FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
            }, 0, 0);//fila - columna????

            tabla.Children.Add(new Label
            {
                Text = "Tamaño",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.OrangeRed,
                //FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
            }, 1, 0);
            this.tabla.Children.Add(new Label
            {
                Text = "Masa",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.OrangeRed,
                //FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
            }, 2, 0);
            tabla.Children.Add(new Label
            {
                Text = "Importe",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.OrangeRed,
                //FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
            }, 3, 0);

            //FILAS empieza en la fila 1 del grid
            for (int i = 1; i<= listado_pizzas.Count; i++)
            {
                tabla.Children.Add(new Label
                {
                    Text = listado_pizzas[i - 1].especialidad,
                    FontSize = 18,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Gray
                }, 0, i);

                tabla.Children.Add(new Label
                {
                    Text = listado_pizzas[i - 1].tamanio,
                    FontSize = 18,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Gray
                }, 1, i);
                tabla.Children.Add(new Label
                {
                    Text = listado_pizzas[i - 1].masa,
                    FontSize = 18,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Gray
                }, 2, i);
                tabla.Children.Add(new Label
                {
                    Text = listado_pizzas[i - 1].importe + "€",
                    FontSize = 18,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Gray
                }, 3, i);
                total += listado_pizzas[i - 1].importe;
            }

            //FILA del total
            
            tabla.Children.Add(new Label
            {
                Text = "Total",
                TextColor = Color.OrangeRed,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, 2, listado_pizzas.Count + 1);

            tabla.Children.Add(new Label
            {
                Text = total + "€",
                TextColor = Color.Gray,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, 3, listado_pizzas.Count + 1);


            // Accomodate iPhone status bar.q hara???
            //this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            this.tabla.Padding = new Thickness(10);
        }

    }
}
