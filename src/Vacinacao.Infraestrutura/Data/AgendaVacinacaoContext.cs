using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacinacao.Core.Data;
using Vacinacao.Core.Domain;

namespace Vacinacao.Infraestrutura.Data
{
    public class AgendaVacinacaoContext : DbContext, IAgendaVacinacaoContext
    {
        public AgendaVacinacaoContext(DbContextOptions<AgendaVacinacaoContext> options) : base(options)
        {
        }

        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Vacina> Vacinas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alergia> Alergias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                Console.WriteLine("Algo deu errado! Verifique.");
            }
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IAgendaVacinacaoContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
