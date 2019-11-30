using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewTms.Models
{
    public class TmsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TmsContext() : base("name=TmsContext")
        {
        }

        public System.Data.Entity.DbSet<NewTms.Models.ClienteVM> ClienteVMs { get; set; }

        public System.Data.Entity.DbSet<NewTms.Models.Transportadora> Transportadoras { get; set; }

        public System.Data.Entity.DbSet<NewTms.Models.Motorista> Motoristas { get; set; }

        public System.Data.Entity.DbSet<NewTms.Models.TabelaFrete> TabelaFretes { get; set; }

        public System.Data.Entity.DbSet<NewTms.Views.TabelaFretes.PedidoFrete> PedidoFretes { get; set; }
    }
}
