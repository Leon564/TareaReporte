using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TareaReporte.Models
{
    public class Venta
    {
        public int VentaId { get; set; }
        public string FechaVenta { get; set; }
        public virtual List<Producto> Producto { get; set; }
        public Cliente Cliente { get; set; }
    }
}