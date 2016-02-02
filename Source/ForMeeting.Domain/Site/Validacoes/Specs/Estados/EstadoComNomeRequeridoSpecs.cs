using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Estados
{
    public class EstadoComNomeRequeridoSpecs : ISpecification<Estado>
    {
        public bool IsSatisfiedBy(Estado estado)
        {
            var validarRequerimentoDoCampoNome = CampoTextoValidation.ValidarSeEhRequerido(estado.Nome);

            return validarRequerimentoDoCampoNome;
        }
    }
}