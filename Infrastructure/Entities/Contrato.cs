using Infrastructure.Entities.Enums;

namespace Infrastructure.Entities
{
    public class Contrato
    {
        public int Id{ get; set; }
        public int IdLocatario { get; set; }
        public DateOnly DataInicio{ get; set; }
        public DateOnly DataFinal { get; set; }
        public int QuantidadeMeses { get; set; }
        public FormaDePagamento FormaPagamento { get; set; }
        public Decimal Valor { get; set; }
        public string Observacoes { get; set; }
    }
}
