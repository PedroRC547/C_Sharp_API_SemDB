namespace APIlog.Entities
{
    public class Log
    {
        public int Id_log { get; set; }

        public int Id_usuario { get; set; }
        
        public string Mensagem { get; set; }

        public int Indica_erro { get; set; }

        public int Data_criacao { get; set; }


        public Log(int id, int usuario, string mensagem, int indica_erro, int data_criacao)
        {
            Id_log = id;
            Id_usuario = usuario;
            Mensagem = mensagem;
            Indica_erro = indica_erro;
            Data_criacao = data_criacao;
        }
    }
}
