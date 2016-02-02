using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Comentarios
{
    public class ComentarioComAutorRequeridoSpecs : ISpecification<Comentario>
    {
        public bool IsSatisfiedBy(Comentario comentario)
        {
            return comentario.Associado != null;
        }
    }
}