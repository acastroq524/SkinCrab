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
    public partial class VerDictamen : ContentPage
    {
        public VerDictamen()
        {
            InitializeComponent();
            btnLeer.Clicked += BtnLeer_Clicked;
            

        }

        private void BtnLeer_Clicked(object sender, EventArgs e)
        {
            String nombreArchivo = "autoexamen.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);
            if (File.Exists(rutaCompleta))
            {
                using (var lector = new StreamReader(rutaCompleta, true))
                {
                    String TextoLeido;
                    while ((TextoLeido = lector.ReadLine()) != null)
                    {
                        lblResultado.Text = TextoLeido;
                    }
                }
            }
        }
    }
}