namespace Infrastructure.Entities
{
    public class Boleto
    {
        public int Id { get; set; }
        public int IdContrato { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateOnly? DataVencimento { get; set; }
        public DateOnly? DataPagamento { get; set; }
        public Decimal? Juros { get; set; }
        public Decimal? ValorNominal { get; set; }
        public Decimal? ValorPago { get; set; }
    }
}
