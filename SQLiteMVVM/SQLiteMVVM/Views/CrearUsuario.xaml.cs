using Plugin.Media;
using SQLiteMVVM.Models;
using SQLiteMVVM.Utils;
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
        }
    }
}