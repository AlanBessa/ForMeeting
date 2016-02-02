using DomainValidation.Validation;
using ForMeeting.Domain.Site.Enum;
using ForMeeting.Domain.Site.Validacoes.Scopes.Eventos;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Entidades
{
    public class Evento
    {
        public Evento()
        {
            IdEvento = Guid.NewGuid();
            ListaDePresenca = new List<Associado>();
            ListaDeComentario = new List<Comentario>();
        }

        public Guid IdEvento { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public byte[] Vitrine { get; set; }

        public DateTime? HorarioDoEvento { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public StatusDoEventoEnum StatusDoEvento { get; set; }

        public Guid CriadorId { get; set; }

        public virtual Associado Criador { get; set; }

        public Guid LocalidadeId { get; set; }

        public virtual Localidade Localidade { get; set; }

        public Guid CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Associado> ListaDePresenca { get; set; }

        public virtual ICollection<Comentario> ListaDeComentario { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validador = new EventoEstaValido();

            ValidationResult = validador.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}