/*
 * Student ID :  1670704889
 * Name       :  Thunyaphon Amphaphan
 * Section    :  129B
 * No.        :  N/A
 * Course     : GI113 Computer Programming (GI)
 */

internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== BATTLE DAMAGE CALCULATOR ===");
        Console.WriteLine("Hero vs Monster -- Calculate Damage\n");

        Console.Write("Hero HP: ");
        bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
        Console.Write("Hero Attack: ");
        bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
        Console.Write("Hero Defense: ");

        bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);
        Console.Write("Monster HP: ");
        bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
        Console.Write("Monster Attack: ");
        bool monsterAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
        Console.Write("Monster Defense: ");
        bool monsterDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);

        bool allStatsValid = heroHpOk && heroAtkOk && heroDefOk && monsterHpOk && monsterAtkOk && monsterDefOk;
        Console.WriteLine($"All stats valid: {allStatsValid}");
    }
}