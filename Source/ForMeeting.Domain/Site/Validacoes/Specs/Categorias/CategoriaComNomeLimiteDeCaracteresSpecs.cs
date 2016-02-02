using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Categorias
{
    public class CategoriaComNomeLimiteDeCaracteresSpecs : ISpecification<Categoria>
    {
        public bool IsSatisfiedBy(Categoria categoria)
        {
            var validarTamanhoMinimoDoCampoNome = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, categoria.Nome);
            var validarTamanhoMaximoDoCampoNome = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(80, categoria.Nome);

            return validarTamanhoMinimoDoCampoNome && validarTamanhoMaximoDoCampoNome;
        }
    }
}