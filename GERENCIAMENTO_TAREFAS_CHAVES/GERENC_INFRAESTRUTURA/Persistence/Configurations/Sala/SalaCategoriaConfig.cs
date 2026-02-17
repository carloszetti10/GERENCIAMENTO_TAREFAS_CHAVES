using GERENC_DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_INFRAESTRUTURA.Persistence.Configurations.Sala
{
    public class SalaCategoriaConfig : IEntityTypeConfiguration<SalaCategoria>
    {
        public void Configure(EntityTypeBuilder<SalaCategoria> builder)
        {
            builder.HasKey(sc => new {sc.SalaId, sc.CategoriaId});
            builder.HasOne(sc => sc.Sala)
                .WithMany(sc => sc.SalaCategorias)
                .HasForeignKey(sc => sc.SalaId);

            builder.HasOne(sc => sc.Categoria)
                .WithMany(sc => sc.SalaCategorias)
                .HasForeignKey(sc => sc.CategoriaId);
        }
    }
}
