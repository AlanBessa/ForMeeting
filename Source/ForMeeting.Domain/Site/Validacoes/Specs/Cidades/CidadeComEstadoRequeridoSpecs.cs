using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Cidades
{
    public class CidadeComEstadoRequeridoSpecs : ISpecification<Cidade>
    {
        public bool IsSatisfiedBy(Cidade cidade)
        {
            return cidade.Estado != null;
        }
    }
}