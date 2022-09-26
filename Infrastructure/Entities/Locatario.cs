using Infrastructure.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class Locatario
    {
        public Locatario()
        {
            Fiadores = new List<Fiador>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O CAMPO NOME É OBRIGATÓRIO")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O CAMPO DATA DE NASCIMENTO É OBRIGATÓRIO")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        [DisplayName("Data de Nascimento")]
        public DateOnly? BirthDate { get; set; }

        [Required(ErrorMessage = "O CAMPO ESTADO CIVIL É OBRIGATÓRIO")]
        [DisplayName("Estado Civil")]
        public string MaritalStatus { get; set; }

        [Required(ErrorMessage = "O CAMPO SEXO É OBRIGATÓRIO")]
        [DisplayName("Sexo")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "O CAMPO CPF É OBRIGATÓRIO")]
        [CpfValidation(ErrorMessage = "CPF INVÁLIDO")]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O CAMPO RG É OBRIGATÓRIO")]
        [DisplayName("RG")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "O CAMPO ORGÃO EXPEDIDOR É OBRIGATÓRIO")]
        [DisplayName("Orgão Expedidor")]
        public string DispatchingAgency { get; set; }

        [Required(ErrorMessage = "O CAMPO NACIONALIDADE É OBRIGATÓRIO")]
        [DisplayName("Nacionalidade")]
        public string Nacionality { get; set; }

        [Required(ErrorMessage = "O CAMPO NATURALIDADE É OBRIGATÓRIO")]
        [DisplayName("Naturalidade")]
        public string Naturalness { get; set; }

        [Required(ErrorMessage = "O CAMPO UF É OBRIGATÓRIO")]
        [MaxLength(2, ErrorMessage = "O CAMPO UF ACEITA APENAS A SIGLA DO ESTADO")]
        [DisplayName("UF")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "O CAMPO PROFISSÃO É OBRIGATÓRIO")]
        [DisplayName("Profissão")]
        public string Profession { get; set; }

        [Required(ErrorMessage = "O CAMPO RENDA É OBRIGATÓRIO")]
        [Range(10, 99999.99, ErrorMessage = "RENDA INVÁLIDA")]
        [DisplayName("Renda")]
        public Decimal Income { get; set; }

        public string? WorkAddress { get; set; }
        public string? PhoneWork { get; set; }

        [DisplayName("Telefone 01")]
        public string Phone1 { get; set; }

        [DisplayName("Telefone 02")]
        public string? Phone2 { get; set; }
        public int QtdAnimals { get; set; }
        public string? Email { get; set; }

        [DisplayName("Observações")]
        public string? Comments { get; set; }
        public bool Casado { get; set; }
        public Conjuge? Conjuge { get; set; }
        public List<Fiador> Fiadores { get; set; }
    }
}
