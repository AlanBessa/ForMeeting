using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Eventos
{
    public class EventoComCriadorRequeridoSpecs : ISpecification<Evento>
    {
        public bool IsSatisfiedBy(Evento evento)
        {
            return evento.Criador != null;
        }
    }
}