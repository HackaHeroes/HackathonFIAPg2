using Hackaton.Fiap.Grupo02.Application.Interfaces;
using Hackaton.Fiap.Grupo02.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hackaton.Fiap.Grupo02.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VideoController : ControllerBase
{
    private readonly IVideoApplication _application;

    public VideoController(IVideoApplication application)
    {
        _application = application;
    }

    public async Task<IActionResult> GetStatusAsync(string url)
    {
        await _application.GetStatusProcessAsync(url);
        return Ok();
    }

    [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        [HttpPost, DisableRequestSizeLimit]
        [RequestSizeLimit(valueCountLimit: int.MaxValue)]
        public async Task<IActionResult> Post([FromBody] object data)
        {
            Console.WriteLine(data);
            var dd = JsonConvert.DeserializeObject<InboundFileViewModel>(data.ToString());

            _application.Processa(dd);

            return Ok();
        }
    }
