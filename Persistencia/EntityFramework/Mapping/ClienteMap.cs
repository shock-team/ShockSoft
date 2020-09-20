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

            this.HasKey(pCliente => pCliente.IdCliente);
            this.Property(pCliente => pCliente.IdCliente)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(pCliente => pCliente.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(40);

            this.Property(pCliente => pCliente.Apellido)
                .HasColumnName("apellido")
                .IsRequired()
                .HasMaxLength(40);

            this.HasIndex(pCliente => pCliente.DNI)
                .IsUnique();
            this.Property(pCliente => pCliente.DNI)
                .HasColumnName("dni")
                .HasMaxLength(10);

            this.HasIndex(pCliente => pCliente.CUIT)
                .IsUnique();
            this.Property(pCliente => pCliente.CUIT)
                .HasColumnName("cuit")
                .HasMaxLength(20);

            this.Property(pCliente => pCliente.Telefono)
                .HasColumnName("telefono")
                .IsRequired()
                .HasMaxLength(30);

            this.Property(pCliente => pCliente.Direccion)
                .HasColumnName("direccion")
                .HasMaxLength(50);

            this.HasRequired<Localidad>(x => x.Localidad)
                .WithMany(x => x.Clientes)
                .HasForeignKey<int>(x => x.IdLocalidad);

        }
    }
}
