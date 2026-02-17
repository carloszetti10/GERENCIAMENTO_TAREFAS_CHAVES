using GERENC_DOMAIN.Entities.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GERENC_INFRAESTRUTURA.Persistence.Configurations
{
    internal class UsuarioConfig : IEntityTypeConfiguration<UsuarioBaseModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioBaseModel> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Usuario)
                   .IsRequired()
                   .HasMaxLength(10);

            builder.HasIndex(e => e.Usuario)
                   .IsUnique();
        }
    }
}
