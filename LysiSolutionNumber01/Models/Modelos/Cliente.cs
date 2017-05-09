using LysiSolutionNumber01.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LysiSolutionNumber01.Models
{
    public class Cliente : Pessoa, IModelCadastro<Cliente>
    {        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Codigo { get; set; }
        public string RG { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
