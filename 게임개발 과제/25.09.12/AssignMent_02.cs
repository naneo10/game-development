
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
    struct Student
    {
        public string name;
        public int score;
    }

    internal class AssignMent_02
    {
        static void Main()
        {
            Student std;
            Student std2;

            string testName;
            string testNum;
            bool test;

            //1. 이름 확인
            do
            {
                Console.WriteLine("첫 번째 학생 이름 입력 : ");
                testName = Console.ReadLine();
                std.name = testName;

                int num;
                test = int.TryParse(testName, out num);

                if (test)
                {
                    Console.WriteLine("문자열을 입력하시오");
                }
            }
            while (test);

            //1.점수 확인
            do
            {
                Console.WriteLine("첫 번째 학생 점수 입력 : ");
                testNum = Console.ReadLine();

                test = int.TryParse(testNum, out std.score);

                if (std.score < 0 || std.score > 100)
                {
                    Console.WriteLine("범위를 벗어난 숫자");
                }
                else if (!test)
                {
                    Console.WriteLine("숫자를 입력하시오");
                }
            }
            while (!test || std.score < 0 || std.score > 100);

            do
            {
                Console.WriteLine("두 번째 학생 이름 입력 : ");
                testName = Console.ReadLine();
                std2.name = testName;

                int num;
                test = int.TryParse(testName, out num);

                if (test)
                {
                    Console.WriteLine("문자열을 입력하시오");
                }
            }
            while (test);

            //1.점수 확인
            do
            {
                Console.WriteLine("두 번째 학생 점수 입력 : ");
                testNum = Console.ReadLine();

                test = int.TryParse(testNum, out std2.score);

                if (std.score < 0 || std.score > 100)
                {
                    Console.WriteLine("범위를 벗어난 숫자");
                }
                else if (!test)
                {
                    Console.WriteLine("숫자를 입력하시오");
                }
            }
            while (!test || std.score < 0 || std.score > 100);

            if (std.score > std2.score)
            {
                Console.WriteLine($"점수가 더 높은 학생은 {std.name} 입니다.");
            }
            else
            {
                Console.WriteLine($"점수가 더 높은 학생은 {std2.name} 입니다.");
            }
        }
    }
}
