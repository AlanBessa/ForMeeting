using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Interfaces.Servicos
{
    public interface IEventoService : IDisposable
    {
        Evento Adicionar(Evento evento);

        void Atualizar(Evento evento);

        void Remover(Guid id);

        Evento ObterPorId(Guid id);

        IEnumerable<Evento> ObterTodos();
    }
}