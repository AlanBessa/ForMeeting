using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Interfaces.Servicos
{
    public interface IAssociadoService : IDisposable
    {
        Associado Adicionar(Associado cliente);

        void Atualizar(Associado cliente);

        void Remover(Guid id);

        Associado ObterPorId(Guid id);

        IEnumerable<Associado> ObterTodos();

        Associado ObterPorCPF(string cpf);
    }
}