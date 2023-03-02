using System;
using System.Collections.Generic;
using System.Text;

namespace SecurePoint_ChatGPT.Data.Dto
{
    public class RequestDto
    {
        public RequestDto(string question)
        {
            this.prompt = $"Com base nas minhas metricas  {question} me passe uma rotina de treino para toda a semana.";
            this.temperature = 0.2m;
            this.max_tokens = 100;
            this.model = "text-davinci-003";
        }
        public string model { get; set; }
        public string prompt { get; set; }
        public int max_tokens { get; set; }
        public decimal temperature { get; set; }
    }
}
