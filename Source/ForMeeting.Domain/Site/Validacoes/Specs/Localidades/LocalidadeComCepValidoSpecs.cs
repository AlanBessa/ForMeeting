using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Localidades
{
    public class LocalidadeComCepValidoSpecs : ISpecification<Localidade>
    {
        public bool IsSatisfiedBy(Localidade localidade)
        {
            var validarFormatacaoDoCampoCep = CepValidation.Validar(localidade.Cep);

            return string.IsNullOrEmpty(localidade.Cep) || validarFormatacaoDoCampoCep;
        }
    }
}