using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LysiSolutionNumber01.Models
{
    public class Pessoa
    {                
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string DocumentoIdentificador { get; set; } //CPF ou CNPJ
        public char TipoDePessoa { get; set; }        
        public string EmailDeContato { get; set; }
    }
}
