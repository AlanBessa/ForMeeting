using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using ForMeeting.Domain.Site.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Servicos
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario Adicionar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Usuario ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _usuarioRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}