using AppFakeStore.Models;
using AppFakeStore.ViewModels;
using AppFakeStore.Utils;
using AppFakeStore;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AppFakeStore.ViewModels;

public partial class CarritoAgregarViewModel : BaseViewModel
{
    [ObservableProperty] private int _IdProductos;
    [ObservableProperty] private int _IdUsuario;
    [ObservableProperty] private string _Descripcion;
    [ObservableProperty] private DateTime _FechaCreacion;
    [ObservableProperty] private decimal _PrecioTotalCarrito;

    public CarritoAgregarViewModel()
    {
        Title = Constants.AppName;
    }


    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task CrearCarritos()
    {


        var carrito = new Carrito
        {
            IdProductos = this.IdProductos,
            Descripcion = this.Descripcion,
            FechaCreacion = this.FechaCreacion,
            IdUsuario = this.IdUsuario,
            PrecioTotalCarrito =  Convert.ToDecimal(this.PrecioTotalCarrito)
        };


        try
        {
            await ApiService.CrearCarritos(carrito);

            await Application.Current.MainPage.DisplayAlert("Exito", "Se nuevo agrego un nuevo Carrito.", "Aceptar");
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Error", "ERROR al grabar.", "Aceptar");
        }

        await Application.Current.MainPage.Navigation.PopAsync();


    }

}