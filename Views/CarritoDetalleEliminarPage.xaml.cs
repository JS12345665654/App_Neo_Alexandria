using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class CarritoDetalleEliminarPage : ContentPage
{
    CarritoDetalleEliminarViewModel ViewModels;
    public CarritoDetalleEliminarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new CarritoDetalleEliminarViewModel();
    }
}