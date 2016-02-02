using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Categorias
{
    public class CategoriaComNomeRequeridoSpecs : ISpecification<Categoria>
    {
        public bool IsSatisfiedBy(Categoria categoria)
        {
            var validarRequerimentoDoCampoNome = CampoTextoValidation.ValidarSeEhRequerido(categoria.Nome);

            return validarRequerimentoDoCampoNome;
        }
    }
}