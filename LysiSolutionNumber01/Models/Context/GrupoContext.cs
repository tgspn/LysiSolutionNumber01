using LysiSolutionNumber01.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class GrupoContext : DbContext
    {
        public GrupoContext(DbContextOptions<GrupoContext> options)
            : base(options)
        {
        }

        public DbSet<Grupo> Registros { get; set; }

    }
}