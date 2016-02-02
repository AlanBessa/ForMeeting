using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Validacoes.Specs.Paises;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Paises
{
    public class PaisEstaValido : Validator<Pais>
    {
        public PaisEstaValido()
        {
            var paisComNomeRequerido = new PaisComNomeRequeridoSpecs();
            var paisComNomeLimiteDeCaracteres = new PaisComNomeLimiteDeCaracteresSpecs();
            var paisComSiglaLimiteDeCaracteres = new PaisComSiglaLimiteDeCaracteresSpecs();

            base.Add("PaisComNomeRequerido", new Rule<Pais>(paisComNomeRequerido, ErrorMessage.CategoriaNomeObrigatorio));
            base.Add("PaisComNomeLimiteDeCaracteres", new Rule<Pais>(paisComNomeLimiteDeCaracteres, string.Format(ErrorMessage.PaisNomeLimiteDeCaracteres, 3, 50)));
            base.Add("PaisComSiglaLimiteDeCaracteres", new Rule<Pais>(paisComSiglaLimiteDeCaracteres, string.Format(ErrorMessage.PaisSiglaLimiteDeCaracteres, 2, 3)));
        }
    }
}