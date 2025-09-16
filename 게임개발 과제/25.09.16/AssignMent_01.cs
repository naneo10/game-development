
namespace _25._09._16
{
    /*
    [객체지향(OOP) 4대 특징]
    1.객체란?
    현실에 실재하는 모든 "대상"을 "변수"(상태/속성)와 "함수"(행동)로 추상화 시킨 개념
    책상, 의자, 시계, 책 등 주변에서 흔히 볼 수 있는 "모든 실재하는 대상"을 객체라고 부름

    2.OOP란?
    객체 지향 프로그래밍(Object-Oriented Programming, OOP)이란 컴퓨터 프로그램을 명령어의 목록으로 보는 시각에서
    벗어나 여러 독립적인 부품들의 조합, 즉 객체들의 유기적인 협력과 결합으로 파악하고자 하는 컴퓨터 프로그래밍의
    패러다임을 의미함

    3.객체지향(Object-Oriented Programming, OOP) 4가지 특징
    추상화
    -객체의 공통적인 속성과 기능을 추출하여 정의하는 것
    -지하철 노선도는 각 지역의 지리를 추상화한 것
    -삼성폰과 아이폰의 공통적인 특징을 휴대폰으로 묶어서 이름을 붙이는 것
    -대상의 본질적인 특징을 정의하고, 이것에 기반하여 대상을 객체로 구현하는 것
    */

    //비행기
    /*
    public class Airplane
    {
        public int people;
        public int freight;
        public int count;
    }
    */

    //배
    /*
    public class Ship
    {
        public int people;
        public int freight;
        public int count;
    }
    */

    /*
    상속
    -삼성폰 -> 휴대폰 -> 통신기기 -> 전자제품 이어지는 관계가 상속의 예
    -상위 클래스로부터 확장된 여러 개의 하위 클래스들이 모두 상위 클래스의 속성과 기능들을 간편하게 사용할 수 있다
    -부모 클래스에 정의된 변수 및 메서드를 자식 클래스에서 상속받아 사용하는 것
    -기존에 구현한 클래스를 재활용하여 구현할 수 있는 것을 의미
    */

    /*
    class Transportation
    {
        protected int people;
        protected int freight;
        protected int totalCount;

        public Transportation(int people, int freight, int totalCount)
        {
            this.people = people;
            this.freight = freight;
            this.totalCount = totalCount;
        }

        public void CurrentStatus()
        {
            Console.WriteLine($"현재 {people}명, {freight}개");
        }
    }

    class Airplane : Transportation
    {
        private int missCount;
        public Airplane(int totalCount) : base(20, 10, totalCount)
        {
            missCount = 3;
        }
        public void TotalCount(int totalCount)
        {
            totalCount -= missCount;
            Console.WriteLine($"TotalCount: {totalCount}");
        }
    }
    */

    /*
    다형성
    -어떤 객체의 속성이나 기능이 상황에 따라 여러 가지 형태를 가질 수 있는 성질
    -같은 메서드 호출이지만 실행되는 실제 기능 상황(클래스)에 따라 다르게 동작할 수 있도록 하는 것
    -다형성을 구현하는 예시로는 상속/구현 상황에서 메서드 오버라이딩/오버로딩이 있다
    */

    //class Transportation
    //{
    //    protected int people;
    //    protected int freight;
    //    protected int totalCount;

    //    public Transportation(int people, int freight, int totalCount)
    //    {
    //        this.people = people;
    //        this.freight = freight;
    //        this.totalCount = totalCount;
    //    }

    //    public virtual void CurrentStatus()
    //    {
    //        Console.WriteLine($"현재 {people}명, {freight}개");
    //    }

    //    public virtual void CurrentStatus(int totalCount)
    //    {
    //        this.totalCount = totalCount;
    //        Console.WriteLine($"현재 {people}명, {freight}개");
    //    }
    //}

    //class Ship : Transportation
    //{
    //    private int missCount;
    //    public Ship(int totalCount) : base(15, 38, totalCount)
    //    {
    //        missCount = 0;
    //    }
    //    public override void CurrentStatus()
    //    {
    //        base.CurrentStatus();
    //        Console.WriteLine($"TotalShipCount: {totalCount}");
    //    }
    //    public override void CurrentStatus(int missCount)
    //    {
    //        base.CurrentStatus();
    //        Console.WriteLine($"TotalShipCount: {totalCount}, MissCount: {missCount}");
    //    }
    //}

    /*
    캡슐화
    -서로 연관 있는 속성과 기능들을 하나의 캡슐(capsule)로 만들어 데이터를 외부로부터 보호하는 것
    -데이터와 코드의 형태를 외부로부터 알 수 없게 하고, 데이터의 구조와 역할, 기능을 하나의 캡슐 형태로 만드는 방법
    -getter(읽기)와 setter(쓰기)를 통해 내부 데이터를 보호하면서, 필요할 때만 값을 읽거나 변경
    -데이터 보호: 외부로부터 클래스에 정의된 속성과 기능들을 보호
    -데이터 은닉: 내부의 동작을 감추고 외부에는 필요한 부분만 노출
    */

    public class Airplane
    {
        public int People { get; protected set; }
        private int Freight { get; set; }

        public Airplane (int people, int freight)
        {
            People = people;
            Freight = freight;
        }

        public void Check ()
        {
            Console.WriteLine($"사람 수: {People}, 화물 수: {Freight}");
        }
        
    }

    internal class AssignMent_01
    {
        static void Main()
        {
            //상속
            //Airplane fp = new Airplane(8);

            //fp.CurrentStatus();
            //fp.TotalCount(12);

            //다형성
            //Ship sp = new Ship(3);
            //sp.CurrentStatus();
            //sp.CurrentStatus(3);

            //캡슐화
            Airplane ap = new Airplane(30,87);
            ap.Check();
        }
    }
}
