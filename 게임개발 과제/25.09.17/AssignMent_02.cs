
namespace _25._09._17
{
    /*
    [추상클래스 과제 2번]
    아이템 사용 시스템

    요구사항
    1.부모 클래스 Item(추상 클래스)
    -속성: name, charges(남은 사용 횟수, 0 미만 불가)
    -메서드
    :abstract void Use() -> 반드시 자식 클래스에서 구현해야 함
    :void PrintInfo() -> 아이템 이름과 남은 사용 횟수 출력
    :bool CanUse() -> 남은 사용 횟수가 0 이상이면 true 반환

    1.자식 클래스
    -Potion -> Use()구현 -> 포션을 사용했다! 체력이 회복된다! 출력
    -Scroll -> Use()구현 -> 스크롤을 사용했다! 마법이 발동된다! 출력
    -Bomb -> Use()구현 -> 폭탄을 사용했다! 큰 피해를 입혔다! 출력
    2.Main()에서 각 아이템을 임의의 사용횟수 charges로 생성한다.
    -use()호출 시
    :CanUse()가 true면 Use()호출 후 charges 1감소
    :CanUse()가 false면 더 이상 사용할 수 없습니다 출력
    */ //과제

    /*
    아이템: 포션, 남은 사용 횟수: 2
    포션을 사용했다! 체력이 회복된다.
    아이템: 포션, 남은 사용 횟수: 1
    포션을 사용했다! 체력이 회본된다.
    아이템: 포션, 남은 사용 횟수: 0
    더 이상 사용할 수 없습니다.

    아이템: 스크롤, 남은 사용 횟수: 1
    스크롤을 사용했다! 마법이 발동된다.
    아이템: 스크롤, 남은 사용 횟수: 0
    더 이상 사용할 수 없습니다.

    아이템: 폭탄, 남은 사용 횟수: 2
    폭탄을 사용했다! 큰 피해를 입혔다.
    아이템: 폭탄, 남은 사용 횟수: 1
    폭탄을 사용했다! 큰 피해를 입혔다.
    아이템: 폭탄, 남은 사용 횟수: 0
    더 이상 사용할 수 없습니다.
    */ //예시 출력

    abstract class Item
    {
        public string Name { get; set; }
        public int Charges { get; set; }
        public Item(string name)
        {
            Name = name;
            Charges = 0;
        }
        public abstract void Use();
        public void PrintInfo()
        {
            Console.WriteLine($"아이템: {Name}, 남은 사용 횟수: {Charges}");
        }
        public bool CanUse()
        {
            if (Charges > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Potion : Item
    {
        public Potion(string name) : base(name)
        {
            Name = name;
            Charges = 2;
        }
        public override void Use()
        {
            //메서드를 매개변수로 사용할 때 '메서드명+()'로 사용한다
            if (CanUse())
            {
                Charges--;
                Console.WriteLine("포션을 사용했다! 체력이 회복된다!");
            }
            else
            {
                Console.WriteLine("더 이상 사용할 수 없습니다.");
            }
        }
    }

    class Scroll : Item
    {
        public Scroll(string name) : base(name)
        {
            Name = name;
            Charges = 1;
        }
        public override void Use()
        {
            if (CanUse())
            {
                Charges--;
                Console.WriteLine("스크롤을 사용했다! 마법이 발동된다!");
            }
            else
            {
                Console.WriteLine("더 이상 사용할 수 없습니다.");
            }
        }
    }

    class Bomb : Item
    {
        public Bomb(string name) : base(name)
        {
            Name = name;
            Charges = 2;
        }
        public override void Use()
        {
            if(CanUse())
            {
                Charges--;
                Console.WriteLine("폭탄을 사용했다! 큰 피해를 입혔다!");
            }
            else
            {
                Console.WriteLine("더 이상 사용할 수 없습니다.");
            }
        }
    }

    internal class AssignMent_02
    {
        static void Main ()
        {
            Item potion = new Potion("포션");
            potion.PrintInfo();
            potion.Use();
            potion.PrintInfo();
            potion.Use();
            potion.PrintInfo();
            potion.Use();

            Console.WriteLine();

            Item scroll = new Scroll("스크롤");
            scroll.PrintInfo();
            scroll.Use();
            scroll.PrintInfo();
            scroll.Use();

            Console.WriteLine();

            Item bomb = new Bomb("폭탄");
            bomb.PrintInfo();
            bomb.Use();
            bomb.PrintInfo();
            bomb.Use();
            bomb.PrintInfo();
            bomb.Use();
        }
    }
}
