using ForMeeting.Domain.Site.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ForMeeting.Infra.Data.Persistencia.Mapeamentos
{
    public class PaisMap : EntityTypeConfiguration<Pais>
    {
        public PaisMap()
        {
            // Chave primaria
            HasKey(p => p.IdPais);

            //Propriedades
            Property(p => p.IdPais)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nome)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Sigla)
                .HasMaxLength(3);

            //Mapeamento
            ToTable("TB_PAIS");

            Ignore(est => est.ValidationResult);

            //Relacionamentos
            HasMany(p => p.ListaDeEstados)
                .WithRequired(est => est.Pais);
        }
    }
}