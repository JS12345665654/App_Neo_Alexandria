﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore.Models
{
    public class Carrito
    {
        public int IdCarrito { get; set; }

        [ForeignKey("Productos")]
        public int? IdProductos { get; set; }

        [ForeignKey("Usuarios")]
        public int? IdUsuario { get; set; }

        public decimal PrecioTotalCarrito { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? Descripcion { get; set; }

    }
}
