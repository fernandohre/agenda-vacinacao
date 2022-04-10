using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacinacao.Core.Domain;

namespace Vacinacao.Infraestrutura.ConfiguracoesDeEntidade
{
    public class AgendaEntityConfiguration : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Situacao).HasMaxLength(10);
            builder.Property(x => x.Observacoes).HasMaxLength(200);

            builder.HasOne(x => x.Vacina);
        }
    }
}
