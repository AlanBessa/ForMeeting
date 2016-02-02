using ForMeeting.Domain.Site.Interfaces.Repositorios;
using ForMeeting.Infra.CrossCutting.Common.IoC;
using ForMeeting.Infra.Data.Persistencia.Contextos;
using ForMeeting.Infra.Data.Persistencia.Contextos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ForMeeting.Infra.Data.Repositorios
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected ForMeetingContext Db;
        protected DbSet<TEntity> DbSet;

        public BaseRepository()
        {
            var contextManager = ObjectFactory.GetInstance<IContextManager>();
            Db = contextManager.GetContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(ObterPorId(id));
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}