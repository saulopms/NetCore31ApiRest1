using System;
using Microsoft.EntityFrameworkCore;

namespace AlterData.Models
{
    public class VotoContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Voto> Votos { get; set; }
        public DbSet<VwVoto> VwVotos { get; set; }
        public DbSet<VwVotoListagem> VwVotosLista { get; set; }

        public VotoContext(DbContextOptions<VotoContext> options) :
        base(options)
        {
        }

        public VotoContext()
        {
        }
    }
}
