using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class PagoMap:EntityTypeConfiguration<Pago>
    {
        public PagoMap()
        {
            this.ToTable("Pagos");

            this.HasKey(x => x.IdPago);
            this.Property(x => x.IdPago)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Fecha)
                .HasColumnName("fecha")
                .IsRequired();

            this.Property(x => x.Monto)
                .HasColumnName("monto")
                .IsRequired();

            this.Property(x => x.Descripcion)
                .HasColumnName("descripcion");

            this.HasRequired<Cliente>(x => x.Cliente)
                .WithMany(x => x.Pagos)
                .HasForeignKey<int>(x => x.IdCliente);
        }
    }
}
