using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class ClienteMap:EntityTypeConfiguration<Cliente>
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

            this.HasIndex(x => x.DNI)
                .IsUnique();
            this.Property(x => x.DNI)
                .HasColumnName("dni")
                .HasMaxLength(10);

            this.HasIndex(x => x.CUIT)
                .IsUnique();
            this.Property(x => x.CUIT)
                .HasColumnName("cuit")
                .HasMaxLength(20);

            this.Property(x => x.Telefono)
                .HasColumnName("telefono")
                .IsRequired()
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
