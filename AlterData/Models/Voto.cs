using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlterData.Models
{
    [Table("tb_voto")]
    public class Voto
    {
        public Voto()
        {
        }

        [Key]
        public int idvoto { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dt_voto { get; set; }

        [Display(Name = "Hora")]        
        public TimeSpan hr_voto { get; set; }

        [Display(Name = "Id.Recurso")]
        public Int32 idrecurso { get; set; }

        [Display(Name = "Id.Funcionário")]
        public Int32 idfuncionario { get; set; }

        [Display(Name = "Comentário")]
        [Required(ErrorMessage = "Por favor, comente o seu voto")]
        public string comentario { get; set; }

    }


    [Table("vw_voto")]   
    public class VwVoto
    {
        public VwVoto()
        {
        }

        [Key]
        [Display(Name = "Recurso")]
        public string recurso { get; set; }

        [Display(Name = "Votos")]
        public Int32 votos { get; set; }

        [Display(Name = "%")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double percentual { get; set; }

     

    }


    [Table("vw_voto_listagem")]
    public class VwVotoListagem
    {
        public VwVotoListagem()
        {
        }

        [Key]
        [Display(Name = "ID")]
        public int idvoto { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dt_voto { get; set; }

        [Display(Name = "Hora")]
        public string hr_voto { get; set; }

        [Display(Name = "Recurso")]
        public string recurso { get; set; }

        [Display(Name = "Funcionário")]
        public string funcionario { get; set; }

        [Display(Name = "Comentário")]       
        public string comentario { get; set; }

    }


}
