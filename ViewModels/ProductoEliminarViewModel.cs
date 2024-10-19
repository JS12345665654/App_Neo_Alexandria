using AppFakeStore.Models;
using AppFakeStore.Utils;
using AppFakeStore;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class ProductoEliminarViewModel : BaseViewModel
{
   [ObservableProperty] private int _IdProductos;

    public ProductoEliminarViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task EliminarProducto()
    {
        try
        {
            var elimino = await ApiService.EliminarProducto(_IdProductos);

            if (elimino)
            {
                await Application.Current.MainPage.DisplayAlert("Éxito", "Producto eliminado correctamente.", "Aceptar");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No se pudo eliminar el producto.", "Aceptar");
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
