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
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoService(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public Evento Adicionar(Evento evento)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Evento evento)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public Evento ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _eventoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
