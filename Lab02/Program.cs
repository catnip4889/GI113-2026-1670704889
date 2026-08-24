/*
 * Student ID :  1670704889
 * Name       :  Thunyaphon Amphaphan
 * Section    :  129B
 * No.        :  N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"===== BOSS STATUS: INITIAL =====");

            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;

            Console.WriteLine();

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {hpPercent}%");

            Console.WriteLine($"===== Slime Escape =====");
;
            string name = "Little Slime";
            char rank = 'N';
            int level = 1;
            int maxHp = 20;
            float attackPower = 5.0f;
            float critRate = 10.5f;
            double critMultiplier = 1.25;
            double critDamage = attackPower * critMultiplier;
            bool playable = true;

            Console.WriteLine($"\nName : {name} \nRank : {rank} \nLevel : {level} \nHP : {maxHp} \nATK : {attackPower} \nCrit Rate : {critRate} \nCrit Damage : {critDamage} \nIs Playable : {playable}")

        }
    }
}
