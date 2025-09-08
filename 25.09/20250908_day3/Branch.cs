using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace _20250908_day3
{
    /*
    [switch]
    -특정 값에 따라 여러경우(case)중 하나를 선택하여 실행하는 것.
    -주로 상수 값을 기준으로 분기할 때 사용됨. 코드의 가독성이 좋아짐
    -break 키워드를 통해 각 case문의 실행을 종료
    -표현식에는 문자, 정수, 열거타입 등을 사용

    [요약]
    -상수 값을 기준으로 여러 선택지중 하나를 선택하는 상황에서 사용
    -코드의 가독성을 높이고 효율성을 개선할 수 있으나 표현식의 제한이 있음
    -범위기반 비교는 불가(10 < x < 20 등)
    -if문은 범용적으로 다양한 조건을 다루기 유용(논리 연산을 활용한 복잡한 조건 처리 등)

    switch (표현식)
    {
        case 값 1:
            //값 1에 해당하는 코드
        break;

        case 값 2:
            //값 2에 해당하는 코드
        break;

        case 값 3:
            //값 3에 해당하는 코드
        break;
        default:
            //어떤 case에도 해당하지 않을 때 실행되는 코드(생략가능)
        break;
    }
    
    [break]
    -반복문이나 switch문을 제어할 때 사용
    -break가 실행되면 해당 루프나 switch문을 종료하고 break다음으로 이동하여 실행
    -다중 switch나 중첩반복문에서는 break가 있는 해당 스코프(코드블럭)만 빠져나간다.
    */
    internal class Branch
    {
        static void Main()
        {
            int number = 10;
            switch(number)
            {
                case 0: //if(number == 0)
                    Console.WriteLine("첫 번째 케이스");
                break;
                case 1: //else if(number == 1)
                    Console.WriteLine("두 번째 케이스");
                break;
                case 10: //else if(number == 10)
                    Console.WriteLine("세 번째 케이스");
                break;
                //어떤 경우와 맞지 않는 경우 default 생략가능
                default: //else
                break;
            }

            Console.WriteLine("어디로 이동할지 선택하시오.");
            Console.WriteLine("1. 로비 2. 상점 3. 전쟁터 4. 투기장");

            int inputNum = int.Parse(Console.ReadLine());
            //int a = int.TryParse
            switch (inputNum)
            {
                case 1: Console.WriteLine("로비로 이동"); break;
                case 2: Console.WriteLine("상점으로 이동"); break;
                case 3: Console.WriteLine("전쟁터로 이동"); break;
                case 4: Console.WriteLine("투기장으로 이동"); break;
                default: Console.WriteLine("선택지가 없다"); break;
            }//break를 만나여 여기로 온다.


            int job = 2;
            int skill = 1;

            switch(job)
            {
                case 1:
                    Console.WriteLine("전사를 선택했다");
                    switch(skill)
                    {
                        case 1:
                            Console.WriteLine("기본공격");
                        break;
                    }
                break;

                case 2:
                    Console.WriteLine("마법사를 선택했다");
                    switch(skill)
                    {
                        case 1:
                            Console.WriteLine("마법공격");
                        break;
                    }
                    Console.WriteLine("첫 번째 switch");
                break;
                    
            }
            Console.WriteLine("두 번째 switch");
        }
    }
}
