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
            var usuarioComCampoEmailLimiteDeCaracteres = new UsuarioComCampoEmailLimiteDeCaracteresSpecs();
            var usuarioComCampoEmailValido = new UsuarioComCampoEmailValidoSpecs();
            var usuarioComCampoSenhaRequerido = new UsuarioComCampoSenhaRequeridoSpecs();
            var usuarioComCampoSenhaLimiteDeCaracteres = new UsuarioComCampoSenhaLimiteDeCaracteresSpecs();

            base.Add("UsuarioComCampoEmailRequerido", new Rule<Usuario>(usuarioComCampoEmailRequerido, ErrorMessage.EmailObrigatorio));
            base.Add("UsuarioComCampoEmailLimiteDeCaracteres", new Rule<Usuario>(usuarioComCampoEmailLimiteDeCaracteres, string.Format(ErrorMessage.UsuarioEmailLimiteDeCaracteres, 8, 160)));
            base.Add("UsuarioComCampoEmailValido", new Rule<Usuario>(usuarioComCampoEmailValido, ErrorMessage.EmailInvalido));
            base.Add("UsuarioComCampoSenhaRequerido", new Rule<Usuario>(usuarioComCampoSenhaRequerido, ErrorMessage.SenhaObrigatorio));
            base.Add("UsuarioComCampoSenhaLimiteDeCaracteres", new Rule<Usuario>(usuarioComCampoSenhaLimiteDeCaracteres, string.Format(ErrorMessage.UsuarioSenhaLimiteDeCaracteres, 6, 36)));
        }
    }
}