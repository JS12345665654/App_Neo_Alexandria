using AppFakeStore.Models;
using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class UsuarioDetallePage : ContentPage
{
    public UsuarioDetallePage(Usuario usuario)
    {
        InitializeComponent();

        UsuarioDetalleViewModel vm = new UsuarioDetalleViewModel();
        this.BindingContext = vm;
        vm.Usuario = usuario;
    }
}