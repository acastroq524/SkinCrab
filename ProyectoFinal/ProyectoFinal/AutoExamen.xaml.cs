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
    public partial class AutoExamen : ContentPage
    {
        public AutoExamen()
        {
            InitializeComponent();
            btnEnviar.Clicked += BtnEnviar_Clicked;
        }

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            String nombreArchivo = "autoexamen.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);
            using (var escritor = File.CreateText(rutaCompleta))
            {
                escritor.Write("Al ser una lesion con " + lblSemanas.Text + " Semanas, es necesario visitar a un doctor urgente. Es importante Lavar la lesion con jabón antibacterial.");
            }
        }
    }
}