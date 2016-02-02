using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Estados
{
    public class EstadoComNomeLimiteDeCaracteresSpecs : ISpecification<Estado>
    {
        public bool IsSatisfiedBy(Estado estado)
        {
            var validarTamanhoMinimoDoCampoNome = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, estado.Nome);
            var validarTamanhoMaximoDoCampoNome = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(60, estado.Nome);

            return validarTamanhoMinimoDoCampoNome && validarTamanhoMaximoDoCampoNome;
        }
    }
}