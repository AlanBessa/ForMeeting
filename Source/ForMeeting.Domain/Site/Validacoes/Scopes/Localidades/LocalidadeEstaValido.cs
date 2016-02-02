using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Validacoes.Specs.Localidades;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Localidades
{
    public class LocalidadeEstaValido : Validator<Localidade>
    {
        public LocalidadeEstaValido()
        {
            var localidadeComNomeRequerido = new LocalidadeComNomeRequeridoSpecs();
            var localidadeComNomeLimiteDeCaracteres = new LocalidadeComNomeLimiteDeCaracteresSpecs();
            var localidadeComLogradouroRequerido = new LocalidadeComLogradouroRequeridoSpecs();
            var localidadeComLogradouroLimiteDeCaracteres = new LocalidadeComLogradouroLimiteDeCaracteresSpecs();
            var localidadeComNumeroRequerido = new LocalidadeComNumeroRequeridoSpecs();
            var localidadeComBairroRequerido = new LocalidadeComBairroRequeridoSpecs();
            var localidadeComBairroLimiteDeCaracteres = new LocalidadeComBairroLimiteDeCaracteresSpecs();
            var localidadeComCidadeRequerido = new LocalidadeComCidadeRequeridoSpecs();
            var localidadeComComplementoMaximoDeCaracteres = new LocalidadeComComplementoMaximoDeCaracteresSpecs();
            var localidadeComCepValido = new LocalidadeComCepValidoSpecs();
            var localidadeComCepDeSeteCaracteres = new LocalidadeComCepDeSeteCaracteresSpecs();
            var localidadeComReferenciaMaximaDeCaracteres = new LocalidadeComReferenciaMaximaDeCaracteresSpecs();

            base.Add("LocalidadeComNomeRequerido", new Rule<Localidade>(localidadeComNomeRequerido, ErrorMessage.LocalidadeNomeObrigatorio));
            base.Add("LocalidadeComNomeLimiteDeCaracteres", new Rule<Localidade>(localidadeComNomeLimiteDeCaracteres, string.Format(ErrorMessage.LocalidadeNomeLimiteDeCaracteres, 3, 100)));
            base.Add("LocalidadeComLogradouroRequerido", new Rule<Localidade>(localidadeComLogradouroRequerido, ErrorMessage.LocalidadeLogradouroObrigatorio));
            base.Add("LocalidadeComLogradouroLimiteDeCaracteres", new Rule<Localidade>(localidadeComLogradouroLimiteDeCaracteres, string.Format(ErrorMessage.LocalidadeLogradouroLimiteDeCaracteres, 3, 200)));
            base.Add("LocalidadeComNumeroRequerido", new Rule<Localidade>(localidadeComNumeroRequerido, ErrorMessage.LocalidadeNumeroObrigatorio));
            base.Add("LocalidadeComBairroRequerido", new Rule<Localidade>(localidadeComBairroRequerido, ErrorMessage.LocalidadeBairroObrigatorio));
            base.Add("LocalidadeComBairroLimiteDeCaracteres", new Rule<Localidade>(localidadeComBairroLimiteDeCaracteres, string.Format(ErrorMessage.LocalidadeBairroLimiteDeCaracteres, 3, 80)));
            base.Add("LocalidadeComCidadeRequerido", new Rule<Localidade>(localidadeComCidadeRequerido, ErrorMessage.LocalidadeCidadeObrigatorio));
            base.Add("LocalidadeComComplementoMaximoDeCaracteres", new Rule<Localidade>(localidadeComComplementoMaximoDeCaracteres, string.Format(ErrorMessage.LocalidadeComComplementoMaximoDeCaracteres, 200)));
            base.Add("LocalidadeComCepInvalido", new Rule<Localidade>(localidadeComCepValido, ErrorMessage.LocalidadeCepInvalido));
            base.Add("LocalidadeComCepDeSeteCaracteres", new Rule<Localidade>(localidadeComCepDeSeteCaracteres, ErrorMessage.LocalidadeCepComSeteCaracteres));
            base.Add("LocalidadeComReferenciaMaximaDeCaracteres", new Rule<Localidade>(localidadeComReferenciaMaximaDeCaracteres, string.Format(ErrorMessage.LocalidadeComReferenciaMaximaDeCaracteres, 500)));
        }
    }
}