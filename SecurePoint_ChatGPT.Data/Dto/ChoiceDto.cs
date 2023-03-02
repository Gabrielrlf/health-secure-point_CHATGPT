using System;
using System.Collections.Generic;
using System.Text;

namespace SecurePoint_ChatGPT.Data.Dto
{
    public class ChoiceDto
    {
        public string text { get; set; }
        public int Index { get; set; }
        public object LogProbs { get; set; }
        public string Finish_Reason { get; set; }
    }
}
