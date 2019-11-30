using NewTms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewTms.Views.TabelaFretes
{
    [Table("PedidoFretes")]
    public class PedidoFrete
    {
        public int Id { get; set; }

        [DisplayName("Cep para Coleta")]
        public string CepColeta { get; set; }

        [DisplayName("Cep Destino")]
        public string CepDestino { get; set; }

        [DisplayName("Distância em KM")]
        public decimal Distancia { get; set; }

        [DisplayName("Data para Retirada")]
        public DateTime DataRetiradaAgendada { get; set; }

        [DisplayName("Altura em Metros")]
        public decimal Altura { get; set; }

        [DisplayName("largura em Metros")]
        public decimal Largura { get; set; }

        [DisplayName("Profunidade em Metros")]
        public decimal Profundidade { get; set; }
        
        [DisplayName("Peso em KG")]
        public decimal Peso { get; set; }

        [DisplayName("Carga Especial")]
        public bool CargaEspecial { get; set; }

        [DisplayName("Valor do Frete")]
        public decimal ValorFrete { get; set; }

        [DisplayName("Data Vencimento CNH")]
        public string DataVencimentoCNH { get; set; }

        [DisplayName("Categoria CNH")]
        public string CategoriaCNH { get; set; }              

        [DisplayName("Data Aprovação Frete")]
        public string DataAprovacaoFrete { get; set; }

        [DisplayName("Frete Aprovado")]
        public bool AprovadoFrete { get; set; }

        [DisplayName("Status")]
        public bool Status { get; set; }

        [DisplayName("Observação")]
        public string Observacao { get; set; }

        public virtual ClienteVM CLienteFrete { get; set; }

        public virtual Transportadora TransportadoraFrete { get; set; }

    }
}