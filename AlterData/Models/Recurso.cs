using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlterData.Models
{
    [Table("tb_recurso")]
    public class Recurso
    {
        public Recurso()
        {
        }

        [Key]
        [Display(Name = "ID")]
        public int idrecurso { get; set; }

        [Display(Name = "Recurso")]
        public string recurso { get; set; }

        [Display(Name = "Detalhes")]
        public string detalhes { get; set; }

      

    }
}
