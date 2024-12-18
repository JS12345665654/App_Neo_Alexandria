using AppFakeStore.Models;
using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class ProductoDetallePage : ContentPage
{
	public ProductoDetallePage(Producto producto)
	{
		InitializeComponent();

		ProductoDetalleViewModel vm = new ProductoDetalleViewModel();
		this.BindingContext = vm;		
		vm.Producto = producto;
	}
}