
namespace _25._09._09
{
    /*
    과제
    02. 별 찍기

    요구사항
    1.
        *****
         ****
          ***
           **
            *
    2.
        *****
        ****
        ***
        **
        *
    3.
            *
           **
          ***
         ****
        *****
    */
    internal class AssignMent_02
    {
        static void Main ()
        {
            //구현 항목 01
            Console.WriteLine("=== 구현 항목 01 ===");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //구현 항목 02
            Console.WriteLine("=== 구현 항목 02 ===");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //구현 항목 03
            Console.WriteLine("=== 구현 항목 03 ===");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i + 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //연습 항목 01
            Console.WriteLine("=== 연습 항목 01 ===");
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //연습 항목 02
            Console.WriteLine("=== 연습 항목 02 ===");
            for (int i = 5; i > 0; i--)
            {
                for (int j = 6; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //연습 항목 03
            Console.WriteLine("=== 연습 항목 03 ===");
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //연습 항목 04
            //줄 수를 원하는 만큼 입력 받아 생성
            //구현항목 3번 변형

            Console.WriteLine("몇 줄을 생성할 것인가?");
            int num3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < num3; i++)
            {
                for (int j = num3; j > i + 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //연습 항목 05
            //줄 수를 원하는 만큼 입력 받아 생성
            //구현항목 2번 변형

            Console.WriteLine("몇 줄을 생성할 것인가?");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < num2; i++)
            {
                for (int j = num2; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //연습 항목 06
            //줄 수를 원하는 만큼 입력 받아 생성
            //구현항목 1번 변형

            Console.WriteLine("몇 줄을 생성할 것인가?");
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = num1; k >= i + 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //연습 항목 07
            //줄 수를 원하는 만큼 입력 받아 생성
            //다이아몬드 모양
            //식이 명확하게 정리되지 않고 오류에 맞춰서 기워낸 것 처럼 되었음

            Console.WriteLine("다이아몬드 몇 줄을 생성할 것인가?");
            int diamondNum = int.Parse(Console.ReadLine());

            if (diamondNum % 2 == 0)
            {
                Console.WriteLine("짝수는 입력할 수 없습니다.");
                return;
            }
            else
            {
                int halfDiamondNum = diamondNum / 2;

                for (int i = 0; i <= halfDiamondNum; i++)
                {
                    for (int j = halfDiamondNum; j > i; j--)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < i * 2 + 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = halfDiamondNum; i > 0; i--)
                {
                    for (int j = halfDiamondNum; j >= i; j--)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < i * 2 - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
