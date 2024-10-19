using CommunityToolkit.Mvvm.Input;
using AppFakeStore.Utils;
using AppFakeStore.ViewModels;
using AppFakeStore;

namespace AppFakeStore.ViewModels;

public partial class CarritoDetalleModificarViewModel : BaseViewModel
{
    public CarritoDetalleModificarViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task ModificarDetalleCarrito()
    {
        await Application.Current.MainPage.DisplayAlert("Carrito Detalle", "Carrito Detalle modificado", "Aceptar");
    }
}
