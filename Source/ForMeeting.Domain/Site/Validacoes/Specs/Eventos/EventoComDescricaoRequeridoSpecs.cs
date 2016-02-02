using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Eventos
{
    public class EventoComDescricaoRequeridoSpecs : ISpecification<Evento>
    {
        public bool IsSatisfiedBy(Evento evento)
        {
            var validarRequerimentoDoCampoDescricao = CampoTextoValidation.ValidarSeEhRequerido(evento.Descricao);

            return validarRequerimentoDoCampoDescricao;
        }
    }
}