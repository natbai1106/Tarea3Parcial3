using Acr.UserDialogs;
using System;
using System.Collections.Generic;
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

        string nombre;
        string apellido;
        int edad;
        string direccion;    


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

        public async Task<int> OnSaveUserClicked()
        {
            return 0;
        }
    }
}

