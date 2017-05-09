using LysiSolutionNumber01.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LysiSolutionNumber01.Models
{
    public class MovimentacaoDeEstoque: IModelCadastro<MovimentacaoDeEstoque>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Codigo { get; set; }
        [ForeignKey("Produto")]
        public Produto Produto { get; set; }
        public string Observacao { get; set; }
        public float QuantidadeMovimentada { get; set; }
        public char EntradaSaida { get; set; }
        public DateTime DataHoraMovimentacao { get; set; }

    }
}
