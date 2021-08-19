using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLiteMVVM.Views;
using SQLiteMVVM.Models;
using System.IO;

namespace SQLiteMVVM
{
    public partial class App : Application
    {

        static BaseDatos BD;
        public static string UbicacionDB = string.Empty;

        public static BaseDatos InstanciaBD
        {
            get
            {
                if (BD == null)
                {
                    BD = new BaseDatos(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "archivo.db3"));
                }
                return BD;
            }
        }
        public App(string DBlocal)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CrearUsuario());

            UbicacionDB = DBlocal;
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CrearUsuario());
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
