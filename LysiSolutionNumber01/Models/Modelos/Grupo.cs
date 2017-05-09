using LysiSolutionNumber01.Models.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LysiSolutionNumber01.Models
{
    public class Grupo: IModelCadastro<Grupo>
    {        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Nome { get; set; }        
        public virtual ICollection<Produto> Produtos{get;set;}
    }
}
