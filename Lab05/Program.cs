/*
 * Student ID :  1670704889
 * Name       :  Thunyaphon Amphaphan
 * Section    :  129B
 * No.        :  5
 * Course     : GI113 Computer Programming (GI)
 */

internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== BATTLE DAMAGE CALCULATOR ===");
        Console.WriteLine("Hero vs Monster -- Calculate Damage\n");

        //Hero
        Console.Write("Hero HP: ");
        bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
        Console.Write("Hero Attack: ");
        bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
        Console.Write("Hero Defense: ");
        bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

        //Monster
        Console.Write("Monster HP: ");
        bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
        Console.Write("Monster Attack: ");
        bool monsterAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
        Console.Write("Monster Defense: ");
        bool monsterDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);

        //Check
        bool allStatsValid = heroHpOk && heroAtkOk && heroDefOk && monsterHpOk && monsterAtkOk && monsterDefOk;
        Console.WriteLine($"All stats valid: {allStatsValid}");
        Console.WriteLine($"[HERO]        HP : {heroHp}, ATK : {heroAtk}, DEF : {heroDef}");
        Console.WriteLine($"[Monster]     HP : {monsterHp}, ATK : {monsterAtk}, DEF : {monsterDef}");

        //Hero drink potion before the fight (compound assignment: +=)
        int potionHeal = 14;
        heroHp += potionHeal;
        Console.WriteLine($"\nHero drink a potion, healing {potionHeal} HP, Hero HP is : {heroHp}");

        int normalDamage = Math.Max(0, heroAtk - monsterDef);

    }
}