using wc.core.Contracts;
using wc.core.Services;

namespace wc;

public class Program
{
    private static IArgumentsValidator _argumentsValidator = new ArgumentsValidator();
    public static void Main(string[] args)
    {
        if (args.Count() == 0)
        {
            Console.WriteLine("Missing command line arguments.");
            return;
        }

        if(args.Count() == 2 && args[0] == "-c")
        {
            bool fileExists = _argumentsValidator.FileExists(args[1]);
            if(!fileExists)
            {
                Console.WriteLine($"Could not find file {args[1]}");
            }
        }
    }
}