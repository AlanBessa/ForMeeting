using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Comentarios
{
    public class ComentarioComDescricaoLimiteDeCaracteresSpecs : ISpecification<Comentario>
    {
        public bool IsSatisfiedBy(Comentario comentario)
        {
            var validarTamanhoMinimoDoCampoDescricao = CampoTextoValidation.ValidarTamanhoMinimoDoTexto(3, comentario.Descricao);
            var validarTamanhoMaximoDoCampoDescricao = CampoTextoValidation.ValidarTamanhoMaximoDoTexto(1000, comentario.Descricao);

            return (validarTamanhoMinimoDoCampoDescricao && validarTamanhoMaximoDoCampoDescricao);
        }
    }
}