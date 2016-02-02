using System.Text.RegularExpressions;

namespace ForMeeting.SharedKernel.Validacoes
{
    public class CepValidation
    {
        public static bool Validar(string cep)
        {
            return Regex.IsMatch(cep, @"^\d{5}\-?\d{3}$", RegexOptions.IgnoreCase);
        }
    }
}