using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class CarritoEliminarPage : ContentPage
{
    CarritoEliminarViewModel ViewModels;
    public CarritoEliminarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new CarritoEliminarViewModel();
    }
}