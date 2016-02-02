using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Usuarios
{
    public class UsuarioComCampoEmailValidoSpecs : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            var validarFormatacaoDoCampoEmail = EmailValidation.Validar(usuario.Email);

            return validarFormatacaoDoCampoEmail;
        }
    }
}