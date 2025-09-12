
namespace _20250912_day07
{
    /*
    [UserDefineType]
    [열거형]
    -관련된 상수들을 묶어서 관리할 수 있는 데이터 타입
    -코드 가독성 향상, 유지보수가 용이함
    -각 상수는 0부터 시작하고 명시적으로 값을 지정할 수 도 있음
    -주로 상태, 옵션 등을 표현할 때 사용
    -열거형은 클래스나 구조체와 달리 인스턴스를 생성할 수 없고, 단순히 상수들의 집합으로 사용

    [사용예시]
    -게임에서 캐릭터의 상태(Idle, Running, Jumping 등)
    -UI요소의 상태(Enable, Disable, Hidden 등)

    [사용법]
    enum 열거형의이름
    {
        상수1,
        상수2,
        상수3,
        ...
    }
    
    enum GameState
    {
        Start,
        Playing,
        Paused,
        GameOver
    }

    [구조체(struct)] 구조체와 클래스의 차이점이 무엇인가? ★★★
    -데이터와 관련 기능을 캡슐화 할 수 있는 값 형식
    -데이터를 저장하고 보관하기 위한 용도로 사용
    -클래스와 비슷하게 필드, 메서드, 프로퍼티, 생성자 등을 가질 수 있음
    -값 타입이기 때문에 스택에 저장

    [주 용도]
    -간단한 데이터 구조를 정의할 때 사용
    -좌표, 색상 등 간단한 데이터 타입을 정의할 때 사용

    [구성]
    struct 구조체이름
    {
        -여기에 내용이 들어감
        -구조체 내용으로는 변수, 메서드가 포함가능
    }
    */

    struct StudentInfo
    {
        //Field
        public string name; //변수
        public int math;
        public int eng;
        public int science;

        public float Average()
        {
            //Method
            return (math + eng + science) / 3f;
        }
    }

    struct MyStruct
    {
        public int value1;
        public int value2;
    }

    struct MyStruct1
    {
        public string[] name; //참조 형식
    }

    internal class Day07_03
    {
        enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        enum Color
        {
            Red,
            Green,
            Blue //마지막은 콤마 생략 가능
        }

        //switch문이랑 활용을 많이함
        static void Main ()
        {
            Console.WriteLine((int)Color.Red);
            Console.WriteLine((int)Color.Green);
            Console.WriteLine((int)Color.Blue);

            Direction dir = Direction.Up;

            switch (dir)
            {
                case Direction.Up:
                    //캐릭터가 위로 이동
                    break;
                case Direction.Down:
                    break;
                case Direction.Left:
                    break;
                case Direction.Right:
                    break;
                default:
                    break;
            }

            StudentInfo st = new StudentInfo();

            st.math = 10;
            st.eng = 20;
            st.science = 30;
            Console.WriteLine(st.Average());

            //얕은 복사와 깊은 복사의 차이 ★★★★
            //깊은 복사: 원본 데이터랑 복사 데이터랑 독립객체, 서로 영향을 주지 않음
            MyStruct m;
            m.value1 = 1;
            m.value2 = 2;

            Console.WriteLine(m.value1);    //1
            Console.WriteLine(m.value2);    //2

            MyStruct s;
            s = m;

            Console.WriteLine(s.value1);    //1
            Console.WriteLine(s.value2);    //2

            m.value1 = 10;
            Console.WriteLine(m.value1);    //10
            Console.WriteLine(s.value1);    //1

            //얕은 복사: 같은 참조 주소를 공유하기에 원본 데이터에도 영향
            MyStruct1 m1;
            m1.name = new string[] { "홍길동", "홍길서" };

            MyStruct1 m2;
            m2 = m1;
            m2.name[0] = "홍길남";

            Console.WriteLine(m1.name[0]);
        }
    }
}
