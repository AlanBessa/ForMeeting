using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Usuarios
{
    public class UsuarioComCampoEmailLimiteDeCaracteresSpecs : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            var validarTamanhoMinimoDoCampoEmail = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, usuario.Email);
            var validarTamanhoMaximoDoCampoEmail = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(80, usuario.Email);

            return (validarTamanhoMinimoDoCampoEmail && validarTamanhoMaximoDoCampoEmail);
        }
    }
}