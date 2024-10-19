using AppFakeStore.Models;
using AppFakeStore.ViewModels;
using AppFakeStore.Utils;
using AppFakeStore;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AppFakeStore.ViewModels;

public partial class UsuarioAgregarViewModel : BaseViewModel
{
    [ObservableProperty] private string _Nombre;
    [ObservableProperty] private string _Email;
    [ObservableProperty] private string _Contrasenia;
    [ObservableProperty] private int _IdRol;
    [ObservableProperty] private bool _Activo;
    [ObservableProperty] private string _CategoriaPreferida;
    [ObservableProperty] private string _Imagen;
    public UsuarioAgregarViewModel()
    {
        Title = Constants.AppName;
    }


    [RelayCommand]
    private async Task Cancelar()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task CrearUsuarios()
    {


        var registro = new Usuario
        {
            Nombre = this._Nombre,
            Email = this._Email,
            Contrasenia = this._Contrasenia,
            IdRol = Convert.ToInt32(this._IdRol),
            Activo = this._Activo,
            CategoriaPreferida = this._CategoriaPreferida,
            Imagen = "producto.png"
        };


        try
        {
            await ApiService.CrearUsuarios(registro);

            await Application.Current.MainPage.DisplayAlert("Exito", "Se nuevo agrego un nuevo Usuario.", "Aceptar");
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Error", "ERROR al grabar.", "Aceptar");
        }

        await Application.Current.MainPage.Navigation.PopAsync();


    }

}