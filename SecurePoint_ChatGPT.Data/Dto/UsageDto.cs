using System;
using System.Collections.Generic;
using System.Text;

namespace SecurePoint_ChatGPT.Data.Dto
{
    public class UsageDto
    {
        public int Prompt_Tokens { get; set; }
        public int Completion_Tokens { get; set; }
        public int Total_Tokens { get; set; }
    }
}
