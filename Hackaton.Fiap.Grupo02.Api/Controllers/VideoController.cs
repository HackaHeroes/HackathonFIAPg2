﻿using Hackaton.Fiap.Grupo02.Application.Interfaces;
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

    public async Task<IActionResult> Get(string url)
    {
        await _application.ProcessReceivedMessage(url);

        return Ok();
    }
}