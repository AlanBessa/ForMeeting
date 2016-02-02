using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComLogradouroRequeridoSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarRequerimentoDoCampoLogradouro = CampoTextoValidation.ValidarSeEhRequerido(localidade.Logradouro);

            return validarRequerimentoDoCampoLogradouro;
        }
    }
}