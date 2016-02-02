using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using ForMeeting.Domain.Site.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Servicos
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public Cidade Adicionar(Cidade cidade)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Cidade cidade)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public Cidade ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cidade> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _cidadeRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}