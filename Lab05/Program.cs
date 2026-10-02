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

        //Attack
        int normalDamage = Math.Max(0, heroAtk - monsterDef);
        Console.WriteLine($"Normal attack deals : {normalDamage} DMG");
        int powerDamage = Math.Max(heroAtk, heroAtk * 2 - monsterDef);
        Console.WriteLine($"Power attack deals : {powerDamage} DMG");
        int counterDamage = Math.Max(0, monsterAtk - heroDef);
        Console.WriteLine($"Counter attack deals : {counterDamage} DMG");

        //Random
        Random randomSome = new Random();
        int roll = randomSome.Next(1, 101); //สุ่มเลขต้อง +1 เสมอ EX.1-100 = 1-101
        bool isCrit = roll <= 10;
        int critDamage = normalDamage + Convert.ToInt32(isCrit) * powerDamage;
        Console.WriteLine($"Crit Damage roll : {roll} (Crit : {isCrit})");
        Console.WriteLine($"If critical, normal attack would deal : {critDamage} DMG");
    }
}