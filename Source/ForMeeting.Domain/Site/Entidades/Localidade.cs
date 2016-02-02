using DomainValidation.Validation;
using ForMeeting.Domain.Site.Validacoes.Scopes.Localidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMeeting.Domain.Site.Entidades
{
    public class Localidade
    {
        public Localidade()
        {
            IdLocalidade = Guid.NewGuid();
        }

        public Guid IdLocalidade { get; set; }

        public string NomeDaLocalidade { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Referencias { get; set; }

        public Guid CidadeId { get; set; }

        public virtual Cidade Cidade { get; set; }        
        
        public virtual ICollection<Evento> ListaDeEventos { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validador = new LocalidadeEstaValido();

            ValidationResult = validador.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
