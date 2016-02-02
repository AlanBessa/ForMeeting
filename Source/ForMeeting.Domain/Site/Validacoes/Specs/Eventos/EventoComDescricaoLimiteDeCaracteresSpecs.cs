using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Eventos
{
    public class EventoComDescricaoLimiteDeCaracteresSpecs : ISpecification<Evento>
    {
        public bool IsSatisfiedBy(Evento evento)
        {
            var validarTamanhoMinimoDoCampoDescricao = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, evento.Descricao);
            var validarTamanhoMaximoDoCampoDescricao = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(1000, evento.Descricao);

            return (validarTamanhoMinimoDoCampoDescricao && validarTamanhoMaximoDoCampoDescricao);
        }
    }
}