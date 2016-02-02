using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComTipoRequeridoSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarRequerimentoDoCampoTipo = CampoTextoValidation.ValidarSeEhRequerido(localidade.TipoDaLocalidade);

            return validarRequerimentoDoCampoTipo;
        }
    }
}