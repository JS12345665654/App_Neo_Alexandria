using AppFakeStore.Models;
using AppFakeStore.ViewModels;
using AppFakeStore.Views;
using AppFakeStore.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using AppFakeStore;
using System.Text.Json;

namespace AppFakeStore.ViewModels;

public partial class UsuarioListaViewModel : BaseViewModel
{

    [ObservableProperty] private ObservableCollection<Usuario> usuario;
    [ObservableProperty] private Usuario usuarioSeleccionado;
    [ObservableProperty] public bool _IsRefreshing;

    public UsuarioListaViewModel()
    {
        Title = Constants.AppName;

        Task.Run(async () => { await ObtenerTodosUsuarios(); }).Wait();
    }

    [RelayCommand]
    private async Task ObtenerTodosUsuarios()
    {
        IsBusy = _IsRefreshing = true;

        var usuario = await ApiService.ObtenerTodosUsuarios();

        if (usuario != null)
        {
            Usuario = new ObservableCollection<Usuario>(usuario);
        }

        IsBusy = _IsRefreshing = false;
    }

    [RelayCommand]
    private async Task GoToDetalleUsuario()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new UsuarioDetallePage(usuarioSeleccionado));
    }


    [RelayCommand]
    public async Task GoToCrearUsuario()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new UsuarioAgregarPage());
    }

    [RelayCommand]
    public async Task GoToModificarUsuario()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new UsuarioModificarPage());
    }

    [RelayCommand]
    public async Task GoToEliminarUsuario()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new UsuarioEliminarPage());
    }

    [RelayCommand]
    private async Task NuevoUsuario()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new UsuarioAgregarPage());
    }
}
