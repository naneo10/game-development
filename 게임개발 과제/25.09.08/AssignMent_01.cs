
using System.Reflection.PortableExecutable;

namespace assignment_25._09._08
{
    /*
    과제 01

    ===1. 성적등급 판정기 ===

    요구사항
    1.점수(int)를 입력받을 것
    2.점수가 90점 이상이면 "A 등급" 출력
    3.80점 이상이면 "B 등급" 출력
    4.70점 이상이면 "C 등급" 출력
    5.60점 이상이면 "D 등급" 출력
    6.그외 "F 등급" 출력
    */
    internal class AssignMent_01
    {
        static void Main ()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("시험점수를 입력하세요. (0 ~ 100)");
                int testScore = int.Parse(Console.ReadLine());

                if (testScore >= 0 && testScore <= 100)
                {
                    if (testScore >= 90)
                    {
                        Console.WriteLine("A 등급");
                    }
                    else if (testScore >= 80) 
                    {
                        Console.WriteLine("B 등급");
                    }
                    else if (testScore >= 70)
                    {
                        Console.WriteLine("C 등급");
                    }
                    else if (testScore >= 60)
                    {
                        Console.WriteLine("D 등급");
                    }
                    else
                    {
                        Console.WriteLine("F 등급");
                    }
                }
                else 
                {
                    Console.WriteLine("점수를 잘못 기입하셨습니다.");
                }
            }
        }
    }
}
