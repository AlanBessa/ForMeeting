using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Paises
{
    public class PaisComNomeLimiteDeCaracteresSpecs : ISpecification<Pais>
    {
        public bool IsSatisfiedBy(Pais pais)
        {
            var validarTamanhoMinimoDoCampoNome = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, pais.Nome);
            var validarTamanhoMaximoDoCampoNome = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(50, pais.Nome);

            return validarTamanhoMinimoDoCampoNome && validarTamanhoMaximoDoCampoNome;
        }
    }
}