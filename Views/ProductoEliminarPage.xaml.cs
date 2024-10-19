using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class ProductoEliminarPage : ContentPage
{
    ProductoEliminarViewModel ViewModels;
    public ProductoEliminarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new ProductoEliminarViewModel();
    }
}