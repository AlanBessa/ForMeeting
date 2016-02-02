using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComComplementoMaximoDeCaracteresSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            if (string.IsNullOrEmpty(localidade.Complemento)) return true;

            var validarTamanhoMaximoDoCampoComplemento = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(200, localidade.Complemento);

            return validarTamanhoMaximoDoCampoComplemento;
        }
    }
}