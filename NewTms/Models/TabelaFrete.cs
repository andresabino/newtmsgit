using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewTms.Models
{
    [Table("TabelaFretes")]
    public class TabelaFrete
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [DisplayName("Taxa de Despacho")]
        public decimal TaxaDespacho { get; set; }

        [DisplayName("Percentual de Restriçaõ de Trafego")]
        public decimal PercentualRestricaoTrafego { get; set; }

        [DisplayName("Taxa Pedágio Fração")]
        public decimal TaxaPedagioFracao { get; set; }

        [DisplayName("Taxa de Serviço Adicional")]
        public decimal TaxaServicoAdicional { get; set; }

        [DisplayName("Distância de:")]
        public decimal DistanciaDe { get; set; }

        [DisplayName("Distância Até")]
        public decimal DistancaiAte { get; set; }

        [DisplayName("Valor por Tonelada (1000kg)")]
        public decimal ValorTonelada { get; set; }

        [DisplayName("Peso de:")]
        public decimal PesoDe { get; set; }

        [DisplayName("Peso Até:")]
        public decimal PesoAte { get; set; }

        [DisplayName("Percentual Gris")]
        public decimal PercentualGris { get; set; }

        [DisplayName("Observação")]
        public string Observacao { get; set; }

        [DisplayName("Ativo")]
        public bool Ativo { get; set; }        
    }
}