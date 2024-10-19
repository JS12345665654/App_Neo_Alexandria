using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class CarritoDetalleAgregarPage : ContentPage
{
    CarritoDetalleAgregarViewModel ViewModels;
    public CarritoDetalleAgregarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new CarritoDetalleAgregarViewModel();
    }
}