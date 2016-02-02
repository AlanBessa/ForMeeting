using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComBairroLimiteDeCaracteresSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarTamanhoMinimoDoCampoBairro = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, localidade.Bairro);
            var validarTamanhoMaximoDoCampoBairro = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(80, localidade.Bairro);

            return (validarTamanhoMinimoDoCampoBairro && validarTamanhoMaximoDoCampoBairro);
        }
    }
}