
using System.Reflection.Metadata.Ecma335;

namespace assignment_25._09._08
{
    /*
    과제 02

    ===2. 입장 요금 계산기 ===

    요구사항
    1.나이를 입력 받을 것(int)
    2.학생 여부(y/n)를 'string'으로 입력 받을 것
    3.요금 규칙
        -13세 미만 어린이 -> 5,000원
        -13세 이상 19세 이하: 학생(y) -> 7,000원 / 학생(n) -> 8,000원
        -20세 이상 성인: 학생(y) -> 9,000원 / 학생(n) -> 10,000원 
    */
    internal class AssignMent_02
    {
        static void Main ()
        {
            Console.WriteLine("나이를 입력하세요.");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 70)
            {
                if (age < 13)
                {
                    Console.WriteLine("요금은 5.000원 입니다.");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("학생입니까? (Y/N)");
                    string student = Console.ReadLine();

                    if (student == "Y" || student == "y")
                    {
                        Console.WriteLine("요금은 7,000원 입니다.");
                    }
                    else if (student == "N" || student == "n")
                    {
                        Console.WriteLine("요금은 8,000원 입니다.");
                    }
                    else
                    {
                        Console.WriteLine("잘못 입력하셨습니다.");
                    }
                }
                else
                {
                    Console.WriteLine("학생입니까? (Y/N)");
                    string student = Console.ReadLine();

                    if (student == "Y" || student == "y")
                    {
                        Console.WriteLine("요금은 9,000원 입니다.");
                    }
                    else if (student == "N" || student == "n")
                    {
                        Console.WriteLine("요금은 10,000원 입니다.");
                    }
                    else
                    {
                        Console.WriteLine("잘못 입력하셨습니다.");
                    }
                }
            }
            else
            {
                Console.WriteLine("무료 입장 가능합니다.");
            }
        }
    }
}
