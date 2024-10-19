using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class ProductoListaPage : ContentPage
{
	public ProductoListaPage()
	{
		ApiService service = new ApiService();
		ProductoListaViewModel vm = new ProductoListaViewModel();
		InitializeComponent();
		this.BindingContext = vm;
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();

		var vm = BindingContext as ProductoListaViewModel;

		if (vm != null)
		{
			await vm.ObtenerTodosProductosCommand.ExecuteAsync(null);
		}
	}
}