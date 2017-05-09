using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;

namespace LysiSolutionNumber01.Models.Repository
{
    public class ProdutoRepository : IDefaultRepository<Produto>
    {
        private readonly ProdutoContext _context;

        public ProdutoRepository(ProdutoContext context)
        {
            _context = context;
            
            if (_context.Produto.Count() == 0)//Eu acho que isso é falho, pois você só irá conseguir adicionar um único produto.
                Add(new Produto { Nome = "Teste" });
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Produtos.Include(p => p.Grupo).ToList();
        }

        public void Add(Produto item)
        {
            var grupo=_context.Grupos.Find(1);
            if(grupo!=null)
               AddToGroup(item,grupo);
            
        }
        public void AddToGroup(Produto item,LysiSolutionNumber01.Models.Grupo grupo)
        {
              if(grupo.Produtos==null)
                 grupo.Produtos=new List<Produtos>();
              ggrupo.Produtos.Add(item);
              
            _context.SaveChanges();
        }
        public Produto Find(long key)
        {
            return _context.Produtos.Include("Grupo").FirstOrDefault(t => t.Id == key);
        }

        public void Remove(long key)
        {
            var entity = _context.Produtos.First(t => t.Id == key);
            _context.Produtos.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Produto item)
        {
            _context.Produtos.Update(item);
            _context.SaveChanges();
        }
    }
}
