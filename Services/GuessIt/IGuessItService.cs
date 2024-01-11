namespace _8to10.Services.GuessIt;

    public interface IGuessItService
    {
        string EasyGuess(string guess);
        string MediumGuess(string guess);
        string HardGuess(string guess);
    }
