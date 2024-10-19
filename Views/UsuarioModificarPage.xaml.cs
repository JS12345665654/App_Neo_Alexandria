using AppFakeStore.ViewModels;
namespace AppFakeStore.Views;

public partial class UsuarioModificarPage : ContentPage
{
    private UsuarioModificarViewModel ViewModels;
    public UsuarioModificarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new UsuarioModificarViewModel();
    }
}