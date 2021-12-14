using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Media.Abstractions;
using ProyectoFinal.Model;
using Xamarin.Forms;

namespace ProyectoFinal.ViewModel
{
    public class FotoViewModel : FotoModel
    {
        public Command CapturarComando { get; set; }
        public FotoViewModel()
        {
            CapturarComando = new Command(TomarFoto);
        }
        private async void TomarFoto()
        {
            var camara = new StoreCameraMediaOptions();
            camara.PhotoSize = PhotoSize.Full;
            camara.SaveToAlbum = true;
            var foto = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(camara);
            if (foto != null)
            {
                Fotico = ImageSource.FromStream(() =>
                {
                    return foto.GetStream();
                });
            }
        }
    }
}
