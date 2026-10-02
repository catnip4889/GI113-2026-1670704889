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
    }
}