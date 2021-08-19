using Acr.UserDialogs;
using SQLiteMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteMVVM.ViewModels
{
    public class EmpleadoViewModel : BaseViewModel
    {
        public Command SendVerifyCommand { get; }
        public Command CancelRegisterCommand { get; }
        public Command SelectMedia { get; }

        Page Page;

        List<Puestos> cargo;
        string nombre;
        string apellido;
        int edad;
        string direccion;
        Puestos puestoselected;

        public Puestos PuestoSelected 
        {
            get => puestoselected; 
            set => SetProperty(ref puestoselected, value);
        }

        public List<Puestos> Cargo
        {
            get => cargo;
            set { SetProperty(ref cargo, value); }
        }

        public string Nombre
        {
            get => nombre;
            set { SetProperty(ref nombre, value); }
        }

        public string Apellido
        {
            get => apellido;
            set { SetProperty(ref apellido, value); }
        }
        public int Edad
        {
            get => edad;
            set { SetProperty(ref edad, value); }
        }

        public string Direccion
        {
            get => direccion;
            set { SetProperty(ref direccion, value); }
        }

        public EmpleadoViewModel(Page pag)
        {
            Page = pag;

            PuestoSelected = new Puestos();

            Cargar();

            SendVerifyCommand = new Command(OnSaveUserClicked);
        }

        private async Task Cargar()
        {
            Cargo = Puestos.ObtenerCargos().OrderBy(c => c.value).ToList();

        }

        //private bool CheckRequires()
        //{
        //    //message = "Oops, verifíca lo siguiente: ";
        //    //bool respuesta = true;
        //    //if (string.IsNullOrEmpty(User))
        //    //{
        //    //    respuesta = false;
        //    //    message += "\nEl usuario";
        //    //}
        //    //if (string.IsNullOrEmpty(Name))
        //    //{
        //    //    respuesta = false;
        //    //    message += "\nEl nombre";
        //    //}            
        //    //return respuesta;
        //}       

        public async void OnSaveUserClicked(object obj)
        {

            if (!string.IsNullOrEmpty(PuestoSelected.value) || !string.IsNullOrEmpty(Nombre) || !string.IsNullOrEmpty(Apellido) || edad==0 || !string.IsNullOrEmpty(Direccion) )
            {
                await Page.DisplayAlert("Mensaje", "No deben haber campos vacíos", "Ok");
            }
            else
            {
                await Page.DisplayAlert("Mensaje", "Felicidades, ahora sigue trabajando", "Ok");
            }

        }
    }
}

