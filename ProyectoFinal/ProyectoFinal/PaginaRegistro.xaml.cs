using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaRegistro : ContentPage
    {
        public PaginaRegistro()
        {
            InitializeComponent();
            btnRegistrar.Clicked += BtnRegistrar_Clicked;
        }

        private void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            String nombreArchivo = "registro.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);
            using (var escritor = File.CreateText(rutaCompleta))
            {
                escritor.Write("Nombre: " + txtNombre.Text + 
                    "Corre: " + txtCorreo.Text +" Edad: " + txtEdad.Text +
                    " Genero: " + txtGenero.Text + " Origen Ednico: " + txtOrigenEtnico +
                    " Color de Piel: " + txtColorPiel + " Marcas de nacimiento: " + txtMarcasNacimiento +
                    " Ha sido diagnosticado con alguna afeccion de la piel?: "+
                    " Recibe algun tratamiento?:" + "Posee piel palida?" );
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            avisoTerminos();
        }

        public async Task avisoTerminos()
        {
            await DisplayAlert("Terminos y Condiciones", "Skincrab no es una herramienta de diagnostico y debes de visitar a un medico cuando" +
                " sientas que algo anda mal", "Ok", "Leer");
        }
    }
}