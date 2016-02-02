using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Validacoes.Specs.Usuarios;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Usuarios
{
    public class UsuarioEstaValido : Validator<Usuario>
    {
        public UsuarioEstaValido()
        {
            var usuarioComCampoEmailRequerido = new UsuarioComCampoEmailRequeridoSpecs();
            var usuarioComCampoEmailValido = new UsuarioComCampoEmailValidoSpecs();

            base.Add("UsuarioComCampoEmailRequerido", new Rule<Usuario>(usuarioComCampoEmailRequerido, ErrorMessage.EmailObrigatorio));
            base.Add("UsuarioComCampoEmailValido", new Rule<Usuario>(usuarioComCampoEmailValido, ErrorMessage.EmailInvalido));
        }
    }
}