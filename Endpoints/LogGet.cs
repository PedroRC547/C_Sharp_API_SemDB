using Microsoft.AspNetCore.Mvc;
using APIlog.Repository;

namespace APIlog.Endpoints
{
    public class LogGet
    {
        public static string Template => "/log/{data_criacao:int}";

        public static string[] Metodo => new string[] { HttpMethod.Get.ToString() };

        public static Delegate Func => Acao;

        public static IResult Acao([FromRoute] int data_criacao)
        {
            LogRepository logCarga = new LogRepository();

            logCarga.Carga();


            var retornoLog = LogRepository.BancoDeDados.Where(l => l.Data_criacao == data_criacao);

            if(retornoLog != null)
            {
                return Results.Ok(retornoLog);
     
            }
            else
            {
                return Results.NotFound();
            }
        }
    }
}
