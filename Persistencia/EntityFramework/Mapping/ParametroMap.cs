using ShockSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ShockSoft.Persistencia.EntityFramework.Mapping
{
    class ParametroMap : EntityTypeConfiguration<Parametro>
    {
        public ParametroMap()
        {
            this.ToTable("Parametros");

            this.HasKey(x => x.IdParametro);
            this.Property(x => x.IdParametro)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired()
                .HasMaxLength(40);

            this.Property(x => x.Valor)
                .HasColumnName("valor")
                .IsRequired();
        }
    }
}
