
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace base64toRealm.Views
{

    public partial class Base64buttton : ContentPage
    {
        public static string base64 { get; set; }
        public static string id { get; set; }


        public Base64buttton()
        {
            InitializeComponent();
            CameraButton.Clicked += CameraButton_Clicked;

        }

        public async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            //if (photo != null)
             //   PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });

            var stream = photo.GetStream();
            var bytes = new byte[stream.Length];
            await stream.ReadAsync(bytes, 0, (int)stream.Length);
            base64 = System.Convert.ToBase64String(bytes);
            await DisplayAlert ("This is the File Path",base64,"Yes");
            
            // Convert base 64 string to byte[]
            
        }

        private async void ClickedfromBase(object sender, EventArgs e)
        {
            byte[] imageBytes = Convert.FromBase64String(base64);
            TestPhotoImage.Source = ImageSource.FromStream(() => new MemoryStream(imageBytes));
        }

    }
}