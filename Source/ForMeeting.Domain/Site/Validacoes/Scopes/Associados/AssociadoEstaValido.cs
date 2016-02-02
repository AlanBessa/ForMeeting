using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Validacoes.Specs.Associados;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Associados
{
    public class AssociadoEstaValido : Validator<Associado>
    {
        public AssociadoEstaValido()
        {
            var associadoComCampoNomeValido = new AssociadoComCampoNomeValidoSpecs();
            var associadoPossueCpfValido = new AssociadoPossueCpfValidoSpecs();
            var associadoDeveSerMaiorDe18AnosParaCadastroValido = new AssociadoComDataDeNascimentoValidoSpecs();

            base.Add("AssociadoComCampoNomeValido", new Rule<Associado>(associadoComCampoNomeValido, ErrorMessage.NomeInvalido));
            base.Add("AssociadoPossueCpfValido", new Rule<Associado>(associadoPossueCpfValido, ErrorMessage.CpfInvalido));
            base.Add("AssociadoDeveSerMaiorDe18AnosParaCadastroValido", new Rule<Associado>(associadoDeveSerMaiorDe18AnosParaCadastroValido, ErrorMessage.DataDeNascimentoInvalida));
        }
    }
}