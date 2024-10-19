using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class CarritoAgregarPage : ContentPage
{
    CarritoAgregarViewModel ViewModels;
    public CarritoAgregarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new CarritoAgregarViewModel();
    }
}