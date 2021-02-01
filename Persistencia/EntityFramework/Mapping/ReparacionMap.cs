using ZonaSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ZonaSoft.Persistencia.EntityFramework.Mapping
{
    class ReparacionMap : EntityTypeConfiguration<Reparacion>
    {
        public ReparacionMap()
        {
            this.ToTable("Reparaciones");

            this.HasKey(x => x.IdReparacion);
            this.Property(x => x.IdReparacion)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Problema)
                .HasColumnName("problema")
                .IsOptional();

            this.Property(x => x.Solucion)
                .HasColumnName("solucion")
                .IsOptional();

            this.Property(x => x.Contraseña)
                .HasColumnName("contraseña")
                .IsOptional();

            this.Property(x => x.FechaIngreso)
                .HasColumnName("fechaIngreso")
                .IsOptional();

            this.Property(x => x.FechaReparacion)
                .HasColumnName("fechaReparacion")
                .IsOptional();

            this.Property(x => x.FechaEntrega)
                .HasColumnName("fechaEntrega")
                .IsOptional();

            this.Property(x => x.Precio)
                .HasColumnName("precio")
                .IsOptional();

            this.Property(x => x.Entregado)
                .HasColumnName("fueEntregado")
                .IsOptional();

            this.Property(x => x.Cobrado)
                 .HasColumnName("fueCobrado")
                 .IsOptional();

            this.Property(x => x.Cargador)
                .HasColumnName("traeCargador")
                .IsOptional();

            this.Property(x => x.Cables)
                 .HasColumnName("traeCables")
                 .IsOptional();

            this.HasRequired<Cliente>(x => x.Cliente)
                .WithMany(x => x.Reparaciones)
                .HasForeignKey<int>(x => x.IdCliente);

            this.HasRequired<Rubro>(x => x.Rubro)
                .WithMany(x => x.Reparaciones)
                .HasForeignKey<int>(x => x.IdRubro);

            this.HasRequired<Marca>(x => x.Marca)
                .WithMany(x => x.Reparaciones)
                .HasForeignKey<int>(x => x.IdMarca);

            this.HasRequired<MetodoPago>(x => x.MetodoPago)
                .WithMany(x => x.Reparaciones)
                .HasForeignKey<int>(x => x.IdMetodoPago);

            this.HasMany(x => x.LineasReparacion)
                .WithRequired(x => x.Reparacion)
                .HasForeignKey(x => x.IdReparacion);
        }
    }
}
