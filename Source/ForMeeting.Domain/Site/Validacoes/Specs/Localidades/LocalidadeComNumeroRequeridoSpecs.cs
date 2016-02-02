using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComNumeroRequeridoSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarRequerimentoDoCampoNumero = CampoInteiroValidation.ValidarSeEhMaiorQueZero(localidade.Numero);

            return validarRequerimentoDoCampoNumero;
        }
    }
}