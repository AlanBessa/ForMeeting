using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using ForMeeting.Domain.Site.Validacoes.Specs.Usuarios;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Usuarios
{
    public class UsuarioAptoParaCadastro : Validator<Usuario>
    {
        public UsuarioAptoParaCadastro(IUsuarioRepository usuarioRepository)
        {
            var usuarioDevePossuirEmailUnicoCadastrado = new UsuarioDevePossuirEmailUnicoCadastradoSpecs(usuarioRepository);

            base.Add("UsuarioDevePossuirEmailUnicoCadastrado", new Rule<Usuario>(usuarioDevePossuirEmailUnicoCadastrado, ErrorMessage.EmailJaCadastrado));
        }
    }
}