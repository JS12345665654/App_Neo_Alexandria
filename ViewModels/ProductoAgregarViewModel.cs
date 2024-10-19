using AppFakeStore.Models;
using AppFakeStore.ViewModels;
using AppFakeStore.Utils;
using AppFakeStore;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AppFakeStore.ViewModels;

public partial class ProductoAgregarViewModel : BaseViewModel
{
    [ObservableProperty] private string _nombre;
    [ObservableProperty] private string _descripcion;
    [ObservableProperty] private int _stock;
    [ObservableProperty] private decimal _precio;

    public ProductoAgregarViewModel()
    {
        Title = Constants.AppName;
    }


    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task Crear()
    {


        var producto = new Producto
        {
            Nombre = this.Nombre,
            Descripcion = this.Descripcion,
            Stock = this.Stock,
            Precio = Convert.ToDecimal(this.Precio),
            Imagen = "producto.png"
        };


        try
        {
            await ApiService.CrearProducto(producto);

            await Application.Current.MainPage.DisplayAlert("Exito", "Se nuevo agrego un nuevo Producto.", "Aceptar");
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Error", "ERROR al grabar.", "Aceptar");
        }

        await Application.Current.MainPage.Navigation.PopAsync();


    }

}