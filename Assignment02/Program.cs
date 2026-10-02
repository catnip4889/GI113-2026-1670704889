/*
 * Student ID :  1670704889
 * Name       :  Thunyaphon Amphaphan
 * Section    :  129B
 * No.        :  5
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.0;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("------- Welcome to the Forge -------");
            Console.WriteLine("------------------------------------");

            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate:F2} / Salvage {SalvageRate:F2}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine() ?? "";

            char menu = '\0';
            bool menuParsed = char.TryParse(menuInput, out menu);

            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine() ?? "";

            double amount = 0;
            bool amountParsed = double.TryParse(amountInput, out amount);

            if (amountParsed && amount > 0 && amount <= MaxBatch)
            {
                if (menuParsed && (menu == 'S' || menu == 's'))
                {
                    double ingot = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {ingot:F2} {MaterialName} Ingot");
                }
                else if (menuParsed && (menu == 'B' || menu == 'b'))
                {
                    double ore = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {ore:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Error: Invalid menu. Please enter S or B.");
                }
            }
            else
            {
                Console.WriteLine($"Error: Invalid amount. Enter a number greater than 0 and at most {MaxBatch:F2}.");
            }
        }
    }
}