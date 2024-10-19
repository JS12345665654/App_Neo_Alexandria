using CommunityToolkit.Mvvm.Input;
using AppFakeStore.Utils;
using AppFakeStore.ViewModels;
using AppFakeStore;

namespace AppFakeStore.ViewModels;

public partial class ProductoModificarViewModel : BaseViewModel
{
    public ProductoModificarViewModel()
    {
        Title = Constants.AppName;
    }

    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task ModificarProducto()
    {
        await Application.Current.MainPage.DisplayAlert("Producto", "Producto modificado", "Aceptar");
    }
}
