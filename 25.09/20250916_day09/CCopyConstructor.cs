
namespace _20250916_day09
{
    /*
    [복사 생성자 Copy Constructor]
    -기존 객체의 값을 복사하여 새로운 객체를 생성
    -새로운 객체를 기존객체를 동일한 속성으로 초기화 할 때 사용
    -깊은/얕은 복사 여부는 내부 필드에 따라 달라짐
    */

    class NPC
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public NPC(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public NPC(NPC other)
        {
            Name = other.Name;
            Age = other.Age;
        }
        public void Print()
        {
            Console.WriteLine($"이름: {Name}, 나이: {Age}");
        }
    }
    class Player
    {
        public string name;
        public int level;
        public int hp;
        public int[] inventory; //참조타입

        public Player(string name, int level, int hp, int[] inventory)
        {
            this.name = name; //this: 나 자신을 가르키는 포인터 여기선 'Player.name' //매개변수의 이름이 같을 때 붙여주는 것
            this.level = level;
            this.hp = hp;
            this.inventory = inventory;
        }
        public Player(Player other)
        {
            name = other.name;
            level = other.level;
            hp = other.hp;
            inventory = other.inventory; //참조
        }
    }
    class Player1
    {
        public string name;
        public int level;
        public int hp;
        public int[] inventory; //참조타입

        public Player1(string name, int level, int hp, int[] inventory)
        {
            this.name = name;
            this.level = level;
            this.hp = hp;
            this.inventory = inventory;
        }
        public Player1(Player1 other)
        {
            name = other.name;
            level = other.level;
            hp = other.hp;
            //깊은복사
            //ArrayClass의 Clone()메서드를 이용
            inventory = (int[])other.inventory.Clone(); //참조 -> 값 //얕은복사 -> 깊은복사 구현
        }
    }
    internal class CCopyConstructor
    {
        static void Main ()
        {
            NPC npc1 = new NPC("홍길동", 10);
            NPC npc2 = new NPC(npc1);

            npc1.Print();
            npc2.Print();

            npc2.Name = "뭘봐";

            npc1.Print();   //홍길동 , 10
            npc2.Print();   //뭘봐 , 10

            int[] items = { 1, 2, 3 };
            Player p1 = new Player("홍길남", 10, 100, items);
            Player p2 = new Player(p1);

            p2.inventory[0] = 55;

            Console.WriteLine($"원본: {p1.inventory[0]}");    //55
            Console.WriteLine($"복사: {p2.inventory[0]}");    //55

            Console.WriteLine();
            Console.WriteLine();

            //====================
            int[] item1 = { 1, 2, 3 };
            Player1 p3 = new Player1("홍길북", 10, 100, item1);
            Player1 p4 = new Player1(p3);

            p4.inventory[0] = 333;

            Console.WriteLine($"원본: {p3.inventory[0]}");    //1
            Console.WriteLine($"복사: {p4.inventory[0]}");    //333
        }
    }
}
