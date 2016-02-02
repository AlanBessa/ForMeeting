using DomainValidation.Validation;
using ForMeeting.Domain.Site.Validacoes.Scopes.Paises;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Entidades
{
    public class Pais
    {
        public Pais()
        {
            IdPais = Guid.NewGuid();
            ListaDeEstados = new List<Estado>();
        }

        public Guid IdPais { get; set; }

        public string Nome { get; set; }

        public string Sigla { get; set; }

        public virtual ICollection<Estado> ListaDeEstados { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validador = new PaisEstaValido();

            ValidationResult = validador.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}