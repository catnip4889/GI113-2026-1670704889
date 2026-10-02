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
        const string GameTitle = "Wuthering Waves";

        var name = "Brant";
        var rank = "S";
        int level = 90;
        int maxLevel = 90;
        int hp = 18353;
        int atk = 3422;
        int def = 1307;
        double er = 285.4;
        float critRate = 56.1f;
        float critDmg = 258.8f;
        bool isPlayable = true;

        Console.WriteLine($"██╗    ██╗██╗   ██╗████████╗██╗  ██╗███████╗██████╗ ██╗███╗   ██╗ ██████╗");
        Console.WriteLine($"██║    ██║██║   ██║╚══██╔══╝██║  ██║██╔════╝██╔══██╗██║████╗  ██║██╔════╝");
        Console.WriteLine($"██║ █╗ ██║██║   ██║   ██║   ███████║█████╗  ██████╔╝██║██╔██╗ ██║██║  ███╗");
        Console.WriteLine($"██║███╗██║██║   ██║   ██║   ██╔══██║██╔══╝  ██╔══██╗██║██║╚██╗██║██║   ██║");
        Console.WriteLine($"╚███╔███╔╝╚██████╔╝   ██║   ██║  ██║███████╗██║  ██║██║██║ ╚████║╚██████╔╝");
        Console.WriteLine($" ╚══╝╚══╝  ╚═════╝    ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝ ╚═════╝");
        Console.WriteLine($"              ██╗    ██╗ █████╗ ██╗   ██╗███████╗███████╗");
        Console.WriteLine($"              ██║    ██║██╔══██╗██║   ██║██╔════╝██╔════╝");
        Console.WriteLine($"              ██║ █╗ ██║███████║██║   ██║█████╗  ███████╗");
        Console.WriteLine($"              ██║███╗██║██╔══██║██║   ██║██╔══╝  ╚════██║");
        Console.WriteLine($"              ╚███╔███╔╝██║  ██║╚██████╔╝███████╗███████║");
        Console.WriteLine($"               ╚══╝╚══╝ ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚══════╝");

        Console.WriteLine($"\nGame Title: {GameTitle}");
        Console.WriteLine($"Resonator: {name}");
        Console.WriteLine($"Rank: {rank}");
        Console.WriteLine($"Lv.: {level}/{maxLevel}");
        Console.WriteLine($"HP: {hp}");
        Console.WriteLine($"ATK: {atk}");
        Console.WriteLine($"DEF: {def}");
        Console.WriteLine($"Energy Regen: {er}");
        Console.WriteLine($"Crit.Rate: {critRate}%");
        Console.WriteLine($"Crit.DMG: {critDmg}%");
        Console.WriteLine($"Is Playable: {isPlayable}");


    }
}