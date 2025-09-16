
using System.Reflection.Metadata;

namespace _20250916_day09
{
    /*
    [포함 Composition]
    -클래스가 다른 클래스를 소유하고 있는 관계
    -하나의 클래스가 다른 클래스의 인스턴스를 멤버변수로 포함하고 그 객체의 기능을 자신의 일부처럼 사용하는 방식
    -포함된 객체는 포함하는 객체가 소멸될 때 함께 소멸
    -포함된 객체는 필드 변수처럼 사용. 외부에서 접근하기 위해서는 공개된 메서드를 통해 접근

    [상속 Inheritance]
    -상속은 한 클래스가 다른 클래스의 특성(속성, 메서드)을 물려받는 관계
    -기본 클래스(부모 클래스)의 기능을 확장하거나 변경하여 자식 클래스에서 사용
    -자식 클래스는 부모 클래스의 모든 public, protected 멤버를 상속받음
    -자식 클래스는 부모 클래스의 기능을 재정의(오버라이딩)하거나 추가할 수 있음
    -다중상속은 C#에서 직접적으로 지원하지 않음. 대신, 인터페이스를 통해 다중상속의 효과를 낼 수 있음
    */

    //포함
    class Engine
    {
        public string type;
        public Engine(string type)
        {
            this.type = type;
        }

        public void Start()
        {
            Console.WriteLine("엔진이 드릉드릉");
        }
    }

    class Car
    {
        private Engine engine; //Engine 객체를 포함

        public Car(starting engineType)
        {
            engine = new Engine(engineType); //Car 생성시 Engine 객체 생성
        }
        public void StartCar()
        {
            Console.writeLine("시동이 걸려부러쓰");
            engine.Start(); //엔진 기능사용
        }
    }
    //상속 X
    //class Warrior
    //{
    //    private string name;
    //    private int health;
    //    private int atk;
    //    private int def;

    //    public Warrior(string name, int health, int atk, int def)
    //    {
    //        this.name = name;
    //        this.health = health;
    //        this.atk = atk;
    //        this.def = def;
    //    }
    //    public void Attack()
    //    {
    //        Console.WriteLine($"{name}이 기본공격한다. 공격력: {atk}");
    //    }
    //    public void Attack1()
    //    {
    //        Console.WriteLine($"{name}이 강한 공격을 했다. {atk * 2}");
    //    }
    //    public void ShowStatus()
    //    {
    //        Console.WriteLine($"{name}체력 : {health}, 공격력 {atk}");
    //    }
    //    public void TakeDamage(int damage)
    //    {
    //        int reducedDamage = Math.Max(damage - def, 0);
    //        health -= reducedDamage;
    //        Console.WriteLine($"{name}이 {reducedDamage}만큼 피해를 입었따. 남은체력 : {health}");
    //    }
    //}

    //상속
    class Character
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Attack { get; protected set; }

        //부모 클래스 생성자
        public Character(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            Attack = attack;
        }

        public void Attack1()
        {
            Console.WriteLine($"{Name}이 기본공격 한다. 공격력 : {Attack}");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"{Name} 체력 : {Health}, 공격력 : {Attack}");
        }
    }

    class Warrior : Character
    {
        private int def; //자식 클래스의 추가 필드
        //base: 부모클래스의 생성자를 호출
        //워리어 클래스를 만들 때 부모 생성자를 먼저 호출
        public Warrior(string name) : base(name, 120, 15)
        {
            def = 5;
        }
        public void Skill()
        {
            Console.WriteLine($"{Name}이 어디선가 배운 마법 스킬을 사용한다. {Attack * 2}");
        }
        public void TakeDamage(int damage)
        {
            int reducedDamage = Math.Max(damage - def, 0);
            Health -= reducedDamage;
            Console.WriteLine($"{Name}이 {reducedDamage}만큼 피해를 입었따. 남은체력 : {Health}");
        }
    }

    internal class CInheritanceComposition
    {

        static void Main()
        {
            //    Warrior w = new Warrior("권정민", 1, 2, 0);
            //    w.ShowStatus();
            //    w.Attack();

            Warrior ww = new Warrior("엄재석");
            ww.ShowStatus();
            ww.Skill();
        }
    }
}