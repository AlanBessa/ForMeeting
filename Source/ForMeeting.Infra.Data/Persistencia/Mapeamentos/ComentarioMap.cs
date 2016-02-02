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
    public class ComentarioMap : EntityTypeConfiguration<Comentario>
    {
        public ComentarioMap()
        {
            // Chave primaria
            HasKey(com => com.IdComentario);

            //Propriedades
            Property(com => com.IdComentario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(com => com.Descricao)
                .HasMaxLength(1000)
                .IsRequired();

            Property(com => com.DataDeCadastro)
                .HasColumnType("DateTime2")
                .IsRequired();

            //Mapeamento
            ToTable("TB_COMENTARIO");

            Ignore(com => com.ValidationResult);

            //Relacionamentos
            HasRequired(com => com.Evento)
                .WithMany(e => e.ListaDeComentario)
                .HasForeignKey(com => com.EventoId);

            HasRequired(com => com.Associado)
                .WithMany(a => a.ListaDeComentariosFeitos)
                .HasForeignKey(com => com.AssociadoId);
        }
    }
}
