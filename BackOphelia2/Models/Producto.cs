using System;
using System.Collections.Generic;

#nullable disable

namespace BackOphelia2.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int? PrecioUnitario { get; set; }
        public int? Cantidad { get; set; }

        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
