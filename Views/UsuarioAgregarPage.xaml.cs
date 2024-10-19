using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class UsuarioAgregarPage : ContentPage
{
    UsuarioAgregarViewModel ViewModels;
    public UsuarioAgregarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new UsuarioAgregarViewModel();
    }
}