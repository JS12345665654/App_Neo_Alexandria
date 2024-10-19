using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public int IdRol { get; set; }
        public bool Activo { get; set; }
        public string? Imagen { get; set; }
        public string? CategoriaPreferida { get; set; }
    }
}
