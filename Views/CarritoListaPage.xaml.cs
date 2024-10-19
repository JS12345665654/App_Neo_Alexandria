using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class CarritoListaPage : ContentPage
{
    public CarritoListaPage()
    {
        ApiService service = new ApiService();
        CarritoListaViewModel vm = new CarritoListaViewModel();
        InitializeComponent();
        this.BindingContext = vm;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var vm = BindingContext as CarritoListaViewModel;

        if (vm != null)
        {
            await vm.ObtenerTodosCarritosCommand.ExecuteAsync(null);
        }
    }
}