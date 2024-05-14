using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_LVLS_MHDI_AED
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
