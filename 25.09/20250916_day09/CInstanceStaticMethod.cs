
namespace _20250916_day09
{
    /*
    [인스턴스 메서드]
    -객체를 생성하고 .메서드() 형식으로 호출
    -메서드를 호출하려면 클래스의 인스턴스를 생성
    -인스턴스 필드에 접근하고 변경할 수 있다
    -인스턴스의 상태를 조작하거나 데이터를 처리할 때 사용

    [정적 메서드]
    -클래스 이름으로 클래스명.메서드() 형식으로 호출
    -객체를 생성할 필요가 없음
    -인스턴스 필드에 접근할 수 없음
    -^클래스 차원에서 공통적인 기능을 처리하거나 객체 없이 실행되는 기능

    clr
    */
    class Car
    {
        public string model;
        private int num;
        public void Start()
        {
            Console.WriteLine($"{model}이(가) 시동이 걸렸다");
            num = 10;
            Console.WriteLine($"{num}");
        }
    }
    class Calculator
    {
        static int ab; /// -> ???

        //인스턴스 메서드
        //클래스의 인스턴스(객체)를 생성한 후에 호출할 수 있는 메서드
        //객체의 필드를 참조함
        public void Start() { }

        //정적 메서드
        //객체를 생성하지 않고 메서드의 이름을 통해서 호출이 가능
        public static int Add(int a, int b)
        {
            ab = 1; // 인스턴스 필드에는 접근불가
            //Start(); 인스턴스 메서드에는 접근불가
            return a + b;
        }
    }

    //정적 클래스
    //정적 클래스와 정적 멤버는 특정 인스턴스가 아닌 클래스 자체와 연결되는 개념
    //공통된 기능을 제공하거나 공유데이터를 관리할 때 사용
    //인스턴스 멤버 포함 x, 오직 정적멤버만 포함
    //인스턴스를 생성할 수 없음

    //???
    //공통적으로 사용되는 기능(유틸리티, 설정, 수학적인 계산 등등...)
    //각 객체마다 다른 값이 필요하지 않고.. 하나의 값만 공유하면 될 때
    //객체 없이 전역적인 접근이 필요한 경우
    //유틸리티 클래스, 게임설정, 공통기능 제공에 정적클래스를 활용할 수 있다.
    static class MathUtils
    {
        public static double Pi = 3.141592;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double CircleArea(double radius)
        {
            return Pi * radius * radius;
        }

        // 프로그램이 종료되기 전까지 계속 들고(상주) 있는다. // GC의 대상이 아니다
        public static List<string> list = new List<string>();
    }

    class GameManager
    {
        private static int playerCount = 0;
        public static void AddPlayer()
        {
            playerCount++; //공유
            Console.WriteLine($"현재 플레이어 수 : {playerCount}");
        }
    }

    internal class CInstanceStaticMethod
    {
        static void Main ()
        {
            Car car = new Car();
            car.Start();

            Console.WriteLine(Calculator.Add(1, 2));

            Console.WriteLine($"원주율 : {MathUtils.Pi}");
            Console.WriteLine($"10+20 : {MathUtils.Add(10, 20)}");
            Console.WriteLine($"반지름이 5인 원의 면적 : {MathUtils.CircleArea(5)}");
            GameManager.AddPlayer();
            GameManager.AddPlayer();
        }
    }
}
