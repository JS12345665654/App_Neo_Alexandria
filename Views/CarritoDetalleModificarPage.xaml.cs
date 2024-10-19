using AppFakeStore.ViewModels;
namespace AppFakeStore.Views;

public partial class CarritoDetalleModificarPage : ContentPage
{
    private CarritoDetalleModificarViewModel ViewModels;
    public CarritoDetalleModificarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new CarritoDetalleModificarViewModel();
    }
}