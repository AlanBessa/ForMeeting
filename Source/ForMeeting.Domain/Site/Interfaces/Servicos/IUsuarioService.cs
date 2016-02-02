using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Interfaces.Servicos
{
    public interface IUsuarioService : IDisposable
    {
        Usuario Adicionar(Usuario cliente);

        void Atualizar(Usuario cliente);

        void Remover(Guid id);

        Usuario ObterPorId(Guid id);

        IEnumerable<Usuario> ObterTodos();

        Usuario ObterPorEmail(string email);
    }
}