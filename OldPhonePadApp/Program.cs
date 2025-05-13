using System;

namespace OldPhonePadApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var service = new OldPhonePadService();

            Console.WriteLine("Welcome to Old Phone Pad Simulator!");
            Console.WriteLine("Enter your key sequence (end with '#'):");

            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input. Please try again.");
                return;
            }

            try
            {
                string result = service.Decode(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
