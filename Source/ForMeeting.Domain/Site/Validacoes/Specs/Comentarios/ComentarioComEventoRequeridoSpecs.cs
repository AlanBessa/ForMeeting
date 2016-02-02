using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Comentarios
{
    public class ComentarioComEventoRequeridoSpecs : ISpecification<Comentario>
    {
        public bool IsSatisfiedBy(Comentario comentario)
        {
            return comentario.Evento != null;
        }
    }
}