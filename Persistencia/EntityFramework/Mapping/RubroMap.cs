using ZonaSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ZonaSoft.Persistencia.EntityFramework.Mapping
{
    class RubroMap : EntityTypeConfiguration<Rubro>
    {
        public RubroMap()
        {
            this.ToTable("rubros");

            this.HasKey(x => x.IdRubro);
            this.Property(x => x.IdRubro)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired();
        }
    }
}
