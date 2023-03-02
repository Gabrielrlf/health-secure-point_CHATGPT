using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SecurePoint_ChatGPT.Data.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SecurePoint_ChatGPT.Service.Interfaces
{
    public interface IRequestService
    {
        Task<ResponseDto> PostRequest(string question);
    }
}
