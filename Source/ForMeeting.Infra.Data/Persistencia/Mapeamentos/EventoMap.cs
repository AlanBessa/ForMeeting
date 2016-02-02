using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMeeting.Infra.Data.Persistencia.Mapeamentos
{
    public class EventoMap : EntityTypeConfiguration<Evento>
    {
        public EventoMap()
        {
            // Chave primaria
            HasKey(e => e.IdEvento);

            //Propriedades
            Property(e => e.IdEvento)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.Titulo)
                .HasMaxLength(80)
                .IsRequired();

            Property(e => e.Descricao)
                .HasMaxLength(1000)
                .IsRequired();

            Property(e => e.HorarioDoEvento)
                .HasColumnType("DateTime2");

            Property(e => e.DataDeCadastro)
                .HasColumnType("DateTime2")
                .IsRequired();

            Property(e => e.StatusDoEvento)
                .IsRequired();

            //Mapeamento
            ToTable("TB_EVENTO");

            Ignore(e => e.ValidationResult);

            //Relacionamentos
            HasRequired(e => e.Criador)
                .WithMany(a => a.ListaDeEventosCriado)
                .HasForeignKey(e => e.CriadorId);

            HasRequired(e => e.Localidade)
                .WithRequiredPrincipal(l => l.Evento);

            HasRequired(e => e.Categoria)
                .WithMany(c => c.ListaDeEventos)
                .HasForeignKey(e => e.CategoriaId);

            //HasMany(e => e.ListaDePresenca)
            //    .WithMany(c => c.ListaDeEventosParticipante)
            //    .Map(evcl =>
            //    {
            //        evcl.ToTable("TB_EVENTO_ASSOCIADO");
            //        evcl.MapLeftKey("EventoId");
            //        evcl.MapRightKey("AssociadoId");
            //    }
            //    );

            HasMany(e => e.ListaDeComentario)
                .WithRequired(com => com.Evento);
        }
    }
}
