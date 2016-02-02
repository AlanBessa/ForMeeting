using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Interfaces.Servicos
{
    public interface IEstadoService : IDisposable
    {
        Estado Adicionar(Estado evento);

        void Atualizar(Estado evento);

        void Remover(Guid id);

        Estado ObterPorId(Guid id);

        IEnumerable<Estado> ObterTodos();
    }
}