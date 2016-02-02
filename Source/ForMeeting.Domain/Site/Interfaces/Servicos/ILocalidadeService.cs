using ForMeeting.Domain.Site.Entidades;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Interfaces.Servicos
{
    public interface ILocalidadeService : IDisposable
    {
        Localidade Adicionar(Localidade localidade);

        void Atualizar(Localidade localidade);

        void Remover(Guid id);

        Localidade ObterPorId(Guid id);

        IEnumerable<Localidade> ObterTodos();
    }
}