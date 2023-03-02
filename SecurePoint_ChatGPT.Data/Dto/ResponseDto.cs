using System;
using System.Collections.Generic;
using System.Text;

namespace SecurePoint_ChatGPT.Data.Dto
{
    public class ResponseDto
    {
        public string id { get; set; }
        public string @object { get; set; }
        public int created { get; set; }
        public string model { get; set; }
        public List<ChoiceDto> choices { get; set; }
        public UsageDto usage { get; set; }
    }
}
