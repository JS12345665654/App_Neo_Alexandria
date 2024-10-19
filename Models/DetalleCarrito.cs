using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore.Models
{
    public class DetalleCarrito
    {
        public int IdDetalleCarrito { get; set; }
        public decimal PrecioTotalDetalleCarrito { get; set; }

        [ForeignKey("Carrito")]
        public int IdCarrito { get; set; }
        public DateTime FechaFactura { get; set; }
        public string? DetalleFactura { get; set; }
        public DateTime FechaCreacionFactura { get; set; }

    }
}
