using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewTms.Models
{
    public class ClienteVM
    {
        public ClienteVM()
        {

        }
        public int Id { get; set; }
        public string Nome { get; set; }

        [DisplayName("CPF / CNPJ")]
        public string CPF_CNPJ { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Obs { get; set; }

        public class ItemListContext : DbContext
        {
            public DbSet<ClienteVM> clienteVM { get; set; }
        }
    }
}
