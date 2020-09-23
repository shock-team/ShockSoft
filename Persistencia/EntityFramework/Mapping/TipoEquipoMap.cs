using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShockSoft.Dominio;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class TipoEquipoMap : EntityTypeConfiguration<TipoEquipo>
    {
        public TipoEquipoMap()
        {
            this.ToTable("tiposDeEquipo");

            this.HasKey(x => x.IdTipoEquipo);
            this.Property(x => x.IdTipoEquipo)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired();
        }
    }
}
