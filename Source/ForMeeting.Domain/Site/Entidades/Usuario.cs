using DomainValidation.Validation;
using ForMeeting.Domain.Site.Enum;
using ForMeeting.Domain.Site.Validacoes.Scopes.Usuarios;
using ForMeeting.SharedKernel.Criptografias;
using System;

namespace ForMeeting.Domain.Site.Entidades
{
    public class Usuario
    {
        public Usuario(string email, string senha)
        {
            IdUsuario = Guid.NewGuid();
            Email = email;
            Senha = senha;
            Verificado = false;
            Ativo = false;
            UltimaDataDeLogin = DateTime.Now;
            Papel = PapelEnum.Usuario;
            CodigoDeVerificacao = Guid.NewGuid().ToString().Substring(0, 6).ToUpper();
            CodigoDeAtivacao = Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            CodigoDeAutorizacao = string.Empty;
            DataDoUltimoRequestDoCodigoDeAutorizacao = DateTime.Now.AddMinutes(5);
        }

        public Guid IdUsuario { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public bool Verificado { get; set; }

        public bool Ativo { get; set; }

        public DateTime? UltimaDataDeLogin { get; set; }

        public PapelEnum Papel { get; set; }

        public string CodigoDeVerificacao { get; set; }

        public string CodigoDeAtivacao { get; set; }

        public string CodigoDeAutorizacao { get; set; }

        public DateTime? DataDoUltimoRequestDoCodigoDeAutorizacao { get; set; }

        public Guid AssociadoId { get; set; }

        public virtual Associado Associado { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validador = new UsuarioEstaValido();

            ValidationResult = validador.Validate(this);

            return ValidationResult.IsValid;
        }

        public string CriptografarSenha(string senha)
        {
            if (!string.IsNullOrEmpty(Senha))
            {
                return CriptografarMd5.Codifica(senha);
            }

            return string.Empty;
        }
    }
}