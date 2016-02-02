using DomainValidation.Validation;
using ForMeeting.Domain.Site.Validacoes.Scopes.Comentarios;
using System;

namespace ForMeeting.Domain.Site.Entidades
{
    public class Comentario
    {
        public Comentario()
        {
            IdComentario = Guid.NewGuid();
        }

        public Guid IdComentario { get; set; }

        public string Descricao { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public Guid EventoId { get; set; }

        public virtual Evento Evento { get; set; }

        public Guid AssociadoId { get; set; }

        public virtual Associado Associado { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validador = new ComentarioEstaValido();

            ValidationResult = validador.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}