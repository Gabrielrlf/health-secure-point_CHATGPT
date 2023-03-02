using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SecurePoint_ChatGPT.Service.Interfaces;
using SecurePoint_ChatGPT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurePoint_ChatGPT.Controllers
{
    [ApiController]
    [Route("api/v1/secure-point-gpt")]
    public class SecurePointController : ControllerBase
    {
        private readonly IRequestService _requestService;

        public SecurePointController(IRequestService requestService)
        {
            _requestService = requestService ??
              throw new ArgumentNullException(nameof(requestService));
        }

        [HttpGet]
        public async Task<IActionResult> Get(string text)
        {
            var response = await _requestService.PostRequest(text);
            return Ok(new ResponseViewModel(response.choices.First().text));
        }
    }
}
