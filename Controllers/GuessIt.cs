using _8to10.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace _8to10.Controllers;


[ApiController]
[Route("GuessIt")]
    public class GuessItController : ControllerBase
    {
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

        [HttpGet]
        [Route("EasyGuess1-10/{guess}")]
        public string EasyGuess(string guess)
        {
            return _guessItService.EasyGuess(guess);
        }

        [HttpGet]
        [Route("MediumGuess1-50/{guess}")]
        public string MediumGuess(string guess)
        {
            return _guessItService.MediumGuess(guess);
        }

        [HttpGet]
        [Route("HardGuess1-100/{guess}")]

        public string HardGuess(string guess)
        {
            return _guessItService.HardGuess(guess);
        }





    }
