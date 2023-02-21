using Linterna.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Linterna
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new linterna();
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
