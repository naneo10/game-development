namespace _20250916_day09
{
    /*
    과제 풀이
    */
    class Character
    {
        //public string name;
        //public int age;
        //public int hp;
        //public int atk;

        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }

        public void Print()
        {
            Console.WriteLine($"이름: {Name}, 레벨: {Level}, HP: {Hp}, 공격력: {Atk}");
        }
    }

    class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; private set; }
        public Item(string name, int price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public void Print()
        {
            Console.WriteLine($"아이템: {Name}, 가격: {Price}. 설명: {Description}");
        }

    class Bank
        {
            public string Owner { get; private set; }
            public int Balance { get; private set; }
            public Bank(string owner, int balance)
            {
                Owner = owner;
                Balance = balance;
            }

            public void Depisit(int amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("1원 이상 입금");
                    return;
                }
                Balance += amount;
                Console.WriteLine($"{amount}원 입금함 -> 현재 잔액: {Balance}원!");
            }
            public void withDraw(int amount)
            {
                if(amount <= 0)
                {
                    Console.WriteLine("출금은 알아서");
                    return;
                }
                if(amount > Balance)
                {
                    Console.WriteLine("잔액부족");
                    return;
                }
                Balance -= amount;
                Console.WriteLine($"{amount}원 출금함 -> 현재 잔액: {Balance}");
            }
            public void Show()
            {
                Console.WriteLine($"{Owner}님의 잔액: {Balance}원");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            character.Name = "홍길동";
            character.Level = 1;
            character.Hp = 100;
            character.Atk = 20;
            character.Print();

            Item item = new Item("집행검", 100000, "리니지 아이템");
            item.Print();
        }
    }
}
