using System.ComponentModel.DataAnnotations;

namespace View
{
    public class ValidationDataAnnotation
    {
        public static IEnumerable<ValidationResult> GetValidationErros(Object obj)
        {
            var resultValidation = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultValidation, true);
            return resultValidation;
        }

        public static bool ValidationModel(object obj)
        {
            var erros = GetValidationErros(obj);
            var strErros = "";
            foreach (var erro in erros)
            {
                strErros += erro.ErrorMessage + Environment.NewLine;
            }
            if (strErros.Length > 0)
            {
                strErros = "Corrija os problemas abaixo: " + Environment.NewLine + Environment.NewLine + strErros;
                MessageBox.Show(strErros);
                return false;
            }
            else
                return true;
        }
    }
}
