using base64toRealm.Services;
using base64toRealm.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace base64toRealm
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
