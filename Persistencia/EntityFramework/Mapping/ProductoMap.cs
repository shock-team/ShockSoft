using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class ProductoMap:EntityTypeConfiguration<Producto>
    {
        public ProductoMap()
        {
            this.ToTable("Productos");

            this.HasKey(x => x.IdProducto);
            this.Property(x => x.IdProducto)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired();

            this.Property(x => x.Cantidad)
                .HasColumnName("cantidad");

            this.Property(x => x.PrecioBaseDolar)
                .HasColumnName("precioEnDolares")
                .IsRequired();

            this.Property(x => x.EnVenta)
                .HasColumnName("enVenta");

            this.Property(x => x.PorcentajeGanancia)
                .HasColumnName("porcentajeGanancia");

            this.HasRequired<Marca>(x => x.Marca)
                .WithMany(t => t.Productos)
                .HasForeignKey<int>(x => x.IdMarca);

            this.HasRequired<Parametro>(x => x.Parametro)
                .WithMany(t => t.Productos)
                .HasForeignKey<int>(x => x.IdParametro);
        }
    }
}
