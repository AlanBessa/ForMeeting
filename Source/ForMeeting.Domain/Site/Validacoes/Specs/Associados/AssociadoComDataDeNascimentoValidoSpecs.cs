using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;
using System;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Associados
{
    public class AssociadoComDataDeNascimentoValidoSpecs : ISpecification<Associado>
    {
        public bool IsSatisfiedBy(Associado associado)
        {
            var dataRequerida = DataValidation.ValidarSeCampoNaoEhNulo(associado.DataDeNascimento);
            var dataDeveCorresponderAUmMaiorDeIdade = DataValidation.ValidarSeDataEhMenorQue(associado.DataDeNascimento.Value, DateTime.Now.AddYears(-18));

            return (dataRequerida && dataDeveCorresponderAUmMaiorDeIdade);
        }
    }
}