using DomainValidation.Validation;
using ForMeeting.Domain.Site.Validacoes.Scopes.Estados;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Entidades
{
    public class Estado
    {
        public Estado()
        {
            IdEstado = Guid.NewGuid();
            ListaDeCidades = new List<Cidade>();
        }

        public Guid IdEstado { get; set; }

        public string Nome { get; set; }

        public string Sigla { get; set; }

        public Guid PaisId { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual ICollection<Cidade> ListaDeCidades { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validador = new EstadoEstaValido();

            ValidationResult = validador.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}