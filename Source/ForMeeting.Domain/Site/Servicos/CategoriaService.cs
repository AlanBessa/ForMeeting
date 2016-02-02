using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using ForMeeting.Domain.Site.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Servicos
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public Categoria Adicionar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public Categoria ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _categoriaRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}