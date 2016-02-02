using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Estados
{
    public class EstadoComPaisRequeridoSpecs : ISpecification<Estado>
    {
        public bool IsSatisfiedBy(Estado estado)
        {
            return estado.Pais != null;
        }
    }
}