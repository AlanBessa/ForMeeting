using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Interfaces.Servicos
{
    public interface IComentarioService : IDisposable
    {
        Comentario Adicionar(Comentario comentario);

        void Atualizar(Comentario comentario);

        void Remover(Guid id);

        Comentario ObterPorId(Guid id);

        IEnumerable<Comentario> ObterTodos();

        IEnumerable<Comentario> ObterTodosPorEventoId(Guid idEvento);
    }
}