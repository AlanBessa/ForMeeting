using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Interfaces.Repositorios;
using System;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Associados
{
    public class AssociadoDevePossuirCpfUnicoCadastradoSpecs : ISpecification<Associado>
    {
        private readonly IAssociadoRepository _associadoRepository;

        public AssociadoDevePossuirCpfUnicoCadastradoSpecs(IAssociadoRepository associadoRepository)
        {
            _associadoRepository = associadoRepository;
        }

        public bool IsSatisfiedBy(Associado associado)
        {
            throw new NotImplementedException();
        }
    }
}