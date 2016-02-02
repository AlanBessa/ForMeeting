using ForMeeting.Domain.Site.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ForMeeting.Infra.Data.Persistencia.Mapeamentos
{
    public class LocalidadeMap : EntityTypeConfiguration<Localidade>
    {
        public LocalidadeMap()
        {
            // Chave primaria
            HasKey(l => l.IdLocalidade);

            //Propriedades
            Property(l => l.IdLocalidade)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(l => l.NomeDaLocalidade)
                .HasMaxLength(80)
                .IsRequired();

            Property(l => l.Logradouro)
                .HasMaxLength(200)
                .IsRequired();

            Property(l => l.Numero)
                .IsRequired();

            Property(l => l.Complemento)
                .HasMaxLength(200);

            Property(l => l.Bairro)
                .HasMaxLength(80)
                .IsRequired();

            Property(l => l.Cep)
                .IsRequired()
                .HasMaxLength(7);

            Property(l => l.Referencias)
                .HasMaxLength(500);

            //Mapeamento
            ToTable("TB_LOCALIDADE");

            Ignore(l => l.ValidationResult);

            //Relacionamentos
            HasMany(l => l.ListaDeEventos)
                .WithRequired(e => e.Localidade);

            HasRequired(l => l.Cidade)
                .WithMany(cid => cid.ListaDeLocalidades)
                .HasForeignKey(l => l.CidadeId);
        }
    }
}