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
    public class VacinacaoEntityConfiguration : IEntityTypeConfiguration<Vacina>
    {
        public void Configure(EntityTypeBuilder<Vacina> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo).HasMaxLength(60);
            builder.Property(x => x.Descricao).HasMaxLength(200);
            builder.Property(x => x.doses).IsRequired();
            builder.Property(x => x.Peridiocidade).IsRequired();
            builder.Property(x => x.intervalo).IsRequired();
        }
    }
}
