using ZonaSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ZonaSoft.Persistencia.EntityFramework.Mapping
{
    class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            this.ToTable("Clientes");

            this.HasKey(x => x.IdCliente);
            this.Property(x => x.IdCliente)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(40);

            this.Property(x => x.Apellido)
                .HasColumnName("apellido")
                .IsRequired()
                .HasMaxLength(40);

            this.HasIndex(x => x.DNI);
            this.Property(x => x.DNI)
                .HasColumnName("dni")
                .HasMaxLength(10);

            this.HasIndex(x => x.CUIT);
            this.Property(x => x.CUIT)
                .HasColumnName("cuit")
                .HasMaxLength(20);

            this.Property(x => x.Telefono)
                .HasColumnName("telefono")
                .HasMaxLength(30);

            this.Property(x => x.Direccion)
                .HasColumnName("direccion")
                .HasMaxLength(50);

            this.HasRequired<Localidad>(x => x.Localidad)
                .WithMany(x => x.Clientes)
                .HasForeignKey<int>(x => x.IdLocalidad);
        }
    }
}
