using AppFakeStore.Models;
using AppFakeStore.Utils;
using AppFakeStore;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class CarritoEliminarViewModel : BaseViewModel
{
    [ObservableProperty] private int _IdCarrito;

    public CarritoEliminarViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task BorrarCarrito()
    {
        try
        {
            var elimino = await ApiService.BorrarCarrito(_IdCarrito);

            if (elimino)
            {
                await Application.Current.MainPage.DisplayAlert("Éxito", "Carrito eliminado correctamente.", "Aceptar");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No se pudo eliminar el carrito.", "Aceptar");
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
