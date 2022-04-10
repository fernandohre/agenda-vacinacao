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
    public class UsuarioEntityTypeConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(60);
            builder.Property(x => x.DataNascimento).IsRequired();
            builder.Property(x => x.Sexo).HasMaxLength(1);
            builder.Property(x => x.Logradouro).HasMaxLength(60);
            builder.Property(x => x.Setor).HasMaxLength(40);
            builder.Property(x => x.Cidade).HasMaxLength(40);
            builder.Property(x => x.Uf).HasMaxLength(2);

            builder.HasMany(x => x.Alergias);
        }
    }
}
