using AppFakeStore.Models;
using AppFakeStore.ViewModels;
using AppFakeStore.Views;
using AppFakeStore.Utils;
using AppFakeStore;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Shapes;

namespace AppFakeStore.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
    public LoginViewModel()
    {
        Title = Constants.AppName;
    }

     [ObservableProperty] public string _Email = string.Empty;
     [ObservableProperty] public string _Contrasenia = string.Empty;
     [ObservableProperty] public string message = string.Empty;

    [RelayCommand]
    public async Task LoginAsync2()
    {

        await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
    }

    [RelayCommand]
    public async Task LoginAsync()
    {
        if (!IsBusy)
        {
            IsBusy = true;

            // asignamos objeto con datos del usuario-establecimiento logueados
            if (Email != string.Empty && Contrasenia != String.Empty)
            {
                var apiClient = new ApiService();

                LoginResponseDto login = await apiClient.ValidarLogin(Email, Contrasenia);



                if (login != null)
                {
                    Application.Current.MainPage = new NavigationPage(new MainPage());

                    // TODO: recuperar datos de usuario login
                    Transport.IdUsuario = login.IdUsuario;
                    Transport.IdRol = login.IdRol;
                    Transport.Email= login.Email;
                    Transport.Nombre = login.Nombre;

                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Atención", "Las credenciales ingresadas no son válidas", "Aceptar");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Atención", "Las credenciales son Obligatorias. Verifique!", "Aceptar");
            }

            IsBusy = false;
        }

    }
}