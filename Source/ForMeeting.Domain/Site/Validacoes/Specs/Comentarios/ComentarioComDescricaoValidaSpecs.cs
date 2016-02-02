using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Comentarios
{
    public class ComentarioComDescricaoValidaSpecs : ISpecification<Comentario>
    {
        public bool IsSatisfiedBy(Comentario comentario)
        {
            var validarRequerimentoDoCampoDescricao = CampoTextoValidation.ValidarSeEhRequerido(comentario.Descricao);

            return validarRequerimentoDoCampoDescricao;
        }
    }
}