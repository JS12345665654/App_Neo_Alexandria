using CommunityToolkit.Mvvm.Input;
using AppFakeStore.Utils;
using AppFakeStore.ViewModels;
using AppFakeStore;

namespace AppFakeStore.ViewModels;

public partial class UsuarioModificarViewModel : BaseViewModel
{
    public UsuarioModificarViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task ModificarUsuario()
    {
        await Application.Current.MainPage.DisplayAlert("Usuario", "Usuario modificado", "Aceptar");
    }
}
