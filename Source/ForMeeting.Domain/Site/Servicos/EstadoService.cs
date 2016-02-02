using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using ForMeeting.Domain.Site.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Servicos
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public Estado Adicionar(Estado estado)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Estado estado)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public Estado ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estado> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _estadoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}