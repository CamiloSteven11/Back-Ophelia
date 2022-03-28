using System;
using System.Collections.Generic;

#nullable disable

namespace BackOphelia2.Models
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        public int IdVenta { get; set; }
        public int? IdCliente { get; set; }
        public int? IdProducto { get; set; }
        public int? cantidad { get; set; }

        public DateTime FechaVenta { get; set; }
        public int? Total { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
