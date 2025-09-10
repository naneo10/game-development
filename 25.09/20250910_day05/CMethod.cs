
namespace _20250910_day05
{
    /*
    [메서드]
    -특정 작업을 수행하는 코드블록
    -입력 값을 받아서 처리하고 결과를 반환

    [실행단계]
    -입력 -> 처리 -> 결과

    [메서드 정의]
    [접근제한자] [반환형(리턴타입)] [메서드 이름](매개변수)
    {
        //내용(실행할 코드)
        return 반환값; -> 없을수도 있음
    }
    -접근제한자: 매서드의 접근 범위를 결정(public, private, protected 등)
    -반환형: 메서드가 반환하는 값의 타입. 반환 값이 없으면 void(공허하다) 사용
    -매개변수: 메서드가 입력받는 값, 여러개의 매개변수 가질 수 있음(없을 수도 있음)

    [호출]
    -호출하려면 메서드 이름과 괄호를 사용

    [사용이유]
    1.코드 재사용성
        -같은 기능을 여러번 쓰고 싶을 때 메서드로 만들어 놓고 호출만 하면 됨.
        -중복된 코드를 줄여서 실수 가능성을 낮춤

    2.코드 가독성
        -복잡한 로직을 이름이 있는 블록으로 묶어서 한눈에 무슨 역할인지 알 수 있음
    
    3.유지보수 용이
        -로직이 바뀌면 메서드 내부만 수정하면 됨

    4.구조화와 모듈화
        -큰 프로그램을 작은 단위로 나눠서 관리할 수 있음
        -각 메서드가 하나의 기능만 담당하게 해서 코드의 구조를 명확하게 할 수 있음

    [메서드의 형태]
    1.매개변수가 없고 반환 값이 없는 경우
        -입력도 없고 결과도 반환하지 않는다. -> 단순실행
        -화면 출력, 로그기록...
    2.매개변수가 있고 반환 값이 없는 경우
        -입력 값을 받아서 처리만 하고 결과를 반환하지 않는 경우
    3.매개변수가 없고, 반환 값이 있는 경우
        -외부 입력없이 내부에서 결과를 생성 후 반환
        -계산결과, 난수생성...
    4.매개변수가 있고 반환 값도 있는 경우
        -입력 값을 받아서 처리하고 결과를 반환
        -데이터 변환, 계산, 검색...

    [반환값]
    -메서드 실행이 끝난 후 호출한 쪽에 돌려주는 값
    -메서드 선언 시 반환 자료형을 지정해야 하며 반환 값이 없으면 void를 사용

    [매개변수]
    -인자, 파라미터라고도 하며 메서드에 어떤 정보를 넘겨주는 데이터를 나타냄(메서드가 호출될 때 외부에서 전달받는 값)
    -매개변수는 메서드 정의에서 소괄호 안에 선언하고 콤마를 기준으로 여러개 설정할 수 있다.
    */
    internal class CMethod
    {
        //1.매개 변수가 없고 반환 값이 없는 경우
        static void Print()
        {
            Console.WriteLine("환영합니다");
        }

        //2.매개변수가 있고 반환 값이 없는 경우
        static void PrintMessage(string str)
        {
            Console.WriteLine(str);
        }

        static void PrintMessage1(string str, int age)
        {
            Console.WriteLine($"{str}, {age}");
        }

        //3. 매개변수가 없고 반환 값이 있는 경우
        static int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }

        //4.매개변수가 있고 반환 값도 있는 경우
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Test ()
        {
            //return " ";
            return 1;
        }

        static void Main()
        {
            Console.WriteLine("===매개변수가 없고 반환 값도 없는 경우===");
            Print();

            Console.WriteLine("===매개변수가 있고 반환 값이 없는 경우===");
            PrintMessage("프린트 메세지");
            PrintMessage1("나이", 13);

            Console.WriteLine("===매개변수가 없고 반환 값이 있는 경우===");
            int randomNumber = GetRandomNumber();
            Console.WriteLine(randomNumber);
            
            Console.WriteLine("===매개변수가 있고 반환 값도 있는 경우===");
            int sum = Add(5, 10);
            Console.WriteLine(sum);

            //전투상황1
            int playerHp = 100;
            int enemyAtk = 15;
            playerHp -= enemyAtk;
            Console.WriteLine($"플레이어 HP: {playerHp}");
            if (playerHp <= 0) Console.WriteLine("죽었다");
            
            //전투상황2
            playerHp = 80;
            enemyAtk = 25;
            playerHp -= enemyAtk;
            Console.WriteLine($"플레이어 HP: {playerHp}");
            if (playerHp <= 0) Console.WriteLine("죽었다");

            //전투상황3
            playerHp = 50;
            enemyAtk = 50;
            playerHp -= enemyAtk;
            Console.WriteLine($"플레이어 HP: {playerHp}");
            if (playerHp <= 0) Console.WriteLine("죽었다");

            //2.메소드로 분리
            Battle(100, 15);
            Battle(80, 25);
            Battle(50, 50);
        }

        static void Battle (int playerHp, int enemyAtk)
        {
            playerHp -= enemyAtk;
            Console.WriteLine($"플레이어 HP: {playerHp}");
            if (playerHp <= 0) Console.WriteLine("죽었다");
        }
    }
}
