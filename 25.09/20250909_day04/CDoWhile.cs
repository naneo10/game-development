
namespace _20250909_day04
{
    internal class CDoWhile
    {
        /*
        [do-while]
        -코드블록을 한 번 실행 후(한 번은 반드시 실행되는 것을 보장) 조건식의 true, false에 따라 블록을 반복하는 반복문

        [for]
        -반복문중 하나. 일정한 횟수만큼 반복할 때 유용
        -while보다 정밀한 제어가 가능하고 반복횟수가 명확할 때 while보다 for문을 사용하는 것이 일반적이다.

        기본구조
        for (초기식; 조건식; 증감식)
        {
            //반복할 코드
        }
        1.초기식: 반복을 시작하기 전 한 번 실행(변수선언 및 초기화)
        2.조건식: 반복이 계속될 조건(결과 false가 될 때 까지 반복)
        3.증감식: 한 번 실행 후, 변수의 값을 증가 또는 감소
        */
        static void Main()
        {
            //int input;
            //do
            //{
            //    Console.WriteLine("1 에서 9 사이의 수를 입력해라 : ");
            //    string text = Console.ReadLine();
            //    int.TryParse(text, out input);
            //}
            //while (input < 1 || input > 9);

            //초기 값; 조건식; 증감식;
            for (int i = 0; i < 5; i++)
            //1.int형 변수 i를 선언하고 0으로 초기화
            //2.조건식 실행(i<5)
            //3.조건식이 true이기 때문에 Console.WriteLine(i); 첫 번째 반복 수행
            //4.증가 실행 (i++)
            //5.조건식 i<5 실행, 조건식이 false가 될 때 까지 i를 1씩 증가하면서 출력
            {
                Console.WriteLine(i); //0, 1, 2, 3, 4
            }

            Console.WriteLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i); // 1, 2, 3
            }

            //입력한 값 만큼 출력
            int inputNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNum; i++)
            {
                Console.WriteLine("입력한 값만큼 반복한다.");
            }

            Console.WriteLine();

            //홀수만 출력
            for(int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }

            //1부터 100까지의 합을 구하려면
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            /*
            [다중 for문(중첩)]
            -for문은 if문 처럼 중첩해서 자주 사용
            -while보다 반복제어 장치가 잘 갖춰져 있기에 중첩해서 반복을 해야한다면 while보다 for문을 사용하는게 적절할 수 있음
            */

            /*
            i의 값: 0, k의 값 : 0
            i의 값: 0, k의 값 : 1
            i의 값: 0, k의 값 : 2
            i의 값: 1, k의 값 : 0
            i의 값: 1, k의 값 : 1
            i의 값: 1, k의 값 : 2
            i의 값: 2, k의 값 : 0
            i의 값: 2, k의 값 : 1
            i의 값: 2, k의 값 : 2 
            */
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine($"i의 값: {i}, k의 값 : {k}");
                }
            }

            //중첩을 이용한 구구단
            for (int i = 2; i <= 9; i++)
            {
                for(int k = 1; k <= 9; k++)
                {
                    Console.WriteLine("출력");
                }
            }

            /*
            제어문
            [break]
            -반복문 또는 분기문에서 사용
            -해당 구문을 종료
            */
            Console.WriteLine("===break 제어문===");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) break; //i가 5일 때 반복문 종료
                Console.WriteLine(i);
            }

            /*
            제어문
            [continue]
            -반복문에서 사용. 현재 반복을 건너뛰고 다음 반복으로 넘어가게함
            */

            Console.WriteLine("===Continue 제어문===");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) continue; //i가 짝수일 때 아래에 있는 코드를 건너뛰고 다음 반복으로 진행
                Console.WriteLine(i);
            }

            //2, 3의 배수를 제외
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) continue;
                if (i % 3 == 0) continue;
            }

            /*
            *
            **
            ***
            ****
            *****
            */
            //별 찍기
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <=i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
