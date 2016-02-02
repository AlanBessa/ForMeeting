using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Interfaces.Servicos
{
    public interface IPaisService : IDisposable
    {
        Pais Adicionar(Pais evento);

        void Atualizar(Pais evento);

        void Remover(Guid id);

        Pais ObterPorId(Guid id);

        IEnumerable<Pais> ObterTodos();
    }
}