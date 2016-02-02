using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Usuarios
{
    public class UsuarioComCampoSenhaLimiteDeCaracteresSpecs : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            var validarTamanhoMinimoDoCampoSenha = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(6, usuario.Senha);
            var validarTamanhoMaximoDoCampoSenha = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(36, usuario.Senha);

            return (validarTamanhoMinimoDoCampoSenha && validarTamanhoMaximoDoCampoSenha);
        }
    }
}
