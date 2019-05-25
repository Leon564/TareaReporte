using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TareaReporte.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal precio { get; set; }
        public string Categoria { get; set; }
        public int Existencias { get; set; }
    }
}