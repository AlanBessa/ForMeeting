using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Usuarios
{
    public class UsuarioComCampoSenhaRequeridoSpecs : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            var validarRequerimentoDoCampoSenha = CampoTextoValidation.ValidarSeEhRequerido(usuario.Senha);

            return validarRequerimentoDoCampoSenha;
        }
    }
}