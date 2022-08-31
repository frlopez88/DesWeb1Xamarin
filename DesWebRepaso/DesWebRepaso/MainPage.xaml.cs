using DesWebRepaso.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DesWebRepaso
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FuncionLuigi(object sender, EventArgs e)
        {

            etiqueta1.Text = "Hola soy Luigi";
            etiqueta1.TextColor = Xamarin.Forms.Color.FromHex("#15e665");
            imagen1.Source = "https://www.nintenderos.com/wp-content/uploads/2009/08/luigi-nintendo.jpg";


        }

        private void FuncioMario(object sender, EventArgs e)
        {
            etiqueta1.Text = "Hola soy Mario";
            etiqueta1.TextColor = Xamarin.Forms.Color.FromHex("#eb2d1c");
            imagen1.Source = "https://assets.nintendo.com/image/upload/f_auto/q_auto/dpr_1.25/c_scale,w_600/ncom/en_US/games/switch/n/new-super-mario-bros-u-deluxe-switch/description-image";
        }

        private void FuncionCrearPersona(object sender, EventArgs e)
        {
            persona temporal = new persona() { 
                nombre = nombre_form.Text,
                edad = int.Parse(edad_form.Text), 
                pass = pass_form.Text, 
                telefono = telefono_form.Text
            };


            Resultado.Text = temporal.reportePersona();

        }
    }
}
