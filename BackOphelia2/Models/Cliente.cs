using System;
using System.Collections.Generic;

#nullable disable

namespace BackOphelia2.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
            Venta = new HashSet<Venta>();
        }

        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? Telefono { get; set; }
        public int? Edad { get; set; }
        public string Correo { get; set; }

        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
