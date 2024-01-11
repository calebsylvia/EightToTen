using _8to10.Services.Magic8Ball;
using Microsoft.AspNetCore.Mvc;

namespace _8to10.Controllers;

public class Magic8BallController : ControllerBase
{
    private readonly IMagic8BallService _magic8BallService;

    public Magic8BallController(IMagic8BallService magic8BallService)
    {
        _magic8BallService = magic8BallService;
    }

    [HttpGet]
    [Route("Magic8/{question}")]

    public string Magic8(string question)
    {
        return _magic8BallService.Magic8(question);
    }
}
