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
            //BindingContext = new UsersViewModel(this);
            PiPuesto.Items.Add("Cajero");
            PiPuesto.Items.Add("Computacion");
            PiPuesto.Items.Add("Auditor");
            PiPuesto.Items.Add("Gerente");
            PiPuesto.Items.Add("Supervisor");
        }

        private void PiPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = PiPuesto.Items[PiPuesto.SelectedIndex];


        }
    }
}