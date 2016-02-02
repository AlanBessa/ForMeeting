using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Validacoes.Specs.Categorias;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Categorias
{
    public class CategoriaEstaValido : Validator<Categoria>
    {
        public CategoriaEstaValido()
        {
            var categoriaComNomeRequerido = new CategoriaComNomeRequeridoSpecs();
            var categoriaComNomeLimiteDeCaracteres = new CategoriaComNomeLimiteDeCaracteresSpecs();

            base.Add("CategoriaComNomeRequerido", new Rule<Categoria>(categoriaComNomeRequerido, ErrorMessage.CategoriaNomeObrigatorio));
            base.Add("CategoriaComNomeLimiteDeCaracteres", new Rule<Categoria>(categoriaComNomeLimiteDeCaracteres, ErrorMessage.CategoriaNomeLimiteDeCaracteres));
        }
    }
}