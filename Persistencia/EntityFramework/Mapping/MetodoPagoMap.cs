﻿using ShockSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class MetodoPagoMap : EntityTypeConfiguration<MetodoPago>
    {
        public MetodoPagoMap()
        {
            this.ToTable("metodosDePago");

            this.HasKey(x => x.IdMetodoPago);
            this.Property(x => x.IdMetodoPago)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Valor)
                .HasColumnName("valor");

            this.Property(x => x.Descripcion)
                .HasColumnName("descripcion");
        }
    }
}