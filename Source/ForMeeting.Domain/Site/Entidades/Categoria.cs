using DomainValidation.Validation;
using ForMeeting.Domain.Site.Validacoes.Scopes.Categorias;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Entidades
{
    public class Categoria
    {
        public Categoria()
        {
            IdCategoria = Guid.NewGuid();
            ListaDeEventos = new List<Evento>();
        }

        public Guid IdCategoria { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Evento> ListaDeEventos { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validador = new CategoriaEstaValido();

            ValidationResult = validador.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}