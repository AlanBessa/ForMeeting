using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Interfaces.Servicos
{
    public interface ICidadeService : IDisposable
    {
        Cidade Adicionar(Cidade evento);

        void Atualizar(Cidade evento);

        void Remover(Guid id);

        Cidade ObterPorId(Guid id);

        IEnumerable<Cidade> ObterTodos();
    }
}