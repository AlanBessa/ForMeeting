using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComLogradouroLimiteDeCaracteresSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarTamanhoMinimoDoCampoLogradouro = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, localidade.Logradouro);
            var validarTamanhoMaximoDoCampoLogradouro = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(200, localidade.Logradouro);

            return (validarTamanhoMinimoDoCampoLogradouro && validarTamanhoMaximoDoCampoLogradouro);
        }
    }
}