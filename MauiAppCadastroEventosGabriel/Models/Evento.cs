using System;

namespace MauiAppCadastroEventosGabriel.Models
{
    public class Evento
    {
        public string NomeDoEvento { get; set; }
        public string NomeDoLocal { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroDeParticipantes { get; set; }
        public double ValorParticipante { get; set; }

        public TimeSpan Duracao => DataTermino - DataInicio;
        public double CustoTotal => NumeroDeParticipantes * ValorParticipante * (Duracao.Days + 1);
    }
}
