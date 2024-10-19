using AppFakeStore.Models;
using AppFakeStore.Utils;
using AppFakeStore;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class UsuarioEliminarViewModel : BaseViewModel
{
    [ObservableProperty] private int _IdUsuario;

    public UsuarioEliminarViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task EliminarUsuario()
    {
        try
        {
            var eliminousuario = await ApiService.BorrarUsuario(_IdUsuario); 

            if (eliminousuario)
            {
                await Application.Current.MainPage.DisplayAlert("Éxito", "Usuario eliminado correctamente.", "Aceptar");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No se pudo eliminar el usuario.", "Aceptar");
            }
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Error", $"ERROR al eliminar: {ex.Message}", "Aceptar");
        }

        // Regresar a la pantalla anterior
        await Application.Current.MainPage.Navigation.PopAsync();
    }
}
