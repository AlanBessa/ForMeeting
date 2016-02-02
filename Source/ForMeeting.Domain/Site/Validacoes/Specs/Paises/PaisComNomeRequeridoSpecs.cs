using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Paises
{
    public class PaisComNomeRequeridoSpecs : ISpecification<Pais>
    {
        public bool IsSatisfiedBy(Pais pais)
        {
            var validarRequerimentoDoCampoNome = CampoTextoValidation.ValidarSeEhRequerido(pais.Nome);

            return validarRequerimentoDoCampoNome;
        }
    }
}