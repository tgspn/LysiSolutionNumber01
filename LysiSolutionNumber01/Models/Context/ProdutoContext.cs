﻿using LysiSolutionNumber01.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Registros { get; set; }

    }
}