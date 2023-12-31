using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuracion;
public class OficinaConfiguration : IEntityTypeConfiguration<Oficina>
{
    public void Configure(EntityTypeBuilder<Oficina> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("oficina");

        builder.Property(e => e.Id)
            .HasMaxLength(10)
            .HasColumnName("id");

        builder.Property(e => e.Ciudad)
            .IsRequired()
            .HasMaxLength(30)
            .HasColumnName("ciudad");

        builder.Property(e => e.CodigoPostal)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnName("codigo_postal");

        builder.Property(e => e.LineaDireccion1)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName("linea_direccion1");

        builder.Property(e => e.LineaDireccion2)
            .HasMaxLength(50)
            .HasColumnName("linea_direccion2");

        builder.Property(e => e.Pais)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName("pais");

        builder.Property(e => e.Region)
            .HasMaxLength(50)
            .HasColumnName("region");
            
        builder.Property(e => e.Telefono)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("telefono");
    }
}