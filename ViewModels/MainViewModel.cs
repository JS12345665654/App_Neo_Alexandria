using AppFakeStore.Views;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
        Title = "App Neo Alexandría";
    }

    [RelayCommand]
    public async Task GoToProductoLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage());
    }

    [RelayCommand]
    public async Task GoToUsuarioLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new UsuarioListaPage());
    }

    [RelayCommand]
    public async Task GoToAcerca()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AcercaPage());
    }

    [RelayCommand]
    public async Task GoToCarritoLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CarritoListaPage());
    }

    [RelayCommand]
    public async Task Exit()
    {
        bool answer = await Application.Current.MainPage.DisplayAlert("Salir", "¿Desea terminar la sesión y salir?", "Aceptar", "Cancelar");
        await Application.Current.MainPage.Navigation.PopToRootAsync();
        await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new LoginPage()));
    }
}
