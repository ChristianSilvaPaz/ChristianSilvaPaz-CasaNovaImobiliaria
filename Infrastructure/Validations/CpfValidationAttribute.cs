using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Validations
{
    public class CpfValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return ValidateCpf(value.ToString());
        }

        private bool ValidateCpf(string cpf)
        {
            CPFCNPJ.IMain main1 = new CPFCNPJ.Main();
            var resultCPF = main1.IsValidCPFCNPJ(cpf);
            return resultCPF;
        }
    }
}
