using AppFakeStore.Models;
using AppFakeStore.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class CarritoDetalleViewModel : BaseViewModel
{
    [ObservableProperty] DetalleCarrito detalleCarrito;

    public CarritoDetalleViewModel()
    {
        Title = "Detalle Carrito";
    }

    [RelayCommand]
    private async Task GoBack()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }


}
