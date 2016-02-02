using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using ForMeeting.Domain.Site.Validacoes.Specs.Associados;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Associados
{
    public class AssociadoEstaAptoParaCadastro : Validator<Associado>
    {
        public AssociadoEstaAptoParaCadastro(IAssociadoRepository associadoRepository)
        {
            var associadoDevePossuirCPFUnicoCadastrado = new AssociadoDevePossuirCpfUnicoCadastradoSpecs(associadoRepository);

            base.Add("AssociadoDevePossuirCPFUnicoCadastrado", new Rule<Associado>(associadoDevePossuirCPFUnicoCadastrado, ErrorMessage.CpfJaCadastrado));
        }
    }
}