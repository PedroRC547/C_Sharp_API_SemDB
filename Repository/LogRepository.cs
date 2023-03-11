using APIlog.Entities;

namespace APIlog.Repository
{
    public class LogRepository

    {
        public static List<Log> BancoDeDados { get; set; } = new List<Log>();

        public void Carga()
        {
            Log logUm = new Log(1, 1, "{nomeMaquina:SLAP0030,Ip:172.16.0.190,Ip:fe80::7d64:2809:7ec8:eb6c%5,Ip:fe80::7d64:2809:7ec8:eb6c%5,Marca:Teste,status:Todos os terminais estão conectados,data: 03_02_2023,hora:11:17:45}", 0, 04032023);
            Log logDois = new Log(2, 1, "{nomeMaquina:SLAP0030,Ip:172.16.0.190,Ip:fe80::7d64:2809:7ec8:eb6c%5,Ip:fe80::7d64:2809:7ec8:eb6c%5,Marca:Teste,status:Todos os terminais estão conectados,data: 03_02_2023,hora:11:17:45}", 0, 04032023);
            Log logTres = new Log(3, 1, "{nomeMaquina:SLAP0030,Ip:172.16.0.190,Ip:fe80::7d64:2809:7ec8:eb6c%5,Ip:fe80::7d64:2809:7ec8:eb6c%5,Marca:Teste,status:Todos os terminais estão conectados,data: 03_02_2023,hora:11:17:45}", 0, 05032023);
            Log logQuatro = new Log(4, 1, "{nomeMaquina:SLAP0030,Ip:172.16.0.190,Ip:fe80::7d64:2809:7ec8:eb6c%5,Ip:fe80::7d64:2809:7ec8:eb6c%5,Marca:Teste,status:Todos os terminais estão conectados,data: 03_02_2023,hora:11:17:45}", 0, 05032023);
            Log logCinco = new Log(5, 1, "{nomeMaquina:SLAP0030,Ip:172.16.0.190,Ip:fe80::7d64:2809:7ec8:eb6c%5,Ip:fe80::7d64:2809:7ec8:eb6c%5,Marca:Teste,status:Todos os terminais estão conectados,data: 03_02_2023,hora:11:17:45}", 0, 05032023);

            BancoDeDados.Add(logUm);
            BancoDeDados.Add(logDois);
            BancoDeDados.Add(logTres);
            BancoDeDados.Add(logQuatro);
            BancoDeDados.Add(logCinco);

        }
    }
}
