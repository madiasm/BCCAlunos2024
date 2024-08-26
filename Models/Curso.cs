﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCCAlunos2024.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo descrição é obrigatorio")]
        [StringLength(35)]
        [Display (Name = "Descrição: ")]
        public string descricao { get; set; }
    }
}
