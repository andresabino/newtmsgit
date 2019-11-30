using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NewTms.Models
{
    public class Transportadora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string UF { get; set; }

        [DisplayName("Observação")]
        public string Observacao { get; set; }
        public bool Ativo { get; set; }

        public virtual List<Motorista> Motorista {get;set;}
    }
}