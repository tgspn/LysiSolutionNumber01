using LysiSolutionNumber01.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LysiSolutionNumber01.Models
{
    public class Produto: IModelCadastro<Produto>
    {
        //- Produtos: Código, Nome, Grupo, Qtde Estoque, Vl. Custo, Vl. Venda (Ex: 01 – Espeto de Carne – Grupo 01 – 30 – 1,70 – 4,50);
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Nome { get; set; }        
        public long GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }
        public float ValorCusto { get; set; }
        public float ValorVenda { get; set; }
    }
}
