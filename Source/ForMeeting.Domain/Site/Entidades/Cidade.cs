using DomainValidation.Validation;
using ForMeeting.Domain.Site.Validacoes.Scopes.Cidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Entidades
{
    public class Cidade
    {
        public Cidade()
        {
            IdCidade = Guid.NewGuid();
            ListaDeLocalidades = new List<Localidade>();
        }

        public Guid IdCidade { get; set; }

        public string Nome { get; set; }

        public Guid EstadoId { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual ICollection<Localidade> ListaDeLocalidades { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validador = new CidadeEstaValido();

            ValidationResult = validador.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}