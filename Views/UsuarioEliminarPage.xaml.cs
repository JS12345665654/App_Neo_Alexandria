using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class UsuarioEliminarPage : ContentPage
{
    UsuarioEliminarViewModel ViewModels;
    public UsuarioEliminarPage()
    {
        InitializeComponent();
        BindingContext = ViewModels = new UsuarioEliminarViewModel();
    }
}