using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComReferenciaMaximaDeCaracteresSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            if (string.IsNullOrEmpty(localidade.Referencias)) return true;

            var validarTamanhoMaximoDoCampoReferencia = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(500, localidade.Referencias);

            return validarTamanhoMaximoDoCampoReferencia;
        }
    }
}