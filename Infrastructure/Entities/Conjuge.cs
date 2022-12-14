using Infrastructure.Validations;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class Conjuge
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O CAMPO NOME É OBRIGATÓRIO")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O CAMPO DATA DE NASCIMENTO É OBRIGATÓRIO")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateOnly? BirthDate { get; set; }

        [Required(ErrorMessage = "O CAMPO SEXO É OBRIGATÓRIO")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "O CAMPO CPF É OBRIGATÓRIO")]
        [CpfValidation(ErrorMessage = "CPF INVÁLIDO")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O CAMPO RG É OBRIGATÓRIO")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "O CAMPO ORGÃO EXPEDIDOR É OBRIGATÓRIO")]
        public string DispatchingAgency { get; set; }

        [Required(ErrorMessage = "O CAMPO NACIONALIDADE É OBRIGATÓRIO")]
        public string Nacionality { get; set; }

        [Required(ErrorMessage = "O CAMPO NATURALIDADE É OBRIGATÓRIO")]
        public string Naturalness { get; set; }

        [Required(ErrorMessage = "O CAMPO UF É OBRIGATÓRIO")]
        [MaxLength(2, ErrorMessage = "O CAMPO UF ACEITA APENAS A SIGLA DO ESTADO")]
        public string Uf { get; set; }

        public string? Profession { get; set; }

        public string? Phone1 { get; set; }

        public string? Phone2 { get; set; }
        public string? Email { get; set; }
        public int? id_locatario { get; set; }
        public int? id_fiador { get; set; }
    }
}
