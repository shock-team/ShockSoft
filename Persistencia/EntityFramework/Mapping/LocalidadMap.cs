using ShockSoft.Dominio;
using System.Data.Entity.ModelConfiguration;


namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class LocalidadMap : EntityTypeConfiguration<Localidad>
    {
        public LocalidadMap()
        {
            this.ToTable("Localidades");

            this.HasKey(x => x.IdLocalidad);
            this.Property(x => x.IdLocalidad)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Nombre)
                .HasColumnName("nombre")
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
