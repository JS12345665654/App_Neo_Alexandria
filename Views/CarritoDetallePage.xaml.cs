using AppFakeStore.Models;
using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class CarritoDetallePage : ContentPage
{
    public CarritoDetallePage(DetalleCarrito detalleCarrito)
    {
        InitializeComponent();

        CarritoDetalleViewModel vm = new CarritoDetalleViewModel();
        this.BindingContext = vm;
        vm.DetalleCarrito = detalleCarrito;
    }
}