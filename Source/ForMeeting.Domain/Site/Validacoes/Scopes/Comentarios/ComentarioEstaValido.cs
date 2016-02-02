using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Validacoes.Specs.Comentarios;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Comentarios
{
    public class ComentarioEstaValido : Validator<Comentario>
    {
        public ComentarioEstaValido()
        {
            var comentarioComDescricaoValida = new ComentarioComDescricaoValidaSpecs();
            var comentarioComDescricaoLimiteDeCarecteres = new ComentarioComDescricaoLimiteDeCaracteresSpecs();
            var comentarioComEventoRequerido = new ComentarioComEventoRequeridoSpecs();
            var comentarioComAutorRequerido = new ComentarioComAutorRequeridoSpecs();

            base.Add("ComentarioComDescricaoValida", new Rule<Comentario>(comentarioComDescricaoValida, ErrorMessage.ComentarioInvalido));
            base.Add("ComentarioComDescricaoLimiteDeCaracteres", new Rule<Comentario>(comentarioComDescricaoLimiteDeCarecteres, string.Format(ErrorMessage.ComentarioDescricaoLimiteDeCaracteres, 3, 1000)));
            base.Add("ComentarioComEventoRequerido", new Rule<Comentario>(comentarioComEventoRequerido, ErrorMessage.EventoObrigatorio));
            base.Add("ComentarioComAutorRequerido", new Rule<Comentario>(comentarioComAutorRequerido, ErrorMessage.AssociadoObrigatorio));
        }
    }
}