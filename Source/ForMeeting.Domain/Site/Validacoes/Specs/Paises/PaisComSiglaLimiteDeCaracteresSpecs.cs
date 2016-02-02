using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Paises
{
    public class PaisComSiglaLimiteDeCaracteresSpecs : ISpecification<Pais>
    {
        public bool IsSatisfiedBy(Pais pais)
        {
            if (string.IsNullOrEmpty(pais.Sigla)) return true;

            var validarTamanhoMinimoDoCampoSigla = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(2, pais.Sigla);
            var validarTamanhoMaximoDoCampoSigla = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(3, pais.Sigla);

            return validarTamanhoMinimoDoCampoSigla && validarTamanhoMaximoDoCampoSigla;
        }
    }
}