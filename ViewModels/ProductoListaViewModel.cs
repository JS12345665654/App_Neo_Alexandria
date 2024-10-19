using AppFakeStore.Models;
using AppFakeStore.ViewModels;
using AppFakeStore.Views;
using AppFakeStore.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using AppFakeStore;
using System.Text.Json;

namespace AppFakeStore.ViewModels;

public partial class ProductoListaViewModel : BaseViewModel
{

    [ObservableProperty] private ObservableCollection<Producto> producto;
    [ObservableProperty] private Producto productoSeleccionado;
    [ObservableProperty] private bool isRefreshing;

    public ProductoListaViewModel()
    {
        Title = Constants.AppName;

        Task.Run(async () => { await ObtenerTodosProductos(); }).Wait();
    }

    [RelayCommand]
    private async Task ObtenerTodosProductos()
    {
        IsBusy = IsRefreshing = true;

        var producto = await ApiService.ObtenerTodosProductos();

        if (producto != null)
        {
            Producto = new ObservableCollection<Producto>(producto);
        }

        IsBusy = IsRefreshing = false;
    }

    [RelayCommand]
    private async Task GoToDetalleProductos()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoDetallePage(productoSeleccionado));
    }

    [RelayCommand]
    public async Task GoToCrearProducto()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoAgregarPage());
    }

    [RelayCommand]
    public async Task GoToModificarProducto()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoModificarPage());
    }

    [RelayCommand]
    public async Task GoToEliminarProducto()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoEliminarPage());
    }

    [RelayCommand]
    private async Task NuevoProducto()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoAgregarPage());
    }
}
