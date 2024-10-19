using AppFakeStore.Models;
using AppFakeStore.Views;
using AppFakeStore.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using AppFakeStore;
using System.Text.Json;

namespace AppFakeStore.ViewModels;

public partial class CarritoListaViewModel : BaseViewModel 
{

    [ObservableProperty] private ObservableCollection<Carrito> carrito;
    [ObservableProperty] private DetalleCarrito carritoSeleccionado;
    [ObservableProperty] private bool isRefreshing;

    public CarritoListaViewModel()
    {
        Title = Constants.AppName;

        Task.Run(async () => { await ObtenerTodosCarritos(); }).Wait();
    }

    [RelayCommand]
    private async Task ObtenerTodosCarritos()
    {
        IsBusy = IsRefreshing = true;

        var carrito = await ApiService.ObtenerTodosCarritos();

        if (carrito != null)
        {
            Carrito = new ObservableCollection<Carrito>(carrito);
        }

        IsBusy = IsRefreshing = false;
    }

    [RelayCommand]
    private async Task GoToDetalleCarrito()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CarritoDetallePage(carritoSeleccionado));
    }
    [RelayCommand]
    public async Task GoToCrearCarrito()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CarritoAgregarPage());
    }
    [RelayCommand]
    public async Task GoToModificarCarrito()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CarritoModificarPage());
    }

    [RelayCommand]
    public async Task GoToEliminarCarrito()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CarritoEliminarPage());
    }
}
