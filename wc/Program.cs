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
            string filePath = args[1];
            bool fileExists = _argumentsValidator.FileExists(filePath);
            if(!fileExists)
            {
                Console.WriteLine($"Could not find file {args[1]}");
                return;
            }

            long bytes = new FileInfo(filePath).Length;
            Console.WriteLine($"{bytes} {filePath}");
        }
    }
}