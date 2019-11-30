using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewTms.Models
{
    [Table("Motoristas")]
    public class Motorista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string CNH { get; set; }

        [DisplayName("Data Vencimento CNH")]
        public string DataVencimentoCNH { get; set; }

        [DisplayName("Categoria CNH")]
        public string CategoriaCNH { get; set; }

        [DisplayName("Observaçaõ")]
        public string Observacao { get; set; }
        public bool Ativo { get; set; }
        public virtual Transportadora TransportadoraAtual { get; set; }       

    }
}

