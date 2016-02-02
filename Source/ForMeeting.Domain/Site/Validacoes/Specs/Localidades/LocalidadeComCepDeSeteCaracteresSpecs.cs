using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComCepDeSeteCaracteresSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarTamanhoMinimoDoCampoCep = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(7, localidade.Cep);
            var validarTamanhoMaximoDoCampoCep = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(7, localidade.Cep);

            return (validarTamanhoMinimoDoCampoCep && validarTamanhoMaximoDoCampoCep);
        }
    }
}