using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SecurePoint_ChatGPT.Data.Dto;
using SecurePoint_ChatGPT.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SecurePoint_ChatGPT.Service
{
    public class RequestService : IRequestService
    {
        private readonly HttpClient _httpClient;
        private readonly string _Url;
        private readonly string _Token;
        public RequestService(HttpClient httpClient, IConfiguration Configuration)
        {
            _httpClient = httpClient;
            _Url = Configuration["UrlIntegration:api-chatgpt"];
            _Token = Configuration["KeyIntegrationSecrets:Key"];

        }
        public async Task<ResponseDto> PostRequest(string question)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _Token);

                var requestContentJson = JsonSerializer.Serialize(new RequestDto(question));
                var contentJson = new StringContent(requestContentJson, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(_Url, contentJson);
                ResponseDto responseDto = JsonSerializer.Deserialize<ResponseDto>(await response.Content.ReadAsStringAsync());
                return responseDto;
            }
            catch
            {
                throw new Exception("Erro ao tentar estabelecer conexão.");
            }
        }
    }
}
