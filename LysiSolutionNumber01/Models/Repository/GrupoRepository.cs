using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;

namespace LysiSolutionNumber01.Models.Repository
{
    public class GrupoRepository : IDefaultRepository<Grupo>
    {
        private readonly GrupoContext _context;

        public GrupoRepository(GrupoContext context)
        {
            _context = context;

            if (_context.Registros.Count() == 0)
                Add(new Grupo { Nome = "Teste" });
        }

        public IEnumerable<Grupo> GetAll()
        {
            return _context.Registros.ToList();
        }

        public void Add(Grupo item)
        {
            _context.Registros.Add(item);
            _context.SaveChanges();
        }

        public Grupo Find(long key)
        {
            return _context.Registros.FirstOrDefault(t => t.Id == key);
        }

        public void Remove(long key)
        {
            var entity = _context.Registros.First(t => t.Id == key);
            _context.Registros.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Grupo item)
        {
            _context.Registros.Update(item);
            _context.SaveChanges();
        }
    }
}
