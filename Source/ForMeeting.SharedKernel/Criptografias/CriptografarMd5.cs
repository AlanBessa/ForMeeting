using CryptSharp;

namespace ForMeeting.SharedKernel.Criptografias
{
    public class CriptografarMd5
    {
        public static string Codifica(string senha)
        {
            return Crypter.Ldap.Crypt(senha, new CrypterOptions
            {
                { CrypterOption.Variant, LdapCrypterVariant.MD5}
            });
        }

        public static bool Compara(string senha, string hash)
        {
            return Crypter.CheckPassword(senha, hash);
        }
    }
}