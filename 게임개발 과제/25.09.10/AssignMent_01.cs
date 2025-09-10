
namespace _25._09._10
{
    /*
    과제 01
    '값 형식'과 '참조 형식'의 종류와 차이점 정리
    */
    internal class AssignMent_01
    {
        static void Main()
        {
            Console.WriteLine("C# 값 형식 종류");
            Console.WriteLine("정수 형식: byte, sbyte, ushort, short, unit, int, ulong, long 등");
            Console.WriteLine("부등 소수점 형식: float, double, decimal 등");
            Console.WriteLine("문자 형식: char");
            Console.WriteLine("부울 형식: bool");
            Console.WriteLine("열거형 Enum");
            Console.WriteLine("구조체 struct");
            Console.WriteLine();

            Console.WriteLine("C# 참조 형식 종류");
            Console.WriteLine("클래스(Class): 사용자 정의 형식을 생성할 때 사용");
            Console.WriteLine("배열(Array): 같은 타입의 여러 데이터를 순차적으로 저장하는 구조");
            Console.WriteLine("인터페이스(Interface): 클래스가 구현해야 할 메서드나 속성의 집합을 정의");
            Console.WriteLine("델리게이트(Delegate): 특정 시그니처(메서드 이름, 매개변수, 반환형식)를 가지는" +
                "메서드를 참조할 수 있는 형식으로, 함수 포인터와 유사");
            Console.WriteLine("열거형(Enum): 여러 상수 값의 집합으로 정의, 이름있는 상수 값들을 읽기 쉽고" +
                "안전하게 사용할 수 있도록 함");
            Console.WriteLine("문자열(String): 텍스트 데이터를 다루기 위한 참조 형식으로," +
                "내부적으로 문자의 배열을 사용");
            Console.WriteLine();

            Console.WriteLine("=== '값 형식'과 '참조 형식'의 종류와 차이점 정리 ===");
            Console.WriteLine("*값 형식(Value Type)");
            Console.WriteLine("값 형은 변수에 값을 직접 저장한다.");
            Console.WriteLine("int, float, double과 같은 기본 자료형 부터 시작해서,");
            Console.WriteLine("구조체 struct도 이러한 값 형식의 저장 방식을 사용한다.");
            Console.WriteLine("기본적으로 변수 값은 할당 시, 인수를 메서드에 전달할 때,");
            Console.WriteLine("메서드 결과를 반활할 때 복사된다.");
            Console.WriteLine();
            Console.WriteLine("깊은 복사 (Deep Copy)");
            Console.WriteLine("변수가 실제 데이터를 보유하게 되며,");
            Console.WriteLine("이 데이터를 다른 변수에 할당하거나 전달할 때 값을 복사한다.");
            Console.WriteLine("이러한 방식의 복사를 '깊은 복사'라고 한다.");
            Console.WriteLine("이 때 하나의 변수를 수정해도, 다른 변수의 데이터에 전혀 영향을 주지 않는다.");
            Console.WriteLine();

            int test1 = 0;
            int test2 = 20;

            test1 = test2;

            Console.WriteLine(test1);
            Console.WriteLine(test2);

            test1 = 17;
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine();

            Console.WriteLine("*참조 형식 (Reference Type");
            Console.WriteLine("참조 형식의 변수는 데이터 값이 아닌");
            Console.WriteLine("데이터에 대한 참조 (메모리 주소)를 저장한다.");
            Console.WriteLine("클래스, 배열, 인터페이스 등이 참조형에 해당한다.");
            Console.WriteLine("변수가 실제 데이터를 가리키는 참조를 갖게 되며,");
            Console.WriteLine("할당을 하는 순간 데이터의 주소를 가져가게 된다.");
            Console.WriteLine();
            Console.WriteLine("얕은 복사 (Shallow Copy");
            Console.WriteLine("참조 형식의 변수를 다른 변수에 할당하거나 전달할 때");
            Console.WriteLine("값이 아닌 참조가 복사된다.");
            Console.WriteLine("이러한 방식의 복사를 얕은 복사(Shallow Copy)라고 한다.");
            Console.WriteLine();
            Console.WriteLine("이 때 변수 내의 값을 수정하면, 동일한 데이터를 가리키고 있는");
            Console.WriteLine("다른 변수도 같은 값을 가리키기 때문에 다른 변수에 영향을 줄 수 있다.");
            Console.WriteLine();

            //Test 구문 작성 필

            Console.WriteLine("값 형식 vs 참조 형식");
            Console.WriteLine("값 형식과 참조 형식은 데이터가 저장되는 방식도 다를 뿐더러");
            Console.WriteLine("저장되는 위치마저 다르다.");
            Console.WriteLine();
            Console.WriteLine("값 형식은 스택 메모리에 저장되고,");
            Console.WriteLine("참조 형식은 힙 메모리에 저장된다.");
            Console.WriteLine();

            Console.WriteLine("스택(Stack)");
            Console.WriteLine("스택은 함수를 위해 존재하는 메모리 공간");
            Console.WriteLine("임시로 변수 선언 후 삭제, 매개 변수 받을 때, 함수 안에서 선언하는 변수들 등");
            Console.WriteLine("종료가 먼저되는 함수 순서대로 변수를 삭제해줄 필요가 있다.");
            Console.WriteLine("가장 먼저 필요가 없어진 변수들을 먼저 지워주기 위해 스텍 메모리 구조를 사용");
            Console.WriteLine();

            Console.WriteLine("힙(Heap)");
            Console.WriteLine("참조 방식은 선언하는 변수에 데이터 본체가 저장되는 것이 아니라");
            Console.WriteLine("본체가 저장된 주소를 담고 있는 개념이다.");
            Console.WriteLine();
            Console.WriteLine("그 주소가 가리키고 있는 본체들이 바로 힙에 저장되는 것이다.");
            Console.WriteLine();
            Console.WriteLine("힙에는 동적 할당이라는 방법으로 메모리에 공간을 할당한다.");
            Console.WriteLine("컴파일 시점에 메모리가 할당 되는 것을 정적 할당");
            Console.WriteLine("런타임 시점에 메모리가 할당 되는 것을 동적 할당");
            Console.WriteLine();
            Console.WriteLine("동적 할당은 언제 메모리가 할당되고 해제될지 알 수 없기에");
            Console.WriteLine("스택 메모리를 사용하는 것은 부적절하다.");
            Console.WriteLine();

            Console.WriteLine("스택 메모리의 장점은");
            Console.WriteLine("단순하고 효율적인 구조이기 때문에 할당과 해제에 드는 오버헤드가 크지 않다는 것이다");
            Console.WriteLine("값 형식의 데이터를 다루는 것이 약간 더 가볍다.");
            Console.WriteLine("단점으로는 컴파일 시점에 할당하려는 메모리 크기를 미리 알아야,");
            Console.WriteLine("스택으로 부터 메모리를 할당받을 수 있다는 점이고,");
            Console.WriteLine("다른 객체에서 스택 메모리의 변수를 접근하기가 힘들다는 것이다.");
            Console.WriteLine();

            Console.WriteLine("힙 메모리의 장점은 런타임에 메모리를 할당 받을 수 있고,");
            Console.WriteLine("타 객체로부터 접근이 쉽다는 것이다.");
            Console.WriteLine("단점은 반대로 할당 및 해제를 하는데에 오버헤드가 든다는 것이다.");
            Console.WriteLine();

            /*
            속도: 스택 메모리는 힙 메모리보다 할당 및 해제가 빠르다. 힙 메모리는 상대적으로 느리다.
            크기: 스택 메모리는 상대적으로 작은 크기를 가지며, 고정된 크기로 할당됨.
                반면 힙은 더 큰 메모리 공간을 사용할 수 있으며, 동적 크기로 할당됨.
            메모리 관리: 스택 메모리는 자동으로 할당되고 해제되지만, 힙 메모리는 GC에 의해 관리되며,
                수동으로 관리할 필요가 없다.
            */

            Console.WriteLine("오버헤드가 발생하는 이유는");
            Console.WriteLine("힙은 임의의 주소에 메모리를 할당하고 해제하기 때문에");
            Console.WriteLine("메모리 할당을 할 때 순차적인 탐색이 필요하다.");
            Console.WriteLine("이 순차적인 탐색을 위해, 참조 타입 객체들은 기본적으로");
            Console.WriteLine("타입 객체 포인터와 동기화 블록 인덱스라는 두 개의 추가 필드가 할당된다.");
            Console.WriteLine("또한 더 이상 사용하지 않는 데이터를 탐지하기 위해,");
            Console.WriteLine("참조 카운팅(Reference Counting)을 해야하기 때문에");
            Console.WriteLine("할당과 해제 두 과정에 모두 오버헤드가 존재하는 것이다.");
        }
    }
}
