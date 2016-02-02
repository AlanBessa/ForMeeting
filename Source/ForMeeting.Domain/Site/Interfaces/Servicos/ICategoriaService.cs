using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Interfaces.Servicos
{
    public interface ICategoriaService : IDisposable
    {
        Categoria Adicionar(Categoria evento);

        void Atualizar(Categoria evento);

        void Remover(Guid id);

        Categoria ObterPorId(Guid id);

        IEnumerable<Categoria> ObterTodos();
    }
}