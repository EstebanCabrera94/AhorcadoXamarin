using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AhorcadoXamarin
{
    public partial class MainPage : ContentPage
    {
        readonly string[] ALFABETO = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        public MainPage()
        {
            InitializeComponent();

            Inicializar();
        }

        private void Inicializar()
        {
            imageAhorcado.Source = ImageSource.FromResource("AhorcadoXamarin.img.1.png");
            int letra = 0;
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 6; columna++)
                {
                    gridBotonera.Children.Add(new Button
                    {
                        Text = ALFABETO[letra],
                    }, columna, fila);
                    letra++;
                    if (letra == ALFABETO.Length)
                    {
                        break;
                    }
                }
                   

                /*
                Button boton = new Button();
                boton.Text = ALFABETO[columna];
                gridBotonera.Children.Add(boton, columna, fila);
                */
            }
            
        }
    }
}
