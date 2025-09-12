
namespace _25._09._12
{
    /*
    [구조체를 활용한 학생점수 비교하기]

    요구사항
    1.Student라는 구조체를 생성한다.
        -이름(string), 점수(int) 필드를 포함한다.
    2.Main()에서 학생 2명을 선언하고, 각각 이름과 점수를 입력받아 저장한다.
    3.두 학생 중 점수가 더 높은 학생을 출력한다.
    */

    /*
    [예시출력]
    첫 번째 학생 이름 입력: 홍길동
    첫 번째 학생 점수 입력: 85
    두 번째 학생 이름 입력: 홍길서
    두 번째 학생 점수 입력: 92

    학생 1: 홍길동, 점수: 85
    학생 2: 홍길서, 점수: 92

    점수가 더 높은 학생은 홍길서 입니다.
    */

    /*
    구조체와 클레스의 차이 : https://usingsystem.tistory.com/6
    */

    internal class AssignMent_02
    {
        struct Student
        {
            public string Name;
            public int Score;

            public bool HighScore()
            {
                Console.WriteLine($"점수가 더 높은 학생은 {} 입니다.");
            }
        }

        static void Main ()
        {
            //첫 번째 학생 이름, 점수 입력
            Console.WriteLine("첫 번째 학생 이름 입력 : ");
            string inputName = Console.ReadLine();
            Console.WriteLine("첫 번째 학생 점수 입력 : ");
            int inputScore = int.Parse(Console.ReadLine());

            //입력 값 할당
            Student Name = (Student)Enum.Parse(typeof(Student), inputName);
            //Student Score = (Student)inputScore; //수정필요

            Console.WriteLine("두 번째 학생 이름 입력 : ");
            Console.WriteLine("두 번째 학생 점수 입력 : ");
        }
    }
}
