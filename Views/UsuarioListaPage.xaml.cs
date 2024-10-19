using AppFakeStore;
using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class UsuarioListaPage : ContentPage
{
    public UsuarioListaPage()
    {
        ApiService service = new ApiService();
        UsuarioListaViewModel vm = new UsuarioListaViewModel();
        InitializeComponent();
        this.BindingContext = vm;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var vm = BindingContext as UsuarioListaViewModel;

        if (vm != null)
        {
            await vm.ObtenerTodosUsuariosCommand.ExecuteAsync(null);
        }
    }
}