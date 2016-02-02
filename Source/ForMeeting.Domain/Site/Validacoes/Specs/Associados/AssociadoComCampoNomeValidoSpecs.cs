using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Associados
{
    public class AssociadoComCampoNomeValidoSpecs : ISpecification<Associado>
    {
        public bool IsSatisfiedBy(Associado associado)
        {
            var validarRequerimentoDoCampoNome = CampoTextoValidation.ValidarSeEhRequerido(associado.Nome);
            var validarTamanhoDoCampoNome = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(100, associado.Nome);

            return validarRequerimentoDoCampoNome && validarTamanhoDoCampoNome;
        }
    }
}