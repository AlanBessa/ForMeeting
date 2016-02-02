using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using ForMeeting.Domain.Site.Interfaces.Servicos;
using ForMeeting.Domain.Site.Validacoes.Scopes.Associados;
using System;
using System.Collections.Generic;

namespace ForMeeting.Domain.Site.Servicos
{
    public class AssociadoService : IAssociadoService
    {
        private readonly IAssociadoRepository _associadoRepository;

        public AssociadoService(IAssociadoRepository associadoRepository)
        {
            _associadoRepository = associadoRepository;
        }

        public Associado Adicionar(Associado associado)
        {
            if (!associado.IsValid())
            {
                return associado;
            }

            //Se eu precisar fazer alguma validação que faz requisição no banco
            var result = new AssociadoEstaAptoParaCadastro(_associadoRepository).Validate(associado);

            if (!result.IsValid)
            {
                associado.ValidationResult = result;
                return associado;
            }

            _associadoRepository.Adicionar(associado);

            return associado;
        }

        public void Atualizar(Associado associado)
        {
            _associadoRepository.Atualizar(associado);
        }

        public void Remover(Guid id)
        {
            _associadoRepository.Remover(id);
        }

        public Associado ObterPorId(Guid id)
        {
            return _associadoRepository.ObterPorId(id);
        }

        public IEnumerable<Associado> ObterTodos()
        {
            return _associadoRepository.ObterTodos();
        }

        public Associado ObterPorCPF(string cpf)
        {
            return _associadoRepository.ObterPorCPF(cpf);
        }

        public void Dispose()
        {
            _associadoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}