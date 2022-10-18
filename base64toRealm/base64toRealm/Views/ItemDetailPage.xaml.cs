using base64toRealm.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace base64toRealm.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}