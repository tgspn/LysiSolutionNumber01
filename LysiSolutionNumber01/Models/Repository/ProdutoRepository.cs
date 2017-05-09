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

            if (_context.Registros.Count() == 0)
                Add(new Produto { Nome = "Teste", GrupoId = 1 });
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Registros.Include(p => p.Grupo).ToList();
        }

        public void Add(Produto item)
        {
            _context.Registros.Add(item);
            _context.SaveChanges();
        }

        public Produto Find(long key)
        {
            return _context.Registros.Include("Grupo").FirstOrDefault(t => t.Id == key);
        }

        public void Remove(long key)
        {
            var entity = _context.Registros.First(t => t.Id == key);
            _context.Registros.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Produto item)
        {
            _context.Registros.Update(item);
            _context.SaveChanges();
        }
    }
}
