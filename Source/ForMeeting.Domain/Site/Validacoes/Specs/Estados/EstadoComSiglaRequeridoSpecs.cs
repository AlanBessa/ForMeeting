using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Estados
{
    public class EstadoComSiglaRequeridoSpecs : ISpecification<Estado>
    {
        public bool IsSatisfiedBy(Estado estado)
        {
            var validarRequerimentoDoCampoSigla = CampoTextoValidation.ValidarSeEhRequerido(estado.Sigla);

            return validarRequerimentoDoCampoSigla;
        }
    }
}