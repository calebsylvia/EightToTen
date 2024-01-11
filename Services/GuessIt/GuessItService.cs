namespace _8to10.Services.GuessIt;

public class GuessItService : IGuessItService
{
    public string EasyGuess(string guess)
    {
        Random easyRandom = new Random();
            int easyGuess = easyRandom.Next(1, 11);
            bool isTrue = int.TryParse(guess, out int easyUserGuess);

            if(isTrue && easyUserGuess <= 10)
            {
                if(easyUserGuess == easyGuess)
                {
                    return $"You guessed it! The number was {easyGuess}.";
                }
                else if(easyUserGuess > easyGuess)
                {
                    return $"Your guess was incorrect! Your guess {easyUserGuess} was more than than the number {easyGuess}.";
                }
                else
                {
                    return $"Your guess was incorrect! Your guess {easyUserGuess} was less than the the number {easyGuess}.";

                }
            }
            else
            {
                return "Please enter in valid integer and within range of 1-10.";
            }
    }

    public string MediumGuess(string guess)
    {
        Random mediumRandom = new Random();
            int mediumGuess = mediumRandom.Next(1, 51);
            bool isTrue = int.TryParse(guess, out int mediumUserGuess);

            if(isTrue && mediumUserGuess <= 50)
            {
                if(mediumUserGuess == mediumGuess)
                {
                    return $"You guessed it! The number was {mediumGuess}.";
                }
                else if(mediumUserGuess > mediumGuess)
                {
                    return $"Your guess was incorrect! Your number {mediumUserGuess} was more than the number {mediumGuess}.";
                }
                else
                {
                    return $"Your guess was incorrect! Your number {mediumUserGuess} was less than the number {mediumGuess}.";
                }
            }
            else
            {
                return "Please enter in valid integer and within the range of 1-50.";
            }
    }

    public string HardGuess(string guess)
    {
        Random hardRandom = new Random();
            int hardGuess = hardRandom.Next(1, 101);
            bool isTrue = int.TryParse(guess, out int hardUserGuess);

            if(isTrue && hardUserGuess <= 100)
            {
                if(hardUserGuess == hardGuess)
                {
                    return $"You guessed it! The number was {hardGuess}.";
                }
                else if(hardUserGuess > hardGuess)
                {
                    return $"Your guess was incorrect! Your number {hardUserGuess} was more than the number {hardGuess}.";
                }
                else
                {
                    return $"Your guess was incorrect! Your number {hardUserGuess} was less than the number {hardGuess}.";
                }
            }
            else
            {
                return "Please enter in a valid integer and within the range of 1-100.";
            }
    }
}
