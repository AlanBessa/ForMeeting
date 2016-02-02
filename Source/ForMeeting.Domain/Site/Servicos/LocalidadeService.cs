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
    public class LocalidadeService : ILocalidadeService
    {
        private readonly ILocalidadeRepository _localidadeRepository;

        public LocalidadeService(ILocalidadeRepository localidadeRepository)
        {
            _localidadeRepository = localidadeRepository;
        }

        public Localidade Adicionar(Localidade localidade)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Localidade localidade)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public Localidade ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Localidade> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _localidadeRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
