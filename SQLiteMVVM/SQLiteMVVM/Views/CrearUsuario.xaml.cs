using SQLiteMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteMVVM.Views
{
    public partial class CrearUsuario : ContentPage
    {
        public CrearUsuario()
        {
            InitializeComponent();
            BindingContext = new EmpleadoViewModel(this);
        }

        private void PiPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var name = PiPuesto.Items[PiPuesto.SelectedIndex];


        }
    }
}