namespace _20250917_day10
{
    /*
    추상클래스와 인터페이스의 차이★★★★★ 
    [추상 클래스(abstractclass)]
    -객체를 직접 생성할 수 없고 구체적인 내용이 일부 또는 전혀 없는 클래스
    -공통적인 기능을 정의하고 자식 클래스가 이를 상속받아 구현하도록 강제
    -자식 클래스가 반드시 구현해야 하는 메서드를 포함 (추상메서드)
    -일반 메서드와 추상 메서드를 함께 가질 수 있음

    [추상 클래스를 사용하는 이유]
    -코드의 유지보수성과 재사용성 높임
    -공통된 기능을 한 곳에서 관리하므로 중복 코드를 줄이고 유지보수성을 높임
    */

    interface ITest
    {
        private const int a = 1; //상수는 포함 할 수 있다
    }

    abstract class Animal
    {
        private int a = 1;
        protected string name { get; set; }
        public Animal (string name)
        {
            this.name = name;
        }

        //일반 메서드
        public void Eat()
        {
            Console.WriteLine($"{name}이(가) 먹이를 먹는다");
        }

        //추상 메서드 -> 구현 불가 (자식 클래스에서 반드시 구현해야 한다)
        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound()
        { 
            Console.WriteLine($"{name}이(가) 멍멍! 하고 짖습니다");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{name}이(가) 야옹야옹~하고 울어제낀다");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("바우바우"); //업 캐스팅
            Animal cat = new Cat("나비야");

            dog.Eat();
            dog.MakeSound();
            cat.Eat();
            cat.MakeSound();
        }
    }
}
