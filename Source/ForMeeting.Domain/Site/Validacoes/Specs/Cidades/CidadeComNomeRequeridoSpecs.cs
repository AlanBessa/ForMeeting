﻿using DomainValidation.Interfaces.Specification;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.SharedKernel.Validacoes;

namespace ForMeeting.Domain.Site.Validacoes.Specs.Cidades
{
    public class CidadeComNomeRequeridoSpecs : ISpecification<Cidade>
    {
        public bool IsSatisfiedBy(Cidade cidade)
        {
            var validarRequerimentoDoCampoNome = CampoTextoValidation.ValidarSeEhRequerido(cidade.Nome);

            return validarRequerimentoDoCampoNome;
        }
    }
}