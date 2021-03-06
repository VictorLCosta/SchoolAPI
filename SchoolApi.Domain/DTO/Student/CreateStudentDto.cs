using System.ComponentModel.DataAnnotations;
using SchoolApi.Domain.ValueObjects;

namespace SchoolApi.Domain.DTO.Student
{
    public class CreateStudentDto
    {

        [Required(ErrorMessage = "Informe o RA")]
        [StringLength(6, ErrorMessage = "O valor informado deve ter no mínimo 6 caracteres", MinimumLength = 6)]
        public string RA { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        public Email Email { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "A idade é um campo obrigatório")]
        public int Age { get; set; }

        [Required(ErrorMessage = "O sexo é um campo obrigatório")]
        public char Gender { get; set; }

        [Required(ErrorMessage = "O CPF é um campo obrigatório")]
        public string CPF { get; set; }
    }
}