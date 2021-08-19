using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reservacion : ContentPage
    {
        public Reservacion()
        {
            InitializeComponent();
            //BindingContext = new ReservationViewModel(this);
        }       

        private void ListServices_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           // var viewModel = BindingContext as ServicesViewModels;
            //var service = e.Item as Service;
        }
    }
}