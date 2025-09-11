using System.ComponentModel;

namespace _20250911_day06
{
    /*
    과제풀이 
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            int atk = 20;

            Console.WriteLine($"강화 전 : hp={hp}, atk={atk}");
            Console.WriteLine(UpgradeStates(hp, atk));

            Console.WriteLine();
        }

        //1.캐릭터 스탯
        static string UpgradeStates(int hp, int atk, int hpIncrease = 10, int atkIncrease = 2)
        {
            hp += hpIncrease;
            atk += atkIncrease;
            return $"강화 후 : hp = {hp}, atk = {atk}";
        }

        //2.공격데미지
        static int CalculateDamage(int atk, int def)
        {
            int damage = atk - def;

            if (damage < 0)
            {
                damage = 0;
            }
            return damage;
        }
        
        //3. 치명타
        static int CalculateDamage(int atk, int def, bool isCritical)
        {
            int damage = atk - def;
            if (damage < 0)
            {
                damage = 0;
            }
            if(isCritical)
            {
                damage = (int)Math.Round(damage * 1.5);
            }
            return damage;
        }

        //4. 보너스
        static int CalculateDamage(int atk, int def, int bonusDamage)
        {
            int damage = atk - def + bonusDamage;

        }
    }
}
