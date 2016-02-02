using ForMeeting.Domain.Site.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ForMeeting.Infra.Data.Persistencia.Mapeamentos
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            // Chave primaria
            HasKey(cid => cid.IdCidade);

            //Propriedades
            Property(cid => cid.IdCidade)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(cid => cid.Nome)
                .HasMaxLength(80)
                .IsRequired();

            //Mapeamento
            ToTable("TB_CIDADE");

            Ignore(cid => cid.ValidationResult);

            //Relacionamentos
            HasMany(cid => cid.ListaDeLocalidades)
                .WithRequired(l => l.Cidade);

            HasRequired(cid => cid.Estado)
                .WithMany(est => est.ListaDeCidades)
                .HasForeignKey(cid => cid.EstadoId);
        }
    }
}