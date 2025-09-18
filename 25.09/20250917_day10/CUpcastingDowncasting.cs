
namespace _20250917_day10
{
    /*
    [업캐스팅 다운캐스팅]★★★★★
    -업캐스팅과 다운캐스팅은 상속관계에서 객체를 서로 다른 타입으로 변환하는 개념

    [업캐스팅]
    -하위클래스(자식클래스)의 객체를 상위클래스(부모클래스) 타입으로 변환하는 것
    -자동변환(암시적 변환)이 가능. 안전하다
    -부모 클래스의 멤버만 접근 가능

    [다운캐스팅]
    -부모클래스 타입의 객체를 자식 클래스 타입으로 변환
    -명시적 변환이 필요
    -실제 객체가 자식클래스 타입이 아닐경우 오류 발생
    //as or is를 활용하여 안전하게 변환
    */

    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 낸다.");
        }
        public virtual void Eat()
        {
            Console.WriteLine("밥을 먹는다");
        }
    }

    class Dog : Animal
    {
        public void Bark ()
        {
            Console.WriteLine("멍멍");
        }
        public override void Eat()
        {
            Console.WriteLine("개가 밥을 와구와구 먹는다");
        }
    }

    class Parent
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 낸다.");
        }
    }

    class Child : Parent
    {
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    internal class CUpcastingDowncasting
    {
        static void Main()
        {
            //업캐스팅
            //Dog dog = new Dog(); //원래 Dog객체
            //Animal animal = dog; //업캐스팅

            //animal.Speak(); //부모꺼
            //animal.Bark(); 자식 클래스 메서드 접근불가

            //animal.Eat();

            //다운캐스팅
            //Animal animal = new Dog();

            //Dog dog = (Dog)animal; //명시적 형변환 오류가 날 가능성 존재
            //dog.Bark();

            Parent parent = new Child();

            //is: 타입에 맞는 경우에만 다운 캐스팅을 수행
            if(parent is Child child)
            {
                child.Bark();
            }
            else
            {
                Console.WriteLine("다운 캐스팅 불가");
            }

            //as: 변환 실패 시 'null'을 반환해서 예외를 방지
            Parent parent1 = new Child();
            Child child1 = parent1 as Child;

            if (child1 != null)
            {
                child1.Bark();
            }
            else
            {
                Console.WriteLine("다운 캐스팅 불가");
            }
        }
    }
}
