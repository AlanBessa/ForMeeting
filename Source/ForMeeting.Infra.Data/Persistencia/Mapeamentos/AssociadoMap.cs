using ForMeeting.Domain.Site.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ForMeeting.Infra.Data.Persistencia.Mapeamentos
{
    public class AssociadoMap : EntityTypeConfiguration<Associado>
    {
        public AssociadoMap()
        {
            // Chave primaria
            HasKey(a => a.IdAssociado);

            //Propriedades
            Property(a => a.IdAssociado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Nome)
                .HasMaxLength(100)
                .IsRequired();

            Property(a => a.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(a => a.DataDeNascimento)
                .HasColumnType("DateTime2")
                .IsRequired();

            Property(a => a.DataDeCadastro)
                .HasColumnType("DateTime2")
                .IsRequired();

            Property(a => a.StatusDeAtivacao)
                .IsRequired();

            //Mapeamento
            ToTable("TB_ASSOCIADO");

            Ignore(a => a.ValidationResult);

            //Relacionamentos
            HasRequired(a => a.Usuario)
                .WithRequiredDependent(u => u.Associado);

            HasMany(a => a.ListaDeComentariosFeitos)
                .WithRequired(com => com.Associado);

            HasMany(a => a.ListaDeEventosCriado)
                .WithRequired(e => e.Criador);

            HasMany(a => a.ListaDeEventosParticipante)
                .WithMany(e => e.ListaDePresenca)
                .Map(ae =>
                {
                    ae.ToTable("TB_ASSOCIADO_EVENTO");
                    ae.MapLeftKey("AssociadoId");
                    ae.MapRightKey("EventoId");
                });
        }
    }
}