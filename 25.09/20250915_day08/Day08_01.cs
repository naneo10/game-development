
namespace _20250915_day08
{
    /*
    [클래스 (class)]
    -객체지향 프로그래밍(OOP)의 핵심요소. 객체(Object)를 생성하는 역할
    -필드(속성), 기능(메서드), 생성자 등을 포함하여 데이터를 캡슐화 하고, 재사용성을 높이는데 유용하다.
    -클래스는 객체를 만들기 위한 설계도. 만들어진 객체는 인스턴스라고 부르기도 한다
    -만들어진 설계도를 기반으로 여러 객체를 만들수 있다.
    -OOP(객체지향 프로그래밍)에서는 클래스를 사용하여 프로그램을 객체단위로 구조화

    -책 : 틀 (template)
    ㄴ속성: 제목(string), 내용(string), 저자(string), 페이지수(int)
    ㄴ기능: 펼친다, 덮는다.

    붕어빵 틀 : 틀을 이용해서 붕어빵을 만든다 이 붕어빵을 객체가 된다
    - 반죽, 팥, 밀가루, 물
    - 기능: 불을 킨다, 뒤집는다, 굽는다

    [클래스 정의]
    class 클래스 이름(붕어빵)
    {
        //필드(속성)
        //밀가루, 물

        메서드(기능)
        굽는다.
        뒤집는다.
    }

    구조체와 클래스 차이 ★★★
    */

    class Person
    {
        //속성(필드)
        public string name;
        public int age;

        //기능(메서드)
        public void Print()
        {
            Console.WriteLine($"안녕하세요. 내 이름은 {name}이고, 나이는 {age}살 입니다.");
        }
    }

    class MyClass
    {
        public int value1;
        public int value2;
    }

    struct ValueType
    {
        public int value;
    }

    class RefType
    {
        public int value;
    }

    internal class Day08_01
    {
        static void Swap(ValueType left, ValueType right) //값 형식
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
        }
        static void Swap(RefType left, RefType right) //참조 형식
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
        }

        static void Main ()
        {
            Person person = new Person();//객체생성
            person.name = "홍길동";
            person.age = 10;

            person.Print();

            //Person person1; //인스턴스 생성을 하지 않았기에 사용불가
            //person1.age = 20;

            //Car car1 = new car()
            //l   ㄴ스택에 저장됨
            //ㄴ 참조(클래스)

            MyClass s = new MyClass();
            s.value1 = 1;
            s.value2 = 2;

            MyClass t = s; //같은 인스턴스를 참조
            t.value1 = 3;

            //=======================================
            //call by value && call by reference ★★★★

            //같은 인스턴스를 참조하기 때문에 복사본을 변경하는 경우 원본도 변경됨
            Console.WriteLine(s.value1); //3
            Console.WriteLine(s.value2); //2

            Console.WriteLine(t.value2); //3
            Console.WriteLine(t.value2); //2

            //값에의한 호출
            ValueType leftValue = new ValueType() { value = 10 };
            ValueType rightValue = new ValueType() { value = 20 };
            Swap(leftValue, rightValue); //복사 값을 스왑

            //원본 호출
            Console.WriteLine($"{leftValue.value},{rightValue.value}");

            //참조에 의한 호출
            RefType leftRef = new RefType() { value = 10 };
            RefType rightRef = new RefType() { value = 20 };
            Swap(leftRef, rightRef);

            Console.WriteLine($"{leftRef.value},{rightRef.value}");
            //=========================================
        }
    }
}
