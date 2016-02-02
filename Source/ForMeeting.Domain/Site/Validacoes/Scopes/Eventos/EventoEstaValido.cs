using DomainValidation.Validation;
using ForMeeting.Domain.Site.Entidades;
using ForMeeting.Domain.Site.Validacoes.Specs.Eventos;
using ForMeeting.SharedKernel.Recursos;

namespace ForMeeting.Domain.Site.Validacoes.Scopes.Eventos
{
    public class EventoEstaValido : Validator<Evento>
    {
        public EventoEstaValido()
        {
            var eventoComTituloRequerido = new EventoComTituloRequeridoSpecs();
            var eventoComTituloLimiteDeCaracteres = new EventoComTituloLimiteDeCaracteresSpecs();
            var eventoComDescricaoRequerido = new EventoComDescricaoRequeridoSpecs();
            var eventoComDescricaoLimiteDeCaracteres = new EventoComDescricaoLimiteDeCaracteresSpecs();
            var eventoComCriadorRequerido = new EventoComCriadorRequeridoSpecs();
            var eventoComLocalidadeRequerido = new EventoComLocalidadeRequeridoSpecs();

            base.Add("EventoComTituloRequerido", new Rule<Evento>(eventoComTituloRequerido, ErrorMessage.EventoTituloObrigatorio));
            base.Add("EventoComTituloLimiteDeCaracteres", new Rule<Evento>(eventoComTituloLimiteDeCaracteres, string.Format(ErrorMessage.EventoTituloLimiteDeCaracteres, 3, 80)));
            base.Add("EventoComDescricaoRequerido", new Rule<Evento>(eventoComDescricaoRequerido, ErrorMessage.EventoDescricaoObrigatorio));
            base.Add("EventoComDescricaoLimiteDeCaracteres", new Rule<Evento>(eventoComDescricaoLimiteDeCaracteres, string.Format(ErrorMessage.EventoDescricaoLimiteDeCaracteres, 3, 1000)));
            base.Add("EventoComCriadorRequerido", new Rule<Evento>(eventoComCriadorRequerido, ErrorMessage.EventoCriadorObrigatorio));
            base.Add("EventoComLocalidadeRequerido", new Rule<Evento>(eventoComLocalidadeRequerido, ErrorMessage.EventoLocalidadeObrigatorio));
        }
    }
}