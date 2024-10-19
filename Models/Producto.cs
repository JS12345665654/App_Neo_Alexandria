using System.ComponentModel.DataAnnotations;

namespace AppFakeStore.Models;

public class Producto
{
    [Key]
    public int IdProductos { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string? Imagen { get; set; }
}
