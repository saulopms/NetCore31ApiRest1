using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlterData.Models
{
    [Table("tb_funcionario")]
    public class Funcionario
    {
        public Funcionario()
        {
        }

        [Key]
        public int idfuncionario { get; set; }

        [Display(Name = "Funcionário")]
        public string funcionario { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Deve ser preenchido"),
            EmailAddress(ErrorMessage = "E-mail informado não é válido")]
        public string email { get; set; }

        [Display(Name = "Senha")]      
        [DataType(DataType.Password)]
        public string senha { get; set; }

    }
}
