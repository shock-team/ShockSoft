using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class ReparacionMap:EntityTypeConfiguration<Reparacion>
    {
        public ReparacionMap()
        {
            this.ToTable("Reparaciones");

            this.HasKey(x => x.IdReparacion);
            this.Property(x => x.IdReparacion)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Problema)
                .HasColumnName("problema");

            this.Property(x => x.Solucion)
                .HasColumnName("solucion");

            this.Property(x => x.Contraseña)
                .HasColumnName("contraseña");

            this.Property(x => x.FechaIngreso)
                .HasColumnName("fechaIngreso");

            this.Property(x => x.FechaReparacion)
                .HasColumnName("fechaReparacion");

            this.Property(x => x.Precio)
                .HasColumnName("precio");

            this.Property(x => x.Entregado)
                .HasColumnName("fueEntregado");

            this.Property(x => x.Cobrado)
                 .HasColumnName("fueCobrado");

            this.Property(x => x.Cargador)
                .HasColumnName("traeCargador");

            this.Property(x => x.Cables)
                 .HasColumnName("traeCables");

            this.HasRequired<Cliente>(x => x.Cliente)
                .WithMany(x => x.Reparaciones)
                .HasForeignKey<int>(x => x.IdCliente);

            this.HasRequired<TipoEquipo>(x => x.TipoEquipo)
                .WithMany(x => x.Reparaciones)
                .HasForeignKey<int>(x => x.IdTipoEquipo);

            this.HasRequired<Marca>(x => x.Marca)
                .WithMany(x => x.Reparaciones)
                .HasForeignKey<int>(x => x.IdMarca);

            this.HasRequired<MetodoPago>(x => x.MetodoPago)
                .WithMany(x => x.Reparaciones)
                .HasForeignKey<int>(x => x.IdMetodoPago);

            this.HasMany<Producto>(x => x.Productos)
                .WithMany(y => y.Reparaciones)
                .Map(xy =>
                    {
                        xy.MapLeftKey("IdProducto");
                        xy.MapRightKey("IdReparacion");
                        xy.ToTable("ProductosParaReparacion");
                    });
        }
    }
}
