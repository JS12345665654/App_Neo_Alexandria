using AppFakeStore.ViewModels;
using AppFakeStore.Views;
using AppFakeStore.Utils;
using AppFakeStore.Models;
using AppFakeStore;
using Microsoft.Extensions.Logging;

namespace AppFakeStore
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialDesignIcons");
                });

           //Inicializadores 'Singleton de la clase "Api- Service" '
            builder.Services.AddSingleton<ApiService>();
        
            //Inicializamos todas las partes de cada sección

            //Sección Login
            builder.Services.AddTransient<LoginViewModel>();

            //Sección Productos
            builder.Services.AddTransient<ProductoListaViewModel>();
            builder.Services.AddTransient<ProductoDetalleViewModel>();
            builder.Services.AddTransient<ProductoAgregarViewModel>();
            builder.Services.AddTransient<ProductoModificarViewModel>();
            builder.Services.AddTransient<ProductoEliminarViewModel>();

            //Sección usuarios
            builder.Services.AddTransient<UsuarioListaViewModel>();
            builder.Services.AddTransient<UsuarioDetalleViewModel>();
            builder.Services.AddTransient<UsuarioAgregarViewModel>();
            builder.Services.AddTransient<UsuarioModificarViewModel>();
            builder.Services.AddTransient<UsuarioEliminarViewModel>();

            //Sección carrito
            builder.Services.AddTransient<CarritoListaViewModel>();
            builder.Services.AddTransient<CarritoAgregarViewModel>();
            builder.Services.AddTransient<CarritoModificarViewModel>();
            builder.Services.AddTransient<CarritoEliminarViewModel>();

            //Sección detalle carrito
            builder.Services.AddTransient<CarritoDetalleViewModel>();
            builder.Services.AddTransient<CarritoDetalleAgregarViewModel>();
            builder.Services.AddTransient<CarritoDetalleModificarViewModel>();
            builder.Services.AddTransient<CarritoDetalleEliminarViewModel>();



            //Sección Login
            builder.Services.AddTransient<LoginPage>();

            //Sección Productos
            builder.Services.AddTransient<ProductoListaPage>();
            builder.Services.AddTransient<ProductoDetallePage>();
            builder.Services.AddTransient<ProductoAgregarPage>();
            builder.Services.AddTransient<ProductoModificarPage>();
            builder.Services.AddTransient<ProductoEliminarPage>();

            //Sección Usuarios
            builder.Services.AddTransient<UsuarioListaPage>();
            builder.Services.AddTransient<UsuarioDetallePage>();
            builder.Services.AddTransient<UsuarioAgregarPage>();
            builder.Services.AddTransient<UsuarioModificarPage>();
            builder.Services.AddTransient<UsuarioEliminarPage>();

            //Sección Carrito
            builder.Services.AddTransient<CarritoListaPage>();
            builder.Services.AddTransient<CarritoAgregarPage>();
            builder.Services.AddTransient<CarritoModificarPage>();
            builder.Services.AddTransient<CarritoEliminarPage>();


            //Sección Carrito Detalle
            builder.Services.AddTransient<CarritoDetallePage>();
            builder.Services.AddTransient<CarritoDetalleAgregarPage>();
            builder.Services.AddTransient<CarritoDetalleModificarPage>();
            builder.Services.AddTransient<CarritoDetalleEliminarPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}