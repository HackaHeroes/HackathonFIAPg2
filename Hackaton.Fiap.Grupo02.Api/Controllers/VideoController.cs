using Hackaton.Fiap.Grupo02.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
            //await _application.Processa(url);

            return Ok("Hello world");
        }

        [HttpPost, DisableRequestSizeLimit]
        [RequestSizeLimit(valueCountLimit: int.MaxValue)]
        public async Task<IActionResult> Post([FromForm] string data)
        {
            Console.WriteLine(data);
            var file = Request.Form.Files[0];
            Console.WriteLine(file);

            return Ok();
        }
    }
