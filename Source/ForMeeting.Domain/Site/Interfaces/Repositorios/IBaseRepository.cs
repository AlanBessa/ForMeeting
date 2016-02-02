using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ForMeeting.Domain.Site.Interfaces.Repositorios
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity obj);

        void Atualizar(TEntity obj);

        void Remover(Guid id);

        TEntity ObterPorId(Guid id);

        IEnumerable<TEntity> ObterTodos();

        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);

        int SaveChanges();
    }
}