using ForMeeting.Domain.Site.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ForMeeting.Infra.Data.Persistencia.Mapeamentos
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            // Chave primaria
            HasKey(c => c.IdCategoria);

            //Propriedades
            Property(c => c.IdCategoria)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasMaxLength(80)
                .IsRequired();

            //Mapeamento
            ToTable("TB_CATEGORIA");

            Ignore(c => c.ValidationResult);

            //Relacionamentos
            HasMany(c => c.ListaDeEventos)
                .WithRequired(e => e.Categoria);
        }
    }
}