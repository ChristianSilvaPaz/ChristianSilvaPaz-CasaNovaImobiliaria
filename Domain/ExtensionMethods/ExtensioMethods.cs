using Infrastructure.Entities;

namespace Domain.ExtensionMethods
{
    internal static class ExtensioMethods
    {
        public static string ExtrairNome(this string linhaAtual)
        {
            return linhaAtual.Substring(148, 40);
        }
        public static string ExtrairCpf(this string linhaAtual)
        {
            return linhaAtual.Substring(137, 11);
        }
        public static DateOnly ExtrairDataVencimento(this string linhaAtual)
        {
            return DateOnly.ParseExact(linhaAtual.Substring(73, 8), "ddMMyyyy");
        }
        public static DateOnly ExtrairDataPagamento(this string linhaAtual)
        {
            return DateOnly.ParseExact(linhaAtual.Substring(145, 8), "ddMMyyyy");
        }
        public static Decimal ExtrairJuros(this string linhaAtual)
        {
            return Convert.ToDecimal(linhaAtual.Substring(17, 15));
        }
        public static Decimal ExtrairValorNominal(this string linhaAtual)
        {
            return Convert.ToDecimal(linhaAtual.Substring(81, 15));
        }
        public static Decimal ExtrairValorPago(this string linhaAtual)
        {
            return Convert.ToDecimal(linhaAtual.Substring(77, 15));
        }
    }
}

