
namespace _20250916_day09
{
    /*
    [다양성]
    -하나의 인터페이스(메서드, 클래스...)가 다양한 방식으로 동작할 수 있도록 하는 객체지향 프로그래밍의 개념
    -같은 메서드 호출이지만 실행되는 실제 기능 상황(클래스)에 따라 다르게 동작할 수 있도록 하는 것
    
    [메서드 오버라이딩]
    -부모 클래스의 메서드를 자식 클래스에서 재정의
    -부모 클래스의 메서드와 같은 이름, 같은 매개변수를 가지지만, 내부동작을 다르게 구현

    [오버라이딩 특징]
    -부모 클래스의 메서드와 반환형, 이름, 매개변수가 동일
    -부모 메서드에 virtual 키워드, 자식 메서드에 override 키워드를 사용

    virtual: 부모 클래스에서 이 메서드는 자식 클래스에서 오버라이딩 가능함 이라고 명시하는 키워드
    override: 부모에 virtual 메서드를 재정의 하려면 override 키워드 사용
    sealed: 자식 클래스에서 더 이상 오버라이딩을 허용하지 않겠다

    [오버라이딩 vs 오버로딩] ★★★★★
    
    [오늘 과제]
    -객체지향(OOP) 4대 특징 ★★★★★
    */
    class Character
    {
        public string Name { get; set; }
        public Character(string name)
        {
            Name = name;
        }

        //부모 메서드
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본공격");
        }
    }

    class Warrior : Character
    {
        public Warrior(string name) : base(name) { }

        //오버라이딩(재정의)
        public override sealed void Attack()
        {
            Console.WriteLine($"{Name}이 검으로 공격한다");
        }
    }

    class Mage : Character
    {
        public Mage(string name) : base(name) { }

        public override void Attack()
        {
            base.Attack(); //부모의 메서드 호출
            Console.WriteLine($"{Name}이 화염구 공격!!");
        }
    }

    class Warrior1 : Warrior
    {
        public Warrior1(string name) : base(name) { }
        //public override void Attack()
        //{

        //}
    }

    internal class CPolymorphism
    {
        static void Main()
        {
            //업 캐스팅
            Character warrior = new Warrior("둘리");
            Character mage = new Mage("또치");

            warrior.Attack();
            mage.Attack();
        }
    }
}
