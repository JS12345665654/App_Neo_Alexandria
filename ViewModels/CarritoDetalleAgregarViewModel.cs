using AppFakeStore.Models;
using AppFakeStore.ViewModels;
using AppFakeStore.Utils;
using AppFakeStore;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AppFakeStore.ViewModels;

public partial class CarritoDetalleAgregarViewModel : BaseViewModel
{
    [ObservableProperty] private string _DetalleFactura;
    [ObservableProperty] private DateTime _FechaFactura;
    [ObservableProperty] private DateTime _FechaCreacionFactura;
    [ObservableProperty] private int _IdCarrito;
    [ObservableProperty] private decimal _PrecioTotalDetalleCarrito;

    public CarritoDetalleAgregarViewModel()
    {
        Title = Constants.AppName;
    }


    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task CrearDetalleCarrito()
    {


        var detallecarrito = new DetalleCarrito
        {
            FechaCreacionFactura = this._FechaCreacionFactura,
            FechaFactura = this._FechaFactura,
            DetalleFactura = this._DetalleFactura,
            PrecioTotalDetalleCarrito = Convert.ToDecimal(this._PrecioTotalDetalleCarrito),
            IdCarrito = this._IdCarrito
        };


        try
        {
            await ApiService.CrearDetalleCarrito(detallecarrito);

            await Application.Current.MainPage.DisplayAlert("Exito", "Se nuevo agrego un nuevo detalle de carrito.", "Aceptar");
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Error", "ERROR al grabar.", "Aceptar");
        }

        await Application.Current.MainPage.Navigation.PopAsync();


    }
}