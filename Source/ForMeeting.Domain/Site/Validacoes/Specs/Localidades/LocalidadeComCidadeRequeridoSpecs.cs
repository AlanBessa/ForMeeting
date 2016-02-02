using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComCidadeRequeridoSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            return localidade.Cidade != null;
        }
    }
}