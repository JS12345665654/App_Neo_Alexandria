using CommunityToolkit.Mvvm.Input;
using AppFakeStore.Utils;
using AppFakeStore.ViewModels;
using AppFakeStore;

namespace AppFakeStore.ViewModels;

public partial class CarritoModificarViewModel : BaseViewModel
{
    public CarritoModificarViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task ModificarCarrito()
    {
        await Application.Current.MainPage.DisplayAlert("Carrito", "Carrito modificado", "Aceptar");
    }
}
