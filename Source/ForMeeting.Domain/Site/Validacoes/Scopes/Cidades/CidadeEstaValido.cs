using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Validacoes.Specs.Cidades;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Cidades
{
    public class CidadeEstaValido : Validator<Cidade>
    {
        public CidadeEstaValido()
        {
            var cidadeComNomeRequerido = new CidadeComNomeRequeridoSpecs();
            var cidadeComNomeLimiteDeCaracteres = new CidadeComNomeLimiteDeCaracteresSpecs();
            var cidadeComEstadoRequerido = new CidadeComEstadoRequeridoSpecs();

            base.Add("CidadeComNomeRequerido", new Rule<Cidade>(cidadeComNomeRequerido, ErrorMessage.CidadeNomeObrigatorio));
            base.Add("CidadeComNomeLimiteDeCaracteres", new Rule<Cidade>(cidadeComNomeLimiteDeCaracteres, ErrorMessage.CidadeNomeLimiteDeCaracteres));
            base.Add("CidadeComEstadoRequerido", new Rule<Cidade>(cidadeComEstadoRequerido, ErrorMessage.EstadoObrigatorio));
        }
    }
}