using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComNomeLimiteDeCaracteresSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarTamanhoMinimoDoCampoNome = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, localidade.NomeDaLocalidade);
            var validarTamanhoMaximoDoCampoNome = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(100, localidade.NomeDaLocalidade);

            return validarTamanhoMinimoDoCampoNome && validarTamanhoMaximoDoCampoNome;
        }
    }
}