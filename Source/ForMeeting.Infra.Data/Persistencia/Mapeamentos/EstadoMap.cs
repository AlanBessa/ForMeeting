using ForMeeting.Domain.Site.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ForMeeting.Infra.Data.Persistencia.Mapeamentos
{
    public class EstadoMap : EntityTypeConfiguration<Estado>
    {
        public EstadoMap()
        {
            // Chave primaria
            HasKey(est => est.IdEstado);

            //Propriedades
            Property(est => est.IdEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(est => est.Nome)
                .HasMaxLength(60)
                .IsRequired();

            Property(est => est.Sigla)
                .HasMaxLength(2);

            //Mapeamento
            ToTable("TB_ESTADO");

            Ignore(est => est.ValidationResult);

            //Relacionamentos
            HasMany(est => est.ListaDeCidades)
                .WithRequired(cid => cid.Estado);

            HasRequired(est => est.Pais)
                .WithMany(p => p.ListaDeEstados)
                .HasForeignKey(est => est.PaisId);
        }
    }
}