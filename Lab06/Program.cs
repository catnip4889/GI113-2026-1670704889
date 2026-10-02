/*
 * Student ID :  1670704889
 * Name       :  Thunyaphon Amphaphan
 * Section    :  129B
 * No.        :  5
 * Course     : GI113 Computer Programming (GI)
 */
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("        HERO VS MONSTER");
        Console.WriteLine("================================\n");
        Console.WriteLine("[A] Attack");
        Console.WriteLine("[B] Defend");
        Console.WriteLine("[C] Heal\n");

        Console.Write("Choose your action: ");
        bool inputOk = char.TryParse(Console.ReadLine(), out char action);

        if (!inputOk)
        {
            Console.WriteLine("Invalid input. Please enter A, B, or C.");
        }
        else if (action == 'A' || action == 'a')
        {
            Console.WriteLine("You attack the monster!");
            Console.WriteLine("The monster takes damage.");
        }
        else if (action == 'B' || action == 'b')
        {
            Console.WriteLine("You defend against the monster!");
            Console.WriteLine("You reduce the damage taken.");
        }
        else if (action == 'C' || action == 'c')
        {
            Console.WriteLine("You heal yourself!");
            Console.WriteLine("Your HP is restored.");
        }
        else
        {
            Console.WriteLine("Invalid action. Please choose A, B, or C.");
        }

        Console.WriteLine();
        Console.WriteLine("Game Over.");
    }
}