using DomainValidation.Validation;
using ForMeeting.Domain.Site.Enum;
using ForMeeting.Domain.Site.Validacoes.Scopes.Associados;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Entidades
{
    public class Associado
    {
        public Associado()
        {
            IdAssociado = Guid.NewGuid();
            ListaDeEventosParticipante = new List<Evento>();
            ListaDeEventosCriado = new List<Evento>();
            ListaDeComentariosFeitos = new List<Comentario>();
        }

        public Guid IdAssociado { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public DateTime? DataDeNascimento { get; set; }

        public AtivacaoEnum StatusDeAtivacao { get; set; }

        public virtual ICollection<Evento> ListaDeEventosParticipante { get; set; }

        public virtual ICollection<Evento> ListaDeEventosCriado { get; set; }

        public virtual ICollection<Comentario> ListaDeComentariosFeitos { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validador = new AssociadoEstaValido();

            ValidationResult = validador.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}