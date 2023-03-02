using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurePoint_ChatGPT.ViewModels
{
    public class ResponseViewModel
    {
        public ResponseViewModel(string response)
        {
            ResponseQuestion = $"Antes de passar uma rotina de treino, é importante ressaltar que é fundamental consultar um profissional de educação física para avaliar seu condicionamento físico e necessidades individuais." +
                " Com base nas informações fornecidas, segue uma sugestão de rotina de treino: " 
                +  response.Replace("\n", " ").Replace("\t", " ");
        }
        public string ResponseQuestion { get; set; }
    }
}
