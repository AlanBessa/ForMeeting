using System;
using System.Collections.Generic;

namespace ForMeeting.SharedKernel.Validacoes
{
    public class DataValidation
    {
        public static bool ValidarSeCampoNaoEhNulo(DateTime? data)
        {
            return data != null;
        }

        public static bool ValidarSeDataEhMaiorQue(DateTime dataInicio, DateTime dataFim)
        {
            return dataInicio >= dataFim;
        }

        public static bool ValidarSeDataEhMenorQue(DateTime dataInicio, DateTime dataFim)
        {
            return dataInicio <= dataFim;
        }

        public static bool ValidarSeDataEhMaiorOuIgualQue(DateTime dataInicio, DateTime dataFim)
        {
            return dataInicio > dataFim;
        }

        public static bool ValidarSeDataEhMenorOuIgualQue(DateTime dataInicio, DateTime dataFim)
        {
            return dataInicio < dataFim;
        }

        public static bool ValidarSeDataNaoEhFimDeSemana(DateTime data)
        {
            return (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday);
        }

        public static bool ValidarSeDataEstaContidaNaLista(IList<DateTime> ListaDeDatas, DateTime data)
        {
            if (ListaDeDatas != null)
            {
                foreach (var item in ListaDeDatas)
                {
                    return item.Date == data.Date;
                }
            }

            return false;
        }

        public static bool ValidarSeDataEHoraEstaContidaNaLista(IList<DateTime> ListaDeDatas, DateTime data)
        {
            if (ListaDeDatas != null)
            {
                foreach (var item in ListaDeDatas)
                {
                    return item == data;
                }
            }

            return false;
        }
    }
}