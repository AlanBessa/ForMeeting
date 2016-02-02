using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComEventoObrigatorioSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            return localidade.Evento != null;
        }
    }
}