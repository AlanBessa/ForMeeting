using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Estados
{
    public class EstadoComSiglaLimiteDeCaracteresSpecs : ISpecification<Estado>
    {
        public bool IsSatisfiedBy(Estado estado)
        {
            var validarTamanhoMinimoDoCampoSigla = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(2, estado.Sigla);
            var validarTamanhoMaximoDoCampoSigla = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(2, estado.Sigla);

            return (validarTamanhoMinimoDoCampoSigla && validarTamanhoMaximoDoCampoSigla);
        }
    }
}