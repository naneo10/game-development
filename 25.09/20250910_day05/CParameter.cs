
namespace _20250910_day05
{
    /*
    ★★★
    오늘 첫 번째 과제
    1.'값 형식'과 '참조 형식'의 종류와 차이점
    2.메모리 구조에 대해 정리(4개 정도)
    3.메서드활용 구현
    
    Stack vs heap

    -ValueType, ReferenceType
        int. bool. float ...
    
    [ref]
        -값을 변경할 수 있는 참조전달을 의미
        -메서드에서 메개변수의 값을 변경하면 호출한 곳에서도 변경이 반영됨
        -메서드 내부에서 매개변수를 읽고 수정가능
        -메서드 내부에서 값을 수정하고 그 변경이 호출할 곳에서도 반영되어야 될 때 사용

    [in]
        -읽기 전용 참조전달을 의미함
        -메서드 내부에서 매개변수의 값을 읽을 수는 있지만 변경이 불가능
        -구조체를 참조로 전달할 때 값 복사를 방지하여 성능상 이점이 있을수 있음

    [out]
        -메서드에서 값을 반드시 설정해야 하는 참조전달을 의미
        -메서드가 호출되기 전에는 변수가 초기화 되지 않아도 되지만 메서드 내부에서 값을 할당해야함
        -여러개의 값을 반환해야 하는 경우 사용
    */
    internal class CParameter
    {
        static void Func(int num)
        {
            num += 10;
        }

        static void RefFunc(ref int num)
        {
            num += 10;
        }

        static void InFunc(in int num)
        {
            Console.WriteLine(num);
            //num += 10;
        }

        static void OutFunc(out int a, out int b)
        {
            //메서드 내부에서 반드시 초기화가 이루어져야 한다
            a = 10;
            b = 20;
        }

        static void Test(int a, int b, out int c, out int d)
        {
            c = a / b;
            d = a % b;
        }

        static void Main()
        {
            int num = 20;
            Func(num);
            Console.WriteLine(num); //20

            int a = 1;
            //a가 RefFunc로 전달될 때 참조형식으로 전달되므로 메서드 내부에서 변경된 값이 원본에도 반영됨
            RefFunc(ref a);
            Console.WriteLine(a);

            int b = 2;
            InFunc(b);
            Console.WriteLine(b);

            //호출하는 쪽에서는 초기화를 하지 않아도 됨
            int x, y;
            OutFunc(out x, out y);
            Console.WriteLine($"{x},{y}");

            int num1 = 17;
            int num2 = 5;

            Test(num1, num2, out int q, out int r);
            Console.WriteLine($"{q},{r}");
        }
    }
}
