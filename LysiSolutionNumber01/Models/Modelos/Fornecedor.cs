using LysiSolutionNumber01.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LysiSolutionNumber01.Models
{
    public class Fornecedor : Pessoa, IModelCadastro<Fornecedor>
    {
        //Fornecedores: Código, Nome, Endereço (Rua, Bairro, Cidade, Estado, CEP), Telefone, CNPJ, Insc.Estadual, E-mail;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Codigo { get; set; }
        public string InscricaoEstadual { get; set; }                        
    }
}
