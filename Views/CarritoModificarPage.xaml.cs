using AppFakeStore.ViewModels;
namespace AppFakeStore.Views;

public partial class CarritoModificarPage : ContentPage
{
    private CarritoModificarViewModel ViewModels;
    public CarritoModificarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new CarritoModificarViewModel();
    }
}