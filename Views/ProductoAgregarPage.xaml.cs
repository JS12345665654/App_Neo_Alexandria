using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class ProductoAgregarPage : ContentPage
{
    ProductoAgregarViewModel ViewModels;
    public ProductoAgregarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new ProductoAgregarViewModel();
    }
}