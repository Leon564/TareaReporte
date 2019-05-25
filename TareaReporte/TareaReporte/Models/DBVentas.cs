using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TareaReporte.Models
{
    public class DBVentas:DbContext
    {
        //DbSet<Producto> Productos { get; set; }
        DbSet<Venta> Ventas { get; set; }
        DbSet<Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<TareaReporte.Models.Producto> Productoes { get; set; }
    }
}