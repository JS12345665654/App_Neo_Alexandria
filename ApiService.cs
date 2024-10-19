using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Net.Http;
using AppFakeStore.Utils;
using AppFakeStore.ViewModels;
using AppFakeStore.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AppFakeStore
{
    public class ApiService
    {
        private static readonly string BASE_URL = "https://localhost:7028/api/";
        static HttpClient httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(60) };

        // API Service - Producto
        public static async Task<List<Producto>> ObtenerTodosProductos()
        {
            string FINAL_URL = BASE_URL + "Productos";

            try
            {
                var response = await httpClient.GetAsync(FINAL_URL);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        // Inside the ApiService class
                        var responseObject = JsonSerializer.Deserialize<List<Producto>>(jsonData,
                            new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                WriteIndented = true
                            });
                        return responseObject!;
                    }
                    else
                    {
                        Exception exception = new Exception("Resource Not Found");
                        throw new Exception(exception.Message);
                    }
                }
                else
                {
                    Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                    throw new Exception(exception.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static async Task<bool> CrearProducto(Producto crearProducto)
        {
            string FINAL_URL = BASE_URL + "Productos";
            try
            {
                var content = new StringContent(
                        JsonSerializer.Serialize(crearProducto),
                        Encoding.UTF8, "application/json"
                    );

                var result = await httpClient.PostAsync(FINAL_URL, content).ConfigureAwait(false);



                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<List<Producto>> ObtenerProductoPorId(int IdProductos)
        {

            string URL = "https://localhost:7028/api/Productos/ObtenerPorId/" + IdProductos;

            try
            {
                var response = await httpClient.GetAsync(URL);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        // Inside the ApiService class
                        var responseObject = JsonSerializer.Deserialize<List<Producto>>(jsonData,
                            new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                WriteIndented = true
                            });
                        return responseObject!;
                    }
                    else
                    {
                        Exception exception = new Exception("Resource Not Found");
                        throw new Exception(exception.Message);
                    }
                }
                else
                {
                    Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                    throw new Exception(exception.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static async Task<bool> ModificarProducto(Producto producto)
        {
            string FINAL_URL = BASE_URL + "Productos/" + producto.IdProductos;
                try
            {
                var content = new StringContent(
                        JsonSerializer.Serialize(producto),
                        Encoding.UTF8, "application/json"
                    );

                var result = await httpClient.PutAsync(FINAL_URL, content).ConfigureAwait(false);

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<bool> EliminarProducto (int IdProductos)
        {
            string FINAL_URL = BASE_URL + "Productos/" + IdProductos; 
            try
            {
                var result = await httpClient.DeleteAsync(FINAL_URL).ConfigureAwait(false);

                if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //API Service - Usuarios
        public static async Task<List<Usuario>> ObtenerTodosUsuarios()
        {
            string FINAL_URL = BASE_URL + "Usuarios";

            try
            {
                var response = await httpClient.GetAsync(FINAL_URL);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        // Inside the ApiService class
                        var responseObject = JsonSerializer.Deserialize<List<Usuario>>(jsonData,
                            new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                WriteIndented = true
                            });
                        return responseObject!;
                    }
                    else
                    {
                        Exception exception = new Exception("Resource Not Found");
                        throw new Exception(exception.Message);
                    }
                }
                else
                {
                    Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                    throw new Exception(exception.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static async Task<bool> CrearUsuarios(Usuario _usuario)
        {
            string FINAL_URL = BASE_URL + "Usuarios";
            try
            {
                var content = new StringContent(
                        JsonSerializer.Serialize(_usuario),
                        Encoding.UTF8, "application/json"
                    );

                var result = await httpClient.PostAsync(FINAL_URL, content).ConfigureAwait(false);



                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<List<Usuario>> ObtenerUsuariosPorId(int IdUsuario)
        {

            string URL = "https://localhost:7028/api/Usuarios/ObtenerPorId/" + IdUsuario;

            try
            {
                var response = await httpClient.GetAsync(URL);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        // Inside the ApiService class
                        var responseObject = JsonSerializer.Deserialize<List<Usuario>>(jsonData,
                            new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                WriteIndented = true
                            });
                        return responseObject!;
                    }
                    else
                    {
                        Exception exception = new Exception("Resource Not Found");
                        throw new Exception(exception.Message);
                    }
                }
                else
                {
                    Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                    throw new Exception(exception.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static async Task<bool> ModificarUsuario(Usuario usuario)
        {
            string FINAL_URL = BASE_URL + "Usuarios/" + usuario.IdUsuario;
            try
            {
                var content = new StringContent(
                        JsonSerializer.Serialize(usuario),
                        Encoding.UTF8, "application/json"
                    );

                var result = await httpClient.PutAsync(FINAL_URL, content).ConfigureAwait(false);

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<bool> BorrarUsuario(int IdUsuario)
        {
            string FINAL_URL = BASE_URL + "Usuarios/" + IdUsuario; 
            try
            {
                var result = await httpClient.DeleteAsync(FINAL_URL).ConfigureAwait(false);

                if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //API Service - Carrito
        public static async Task<List<Carrito>> ObtenerTodosCarritos()
        {
            string FINAL_URL = BASE_URL + "Carrito";

            try
            {
                var response = await httpClient.GetAsync(FINAL_URL);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        // Inside the ApiService class
                        var responseObject = JsonSerializer.Deserialize<List<Carrito>>(jsonData,
                            new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                WriteIndented = true
                            });
                        return responseObject!;
                    }
                    else
                    {
                        Exception exception = new Exception("Resource Not Found");
                        throw new Exception(exception.Message);
                    }
                }
                else
                {
                    Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                    throw new Exception(exception.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static async Task<bool> CrearCarritos(Carrito carrito)
        {
            string FINAL_URL = BASE_URL + "Carrito";
            try
            {
                var content = new StringContent(
                        JsonSerializer.Serialize(carrito),
                        Encoding.UTF8, "application/json"
                    );

                var result = await httpClient.PostAsync(FINAL_URL, content).ConfigureAwait(false);



                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<List<Carrito>> ObtenerCarritosPorId(int IdCarrito)
        {

            string URL = "https://localhost:7028/api/Carrito/ObtenerPorId/" + IdCarrito;

            try
            {
                var response = await httpClient.GetAsync(URL);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        // Inside the ApiService class
                        var responseObject = JsonSerializer.Deserialize<List<Carrito>>(jsonData,
                            new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                WriteIndented = true
                            });
                        return responseObject!;
                    }
                    else
                    {
                        Exception exception = new Exception("Resource Not Found");
                        throw new Exception(exception.Message);
                    }
                }
                else
                {
                    Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                    throw new Exception(exception.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static async Task<bool> ModificarCarrito(Carrito carrito)
        {
            string FINAL_URL = BASE_URL + "Carrito/" + carrito.IdCarrito;
            try
            {
                var content = new StringContent(
                        JsonSerializer.Serialize(carrito),
                        Encoding.UTF8, "application/json"
                    );

                var result = await httpClient.PutAsync(FINAL_URL, content).ConfigureAwait(false);

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<bool> BorrarCarrito(int IdCarrito)
        {
            string FINAL_URL = BASE_URL + "Carrito/" + IdCarrito;
            try
            {
                var result = await httpClient.DeleteAsync(FINAL_URL).ConfigureAwait(false);

                if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // API Service - Detalle Carrito
        public static async Task<List<DetalleCarrito>> ObtenerDetalleCarritos()
        {
            string FINAL_URL = BASE_URL + "CarritoDetalle";

            try
            {
                var response = await httpClient.GetAsync(FINAL_URL);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        // Inside the ApiService class
                        var responseObject = JsonSerializer.Deserialize<List<DetalleCarrito>>(jsonData,
                            new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                WriteIndented = true
                            });
                        return responseObject!;
                    }
                    else
                    {
                        Exception exception = new Exception("Resource Not Found");
                        throw new Exception(exception.Message);
                    }
                }
                else
                {
                    Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                    throw new Exception(exception.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static async Task<bool> CrearDetalleCarrito(DetalleCarrito detallecarrito)
        {
            string FINAL_URL = BASE_URL + "CarritoDetalle";
            try
            {
                var content = new StringContent(
                        JsonSerializer.Serialize(detallecarrito),
                        Encoding.UTF8, "application/json"
                    );

                var result = await httpClient.PostAsync(FINAL_URL, content).ConfigureAwait(false);



                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<List<DetalleCarrito>> ObtenerDetalleCarritoPorId(int IdDetalleCarrito)
        {

            string URL = "https://localhost:7028/api/CarritoDetalle/ObtenerPorId/" + IdDetalleCarrito;

            try
            {
                var response = await httpClient.GetAsync(URL);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        // Inside the ApiService class
                        var responseObject = JsonSerializer.Deserialize<List<DetalleCarrito>>(jsonData,
                            new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                WriteIndented = true
                            });
                        return responseObject!;
                    }
                    else
                    {
                        Exception exception = new Exception("Resource Not Found");
                        throw new Exception(exception.Message);
                    }
                }
                else
                {
                    Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                    throw new Exception(exception.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public static async Task<bool> ModificarDetalleCarrito(DetalleCarrito detallecarrito)
        {
            string FINAL_URL = BASE_URL + "Detalle/" + detallecarrito.IdDetalleCarrito;
            try
            {
                var content = new StringContent(
                        JsonSerializer.Serialize(detallecarrito),
                        Encoding.UTF8, "application/json"
                    );

                var result = await httpClient.PutAsync(FINAL_URL, content).ConfigureAwait(false);

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<bool> BorrarDetalleCarrito(int IdDetalleCarrito)
        {
            string FINAL_URL = BASE_URL + "Carrito/" + IdDetalleCarrito;
            try
            {
                var result = await httpClient.DeleteAsync(FINAL_URL).ConfigureAwait(false);

                if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // API Service - Login
        public async Task<LoginResponseDto> ValidarLogin(string _email, string _contrasenia)
        {
            string FINAL_URL = BASE_URL + "usuarios/ValidarCredencial";
            try
            {
                var content = new StringContent(
                        //JsonConvert.SerializeObject(
                        JsonSerializer.Serialize(
                            new
                            {
                                email = _email,
                                contrasenia = _contrasenia,

                            }),
                            Encoding.UTF8, "application/json"
                );

                var result = await httpClient.PostAsync(FINAL_URL, content).ConfigureAwait(false);

                var jsonData = await result.Content.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(jsonData))
                {
                    // Inside the ApiService class
                    var responseObject = JsonSerializer.Deserialize<LoginResponseDto>(jsonData,
                        new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                            WriteIndented = true
                        });
                    return responseObject!;
                }
                else
                {
                    Exception exception = new Exception("Resource Not Found");
                    throw new Exception(exception.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
