using ForMeeting.Infra.CrossCutting.Common.IoC;
using ForMeeting.Infra.Data.Persistencia.Contextos;
using ForMeeting.Infra.Data.Persistencia.Contextos.Interfaces;
using ForMeeting.Infra.Data.UnitOfWork.Interface;
using System;

namespace ForMeeting.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ForMeetingContext _dbContext;
        private bool _disposed;

        public UnitOfWork()
        {
            var contextManager = ObjectFactory.GetInstance<IContextManager>();
            _dbContext = contextManager.GetContext();
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}