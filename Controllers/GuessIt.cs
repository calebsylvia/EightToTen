using _8to10.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace _8to10.Controllers;


[ApiController]
[Route("GuessIt")]
    public class GuessIt : ControllerBase
    {
    private readonly IGuessItService _guessItService;

    public GuessIt(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

        [HttpGet]
        [Route("EasyGuess/{guess}")]
        public string EasyGuess(string guess)
        {
            return _guessItService.EasyGuess(guess);
        }

        [HttpGet]
        [Route("MediumGuess/{guess}")]
        public string MediumGuess(string guess)
        {
            return _guessItService.MediumGuess(guess);
        }

        [HttpGet]
        [Route("HardGuess/{guess}")]

        public string HardGuess(string guess)
        {
            return _guessItService.HardGuess(guess);
        }





    }
