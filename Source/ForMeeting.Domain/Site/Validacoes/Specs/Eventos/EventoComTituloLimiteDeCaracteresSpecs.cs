using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Eventos
{
    public class EventoComTituloLimiteDeCaracteresSpecs : ISpecification<Evento>
    {
        public bool IsSatisfiedBy(Evento evento)
        {
            var validarTamanhoMinimoDoCampoTitulo = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, evento.Titulo);
            var validarTamanhoMaximoDoCampoTitulo = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(80, evento.Titulo);

            return validarTamanhoMinimoDoCampoTitulo && validarTamanhoMaximoDoCampoTitulo;
        }
    }
}