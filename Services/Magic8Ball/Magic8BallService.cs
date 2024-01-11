namespace _8to10.Services.Magic8Ball;

public class Magic8BallService : IMagic8BallService
{
    public string Magic8(string question)
    {
        Random random = new Random();
        int magicInput = random.Next(0, 8);


        if (question.Length > 0)
        {
            switch (magicInput)
            {
                case 0:
                    return "I dont think so.";
                case 1:
                    return "Signs point to yes";
                case 2:
                    return "Don't count on it";
                case 3:
                    return "Ask again later";
                case 4:
                    return "Most likely";
                case 5:
                    return "You may rely on it";
                case 6:
                    return "No";
                case 7:
                    return "Without a doubt";
                case 8:
                    return "Cannot predict that";
                default:
                    return "How?";
            }
        }
        else
        {
            return "Please enter in a question";
        }
    }
}
