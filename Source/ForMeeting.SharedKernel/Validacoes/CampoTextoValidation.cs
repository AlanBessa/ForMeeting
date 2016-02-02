namespace ForMeeting.SharedKernel.Validacoes
{
    public class CampoTextoValidation
    {
        public static bool ValidarSeEhRequerido(string texto)
        {
            return !string.IsNullOrEmpty(texto);
        }

        public static bool ValidarTamanhoMaximoDoTexto(int max, string texto)
        {
            var tamanhoDoTexto = texto.Length;

            return tamanhoDoTexto <= max;
        }

        public static bool ValidarTamanhoMinimoDoTexto(int min, string texto)
        {
            var tamanhoDoTexto = texto.Length;

            return tamanhoDoTexto >= min;
        }
    }
}