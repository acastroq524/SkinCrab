using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CentrosMedicos : ContentPage
    {
        public IList<CentrosMedicosList> CentrosMedicosList { get; private set; }
        public CentrosMedicos()
        {
            InitializeComponent();
            CentrosMedicosList = new List<CentrosMedicosList>();

            CentrosMedicosList.Add(new CentrosMedicosList
            {
                Nombre = "Clínica Santa Lucia",
                Telefono = "2222-3344",
                Url = "https://pbs.twimg.com/profile_images/2245267797/logos_santa_lucia-01_400x400.jpg"
            });
            CentrosMedicosList.Add(new CentrosMedicosList
            {
                Nombre = "Clínica Biblica",
                Telefono = "2222-5566",
                Url = "https://cambioclimatico.go.cr/wp-content/uploads/2018/09/hospital-clinica-biblica-1.jpg"
            });
            BindingContext = this;
            CentrosMedicosList.Add(new CentrosMedicosList
            {
                Nombre = "Clínica Hospital Cima",
                Telefono = "2222-7788",
                Url = "https://images.hulilabs.com/huli/clinic/images/20072018/80303/ed5f51ba3399bc5b825995d7c08ba0f9.jpg"
            });
            BindingContext = this;
        }
        public void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CentrosMedicos selectedItem = e.SelectedItem as CentrosMedicos;
        }

        private void ListView_ItemTapped(object seneder, ItemTappedEventArgs e)
        {
            CentrosMedicos tappedItem = e.Item as CentrosMedicos;
        }
    }
}