using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOphelia2.Models
{
    public class VentaRequest
    {
        public int IdVenta { get; set; }
        public int? IdCliente { get; set; }
        public int? IdProducto { get; set; }
        public int? cantidad { get; set; }

        public List<Concepto> Conceptos { get; set; }

        public VentaRequest()
        {
            this.Conceptos = new List<Concepto>();
        }
    }

    public class Concepto
    {
        public int total { get; set; }
    }
}
