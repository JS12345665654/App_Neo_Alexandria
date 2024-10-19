using AppFakeStore.ViewModels;
namespace AppFakeStore.Views;

public partial class ProductoModificarPage : ContentPage
{
    private ProductoModificarViewModel ViewModels;
    public ProductoModificarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new ProductoModificarViewModel();
    }
}