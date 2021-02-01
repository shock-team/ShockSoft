using ZonaSoft.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ZonaSoft.Persistencia.EntityFramework.Mapping
{
    class MarcaMap : EntityTypeConfiguration<Marca>
    {
        public MarcaMap()
        {
            this.ToTable("Marcas");


            this.HasKey(x => x.IdMarca);
            this.Property(x => x.IdMarca)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired();
        }
    }
}
