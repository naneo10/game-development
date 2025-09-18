namespace _20250918_day11
{
    internal class Program
    {
        /*
        과제풀이
        */
        #region
        abstract class Monster
        {
            public string name { get; set; }
            public int hp { get; set; }
            public Monster(string name, int hp)
            {
                this.name = name;
                this.hp = hp;
            }
            public abstract void Attack();
            public void Print()
            {
                Console.WriteLine($"이름: {name}, 체력: {hp}");
            }

        }

        class Goblin : Monster
        {
            public Goblin() : base("고블린", 30) { }
            public override void Attack()
            {
                Console.WriteLine("고블린이 칼로 공격함");
            }
        }

        class Orc : Monster
        {
            public Orc() : base("오크", 50) { }
            public override void Attack()
            {
                Console.WriteLine("오크가 도끼로 공격");
            }
        }
        #endregion  몬스터

        #region
        //아이템
        abstract class Item
        {
            public string name { get; set; }
            public int charges { get; set; }

            public Item (string name, int charges)
            {
                this.name = name;
                charges = Math.Max(0, charges);
            }
            public abstract void Use();
            public void Print()
            {
                Console.WriteLine($"{name}, 남은 횟수: {charges}");
            }
            public bool CanUse()
            {
                return charges > 0;
            }
            protected void Consume()
            {
                if (charges > 0)
                {
                    charges--;
                }
            }
        }

        class Potion : Item
        {
            public Potion (int charges) : base("포션", charges) { }

            public override void Use()
            {
                if (!CanUse())
                {
                    Console.WriteLine("더 이상 사용할 수 없다");
                }
                else
                {
                    Console.WriteLine("포션을 사용했다. 체력회복");
                    Consume();
                }
            }
        }
        #endregion

        interface IAttackable
        {
            void Attack();
        }

        interface IHealable
        {
            void Heal();
        }

        abstract class Character
        {
            public string name { get; private set; }
            public int attackPower { get; private set; }
            public int health { get; protected set; }
            public Character (string name, int health, int attackPower)
            {
                this.name = name;
                this.health = health;
                this.attackPower = attackPower;
            }
            public void ShowStatus()
            {
                Console.WriteLine($"이름: {name}, 체력: {health}, 공격력: {attackPower}");
            }

            public void TakeDamage(int damage)
            {
                health -= damage;
                Console.WriteLine($"{name}이 {damage}를 받았다. (남은 체력: {health})");
            }
        }

        class Mage : Character, IAttackable, IHealable
        {
            public Mage(string name) : base(name, 100, 15) { }
            public void Attack()
            {
                Console.WriteLine($"{name}이 아이스볼을 던졌다. 공격력{attackPower}");
            }
            public void Heal()
            {
                health += 20;
                Console.WriteLine($"{name}이 체력을 회복했다. 현재 체력{health}");
            }
        }

        class Warrior : Character, IAttackable
        {
            public Warrior (string name) : base (name, 150, 20) { }
            public void Attack()
            {
                Console.WriteLine($"{name}이 검을 휘둘렀다. 공격력{attackPower}");
            }
        }


        static void Main(string[] args)
        {
            //foreach로 뽑아내기
            Monster[] monsters =
            {
                new Goblin(),
                new Orc()
            };

            Warrior warrior = new Warrior("오즈");
            Mage mage = new Mage("코딩마법사");
        }
    }
}
