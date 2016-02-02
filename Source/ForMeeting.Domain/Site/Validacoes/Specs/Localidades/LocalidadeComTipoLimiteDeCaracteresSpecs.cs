using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComTipoLimiteDeCaracteresSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarTamanhoMinimoDoCampoTipo = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, localidade.TipoDaLocalidade);
            var validarTamanhoMaximoDoCampoTipo = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(100, localidade.TipoDaLocalidade);

            return (validarTamanhoMinimoDoCampoTipo && validarTamanhoMaximoDoCampoTipo);
        }
    }
}