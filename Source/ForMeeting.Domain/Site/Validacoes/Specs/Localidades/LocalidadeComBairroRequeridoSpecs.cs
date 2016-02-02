using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComBairroRequeridoSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarRequerimentoDoCampoBairro = CampoTextoValidation.ValidarSeEhRequerido(localidade.Bairro);

            return validarRequerimentoDoCampoBairro;
        }
    }
}