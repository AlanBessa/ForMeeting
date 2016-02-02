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
            var localidadeComNomeMinimodeTresCaracteres = new LocalidadeComNomeLimiteDeCaracteresSpecs();
            var localidadeComTipoRequerido = new LocalidadeComTipoRequeridoSpecs();
            var localidadeComTipoMinimodeTresCaracteres = new LocalidadeComTipoLimiteDeCaracteresSpecs();
            var localidadeComLogradouroRequerido = new LocalidadeComLogradouroRequeridoSpecs();
            var localidadeComNumeroRequerido = new LocalidadeComNumeroRequeridoSpecs();
            var localidadeComBairroRequerido = new LocalidadeComBairroRequeridoSpecs();
            var localidadeComCidadeRequerido = new LocalidadeComCidadeRequeridoSpecs();
            var localidadeComCepValido = new LocalidadeComCepValidoSpecs();
            var localidadeComEventoObrigatorio = new LocalidadeComEventoObrigatorioSpecs();

            base.Add("LocalidadeComNomeRequerido", new Rule<Localidade>(localidadeComNomeRequerido, ErrorMessage.LocalidadeNomeObrigatorio));
            base.Add("LocalidadeComNomeMinimodeTresCaracteres", new Rule<Localidade>(localidadeComNomeMinimodeTresCaracteres, string.Format(ErrorMessage.LocalidadeNomeLimiteDeCaracteres, 3, 100)));
            base.Add("LocalidadeComTipoRequerido", new Rule<Localidade>(localidadeComTipoRequerido, ErrorMessage.LocalidadeTipoObrigatorio));
            base.Add("LocalidadeComTipoMinimodeTresCaracteres", new Rule<Localidade>(localidadeComTipoMinimodeTresCaracteres, string.Format(ErrorMessage.LocalidadeTipoLimiteDeCaracteres, 3, 100)));
            base.Add("LocalidadeComLogradouroRequerido", new Rule<Localidade>(localidadeComLogradouroRequerido, ErrorMessage.LocalidadeLogradouroObrigatorio));
            base.Add("LocalidadeComNumeroRequerido", new Rule<Localidade>(localidadeComNumeroRequerido, ErrorMessage.LocalidadeNumeroObrigatorio));
            base.Add("LocalidadeComBairroRequerido", new Rule<Localidade>(localidadeComBairroRequerido, ErrorMessage.LocalidadeBairroObrigatorio));
            base.Add("LocalidadeComCidadeRequerido", new Rule<Localidade>(localidadeComCidadeRequerido, ErrorMessage.LocalidadeCidadeObrigatorio));
            base.Add("LocalidadeComCepInvalido", new Rule<Localidade>(localidadeComCepValido, ErrorMessage.LocalidadeCepInvalido));
            base.Add("LocalidadeComEventoObrigatorio", new Rule<Localidade>(localidadeComEventoObrigatorio, ErrorMessage.EventoObrigatorio));
        }
    }
}