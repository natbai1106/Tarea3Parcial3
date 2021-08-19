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

        #region Declaracion de variables
        string message;
        string name;
        string lastName;
        string address;
        string mail;
        string telephone;
        string user;
        string password;
        bool lastMethodVerify = false;
        bool verifyByMail = true;
        bool takeNewPhoto;
        string urlPhoto;


        public string Name
        {
            get => name;
            set { SetProperty(ref name, value); }
        }
        public string LastName
        {
            get => lastName;
            set { SetProperty(ref lastName, value); }
        }
        public string Address
        {
            get => address;
            set { SetProperty(ref address, value); }
        }
        public string Mail
        {
            get => mail;
            set { SetProperty(ref mail, value); }
        }
        public string Telephone
        {
            get => telephone;
            set { SetProperty(ref telephone, value); }
        }
        public string User
        {
            get => user;
            set { SetProperty(ref user, value); }
        }
        public string Password { get => password; set { SetProperty(ref password, value); } }


        public bool VerifyByMail
        {
            get => verifyByMail;
            set { SetProperty(ref verifyByMail, value); }
        }
        public bool TakeNewPhoto { get => takeNewPhoto; set => takeNewPhoto = value; }
        public string UrlPhoto { get => urlPhoto; set { SetProperty(ref urlPhoto, value); } }


        #endregion
        public EmpleadoViewModel(Page pag)
        {
            Page = pag;
            SendVerifyCommand = new Command(OnRequestVerify);
            //CancelRegisterCommand = new Command(OnCancelRegister);
            //SelectMedia = new Command(OnSelectedMedia);

            //LoadCache();


        }
        private async void OnRequestVerify(object obj)
        {


           
        }

        /*Abre la galeria*/
        //private async void OnOpenGalery()
        //{
        //    var media = new MediaManager();

        //    UserDialogs.Instance.ShowLoading("Cargando");
        //    bool isSuccess = await media.TakePicture();
        //    LoadPhoto(isSuccess, media);
        //    UserDialogs.Instance.HideLoading();
        //}
        #region Foto
        /*Abre la camarara*/
        //private async void OnTakePhoto()

        //{
        //    var media = new MediaManager();
        //    //Se crea una instancia de la clase MediaManager para mostrar los cuando se esta cargando
        //    UserDialogs.Instance.ShowLoading("Cargando");
        //    bool isSuccess = await media.PickPicture();
        //    LoadPhoto(isSuccess, media);
        //    UserDialogs.Instance.HideLoading();
        //}

        //Se carga la foto obtenidad de la galeria o camara y la almacena en las variables para mostrarla en la vista
        //private void LoadPhoto(bool isSucces, MediaManager media)
        //{
        //    if (isSucces)
        //    {

        //        UrlPhoto = media.Path;
        //        TakeNewPhoto = true;
        //    }
        //}
        #endregion
        //private async void OnCancelRegister()
        //{

        //    bool IsCanceled = await Page.DisplayAlert("Cancelar registro", "¿Esta seguro que desea cancelar?, si tiene datos ingresados se perderan.", "Aceptar", "Cancelar");
        //    if (IsCanceled)
        //    {
        //        UserDialogs.Instance.ShowLoading("Cargando");

        //        Barrel.Current.EmptyAll();
        //        Preferences.Clear();
        //        Page.Navigation.InsertPageBefore(new LoginPage(), Page);
        //        await Page.Navigation.PopAsync();

        //        UserDialogs.Instance.HideLoading();



        //    }
        //}



        //private async void LoadCache()
        //{

        //    string usuario = Constanst.USER_CACHE;
        //    if (Barrel.Current.Exists(key: usuario))
        //    {
        //        if (!Barrel.Current.IsExpired(key: usuario))
        //        {

        //            UserInCache = Barrel.Current.Get<User>(usuario);
        //            Name = UserInCache.Nombre;
        //            LastName = UserInCache.Apellido;
        //            Address = UserInCache.Direccion;
        //            Mail = UserInCache.Correo;
        //            Telephone = UserInCache.Telefono;
        //            User = UserInCache.Usuario;
        //            Password = UserInCache.Contrasena;
        //            UrlPhoto = UserInCache.UrlFoto;
        //            TakeNewPhoto = true;


        //            //Establce nuevamente el metodo de verificacion
        //            if (UserInCache.ModoVerificacion.Equals(Constanst.VERIFY_MAIL))
        //                VerifyByMail = true;
        //            else
        //                VerifyByMail = false;

        //            lastMethodVerify = VerifyByMail;
        //        }
        //        else
        //        {
        //            UserInCache = new User();
        //            UrlPhoto = Constanst.USER_IMAGE_DEFAULT;
        //        }

        //    }

        //    else
        //    {
        //        UrlPhoto = Constanst.USER_IMAGE_DEFAULT;
        //        UserInCache = new User();
        //    }


        //}


        private bool CheckRequires()
        {
            message = "Oops, verifíca lo siguiente: ";
            bool respuesta = true;
            if (string.IsNullOrEmpty(User))
            {
                respuesta = false;
                message += "\nEl usuario";
            }
            if (string.IsNullOrEmpty(Name))
            {
                respuesta = false;
                message += "\nEl nombre";
            }

            
            return respuesta;
        }       

        public async Task<int> OnSaveUserClicked()
        {
            return 0;
        }

        //private void SetDataToInstance(User user)
        //{
        //    user.Nombre = Name;
        //    user.Apellido = LastName;
        //    user.Direccion = Address;
        //    user.Correo = Mail;
        //    user.Telefono = Telephone;
        //    user.Usuario = User;
        //    user.Contrasena = Password;
        //    user.UrlFoto = UrlPhoto;
        //}

        //private bool IsChange()
        //{
        //    if (UserInCache.Nombre.Equals(Name) && UserInCache.Telefono.Equals(Telephone) && UserInCache.Usuario.Equals(User)
        //        && UserInCache.Contrasena.Equals(Password) && UserInCache.Correo.Equals(Mail) && lastMethodVerify == VerifyByMail &&
        //        UserInCache.UrlFoto.Equals(UrlPhoto))
        //        return false;
        //    else
        //        return true;
        //}

    }
}

