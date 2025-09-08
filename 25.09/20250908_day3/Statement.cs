using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250908_day3
{
    /*
    [if]
    -조건에 따라 실행이 달라지게 할 때 사용하는 문장
    -조건식의 true, false에 따라 실행할 블록을 결정하는 조건문
    -특정 조건에 의해 선택적으로 실행이 가능

    if (조건)
        {
            위의 조건이 참이라면 실행할 코드
            위의 조건이 참이라면 코드블럭이 실행된다
        }

    [else]
    -if문의 조건이 false일때 실행
    if(false)
    {
        
    }
    else
    {

    }
    
    [else if]
    -연속된 if문과 비슷하지만 차이가 있다.
    if(조건1)
    {
        //조건 1이 참일 때 실행
    }
    else if(조건 2)
    {
        //조건 1이 거짓이고 조건 2가 참일 때 실행
    }
    else
    {
        //모든 조건이 거짓일 때 실행
    }
    */
    internal class Conditional
    {
        static void Main ()
        {
            if (true)
            {
                Console.WriteLine("조건이 참이라면 이 구문이 실행된다");
            }

            if(false)
            {
                Console.WriteLine("조건이 참이라면 두 번째 if문 구문이 실행된다");
            }

            if(true) //여기가 거짓이면 실행해야할 조건
            {
                Console.WriteLine("조건이 참이라면 세 번째 if문 구문이 실행된다");
            }

            //거짓일 경우 뭔가를 실행해야 할 때
            if(false)
            {
                Console.WriteLine("참이면 이 구문이 실행");
            }
            //위에 있는 조건이 거짓일 경우 뭔가를 실행해야 한다.
            else //단독으로 올 수 없다
            {
                Console.WriteLine("거짓이면 이 구문이 실행");
            }

                Console.WriteLine("실행");

            //else if

            int hp = 30;
            if(hp > 50)
            {
                Console.WriteLine("캐릭터가 건강합니다.");
            }
            else
            {
                Console.WriteLine("캐릭터의 건강이 좋지 않습니다.");
            }

            int hp1 = 50;
            if (hp1 > 70) //조건 1
            {
                Console.WriteLine("캐릭터가 건강합니다.");
            }
            else if (hp1 > 40) //조건 2
            {
                Console.WriteLine("캐릭터가 보통상태입니다.");
            }
            else  //위에있는 조건이 전부 거짓일 경우
            {
                Console.WriteLine("급격한 체력저하");
            }

            int mp = 30;
            if(mp <= 30) //true
            {
                Console.WriteLine("mp가 부족하다 (첫 번째 if)");
            }
            else if (mp == 30) //true
            {
                Console.WriteLine("mp가 부족하다 (두 번째 if)");
            }
            if(mp >= 30) //true
            {
                Console.WriteLine("mp가 부족하다 (세 번째 if)");
            }

            int hp2 = 60;
            bool hasShield = false;
            if(hp2 > 50) //true
            {
                Console.WriteLine("캐릭터가 매우 건강하다");

                if (hasShield) //true
                {
                    Console.WriteLine("방어막이 활성화 되어 있다");
                }
                else
                {
                    Console.WriteLine("방어막이 비활성화 되어 있다");
                }
            }

            //우리가 입력한 어떤 수가 홀수인지 짝수인지 판단하고 싶다면?

            int input;
            input = int.Parse(Console.ReadLine()); //입력을 받고
            //조건문을 입력
            if((input % 2) == 0) 
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.Write("홀수");
            }

            Console.WriteLine();

            //계절맞추기
            //1. 1 ~ 12까지 입력을 받는다.
            //2. 3 ~ 5 봄 / 6 ~ 8 여름 / 9 ~ 11 가을 / 그 외 겨울
            //3. 1 ~ 12까지 외의 수를 입력했다. -> "잘못된 월을 입력했다"

            Console.WriteLine("===계절을 맞춰보세요===");
            Console.WriteLine("월을 입력하시요 ( 1~12 )");
            int month;
            month = int.Parse(Console.ReadLine());

            if (month >= 1 && month <= 12)
            {
                if (month >= 3 && month <= 5)
                {
                    Console.WriteLine("봄입니다.");
                }
                else if (month >=6 && month <= 8)
                {
                    Console.WriteLine("여름입니다.");
                }
                else if (month >= 9 && month <= 11)
                {
                    Console.WriteLine("가을입니다.");
                }
                else
                {
                    Console.WriteLine("겨울입니다.");
                }
            }
            else
            {
                Console.WriteLine("잘못된 월을 입력했다.");
            }
        }
    }
}
