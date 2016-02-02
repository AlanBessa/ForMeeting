using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMeeting.Infra.Data.Persistencia.Mapeamentos
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Chave primaria
            HasKey(u => u.IdUsuario);

            //Propriedades
            Property(u => u.IdUsuario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(u => u.Email)
                .HasMaxLength(160)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("EmailIndex") { IsUnique = true }));
            
            Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(36)
                .IsFixedLength();

            Property(u => u.Verificado);

            Property(u => u.Ativo);

            Property(u => u.UltimaDataDeLogin);

            Property(u => u.Papel);

            Property(u => u.CodigoDeAtivacao)
                .HasMaxLength(4)
                .IsFixedLength()
                .IsRequired();

            Property(u => u.CodigoDeVerificacao)
                .HasMaxLength(6)
                .IsFixedLength()
                .IsRequired();

            Property(u => u.CodigoDeAutorizacao)
                .HasMaxLength(4)
                .IsFixedLength()
                .IsRequired();

            Property(u => u.DataDoUltimoRequestDoCodigoDeAutorizacao);

            //Mapeamento
            ToTable("TB_USUARIO");

            Ignore(u => u.ValidationResult);

            //Relacionamentos
            HasRequired(u => u.Associado)
                .WithRequiredPrincipal(a => a.Usuario);
        }
    }
}
