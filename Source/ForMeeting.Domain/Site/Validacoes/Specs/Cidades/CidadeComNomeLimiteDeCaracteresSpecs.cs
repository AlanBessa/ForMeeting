using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Cidades
{
    public class CidadeComNomeLimiteDeCaracteresSpecs : ISpecification<Cidade>
    {
        public bool IsSatisfiedBy(Cidade cidade)
        {
            var validarTamanhoMinimoDoCampoNome = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, cidade.Nome);
            var validarTamanhoMaximoDoCampoNome = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(80, cidade.Nome);

            return validarTamanhoMinimoDoCampoNome && validarTamanhoMaximoDoCampoNome;
        }
    }
}