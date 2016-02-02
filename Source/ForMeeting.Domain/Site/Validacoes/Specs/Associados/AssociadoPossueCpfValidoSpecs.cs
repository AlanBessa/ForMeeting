using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Associados
{
    public class AssociadoPossueCpfValidoSpecs : ISpecification<Associado>
    {
        public bool IsSatisfiedBy(Associado associado)
        {
            var cpfRequerido = CampoTextoValidation.ValidarSeEhRequerido(associado.CPF);
            var cpfComFormatoValido = CpfValidation.Validar(associado.CPF);

            return cpfRequerido && cpfComFormatoValido;
        }
    }
}