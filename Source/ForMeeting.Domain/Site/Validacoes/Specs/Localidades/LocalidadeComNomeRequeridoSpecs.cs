using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComNomeRequeridoSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarRequerimentoDoCampoNome = CampoTextoValidation.ValidarSeEhRequerido(localidade.NomeDaLocalidade);

            return validarRequerimentoDoCampoNome;
        }
    }
}