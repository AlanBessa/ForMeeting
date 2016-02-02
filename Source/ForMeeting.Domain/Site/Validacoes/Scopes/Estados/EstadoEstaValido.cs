using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Validacoes.Specs.Estados;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Estados
{
    public class EstadoEstaValido : Validator<Estado>
    {
        public EstadoEstaValido()
        {
            var estadoComNomeRequerido = new EstadoComNomeRequeridoSpecs();
            var estadoComNomeLimiteDeCaracteres = new EstadoComNomeLimiteDeCaracteresSpecs();
            var estadoComSiglaRequerido = new EstadoComSiglaRequeridoSpecs();
            var estadoComSiglaLimiteDeCaracteres = new EstadoComSiglaLimiteDeCaracteresSpecs();
            var estadoComPaisRequerido = new EstadoComPaisRequeridoSpecs();

            base.Add("EstadoComNomeRequerido", new Rule<Estado>(estadoComNomeRequerido, ErrorMessage.EstadoNomeObrigatorio));
            base.Add("EstadoComNomeLimiteDeCaracteres", new Rule<Estado>(estadoComNomeLimiteDeCaracteres, ErrorMessage.EstadoNomeLimiteDeCaracteres));
            base.Add("EstadoComSiglaRequerido", new Rule<Estado>(estadoComSiglaRequerido, ErrorMessage.EstadoSiglaObrigatorio));
            base.Add("EstadoComSiglaLimiteDeCaracteres", new Rule<Estado>(estadoComSiglaLimiteDeCaracteres, ErrorMessage.EstadoSiglaLimiteDeCaracteres));
            base.Add("EstadoComPaisRequerido", new Rule<Estado>(estadoComPaisRequerido, ErrorMessage.PaisObrigatorio));
        }
    }
}