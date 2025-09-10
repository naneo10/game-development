
namespace _20250910_day05
{
    /*
    ★★★★
    [오버로딩]
    -같은 이름의 메서드를 매개변수의 타입이나 개수를 다르게 해서 여러개를 정의
    -같은 기능을 수행하지만 다양한 입력방식이 필요한 경우 유용하게 사용
    -반환형 고려 X

    [오버로딩시 장점]
    -코드가독성 향상: 같은 기능을 하는 메서드는 통일된 이름으로 관리
    -유연함: 다양한 입력 값을 처리할 수 있음
    -중복코드 방지: 같은 기능을 가진 메서드를 여러개 만들 필요가 없다
    -매개변수에 따라 자동으로 호출
    */
    internal class COverLoading
    {
        //만약 더하는 기능을 하는 메서드를 만든다면?
        //오버로딩 X
        static int AddInt(int a, int b)
        {
            return a + b;
        }

        static double AddDouble(double a, double b)
        {
            return a + b;
        }

        static int AddIntThree(int a, int b, int c)
        {
            return a + b + c;
        }

        //오버로딩 O
        static int Add (int a, int b)
        {
            return a + b;
        }

        static double Add (double a, double b)
        {
            return a + b;
        }

        static double Add (double a, int b)
        {
            return a + b;
        }

        static int Add (int a, int b, int c)
        {
            return a + b + c;
        }

        //디폴트 매개변수
        //메서드를 호출할 때 매개변수를 생략하면 자동으로 들어가줌
        static void Print (int atk, string name = "몬스터") // 'int name = "몬스터"' default 매개변수 뒤쪽부터 작성해야함
        {
            Console.WriteLine($"이름: {name}에게, 공격: {atk}");
        }

        static void Main ()
        {
            //오버로딩 X
            Console.WriteLine(AddInt(1, 2));
            Console.WriteLine(AddDouble(1.2, 1.5));
            Console.WriteLine(AddIntThree(1, 2, 3));

            Console.WriteLine();

            //오버로딩 O
            Console.WriteLine(Add(1, 2, 3));
            Console.WriteLine(Add(1.5, 2.5));
            Console.WriteLine(Add(1, 3));
            Console.WriteLine(Add(1.2, 3));
        }
    }
}
