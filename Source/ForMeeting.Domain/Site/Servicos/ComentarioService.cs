using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using ForMeeting.Domain.Site.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMeeting.Domain.Site.Servicos
{
    public class ComentarioService : IComentarioService
    {
        private readonly IComentarioRepository _comentarioRepository;

        public ComentarioService(IComentarioRepository comentarioRepository)
        {
            _comentarioRepository = comentarioRepository;
        }

        public Comentario Adicionar(Comentario comentario)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Comentario comentario)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public Comentario ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comentario> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comentario> ObterTodosPorEventoId(Guid idEvento)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _comentarioRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
