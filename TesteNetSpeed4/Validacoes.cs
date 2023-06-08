using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TesteNetSpeed4
{
    public static class Validacoes
    {
        private static string apiKey = "b5e4f41f-3577-483e-93c9-f198257f615c";

        public static  bool VerificaFeriado(DateTime data)
        {
            bool feriado = false;
            using var  client =  new HttpClient();
            string url = $"https://date.nager.at/api/v3/publicholidays/{DateTime.Now.Year}/BR";

            var retornoAPI =  client.GetAsync(url).Result;
            if (retornoAPI.IsSuccessStatusCode)
            {
                var convertReturn =  retornoAPI.Content.ReadFromJsonAsync<List<RetornoAPIHoliday>>();

                var exist = convertReturn.Result.FirstOrDefault(g => g.Date.Date == data.Date);

                feriado = exist != null ? true : false;
            }
            else
            {
                feriado = false;

            }         
            


            return feriado;

        }

        public static bool VerificaFinalDeSemana(DateTime data)
        {
            return data.DayOfWeek == DayOfWeek.Sunday || data.DayOfWeek == DayOfWeek.Saturday ? true : false ;
        }
    }


    public class RetornoAPIHoliday 
    {
        public DateTime Date { get; set; }
    }

}
