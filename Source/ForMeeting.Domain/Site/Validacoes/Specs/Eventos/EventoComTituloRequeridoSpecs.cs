using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Eventos
{
    public class EventoComTituloRequeridoSpecs : ISpecification<Evento>
    {
        public bool IsSatisfiedBy(Evento evento)
        {
            var validarRequerimentoDoCampoTitulo = CampoTextoValidation.ValidarSeEhRequerido(evento.Titulo);

            return validarRequerimentoDoCampoTitulo;
        }
    }
}