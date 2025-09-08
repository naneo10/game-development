
namespace _20250908_day3
{
    /*
    [반복문]
    -블록을 반복적으로 실행하는 것

    [while]
    -조건식의 true, false에 따라 블록을 반복한다.
    -기본적으로 무한반복

        while (조건)
        {
            //위 조건이 만족하면 여기가 실행
            //단, 종료조건이 있어야만 해당 while이 종료
        }
    */
    internal class CWhile
    {
        static void Main ()
        {
            //while (true)
            //{
            //    Console.WriteLine("무한 루프");
            //}

            int num = 0;

            while (num < 10) //true
            {
                num++;                      //1. 1씩 증가
                Console.WriteLine(num);     //2. while(num<10)이 false가 되는 순간 해당 while문은 종료
            }

            int coin = 400;

            while (coin > 0)
            {
                Console.WriteLine("100원 동전을 꺼낸다");
                coin -= 100;
            }

            int sum = 0;
            int num1 = 0;

            while (true) //무한루프
            {
                //조건식이 true일 경우 종료 조건이 while문 안에 있어야 한다.

                sum += num1;
                //sum = sum + num1;
                //종료조건
                if(sum > 5000)
                {
                    break;
                }
                num1++;
            }//break를 만나면 여기를 빠져나온다.
            Console.WriteLine($"sum의 값은 : {sum}");      //1~100까지의 합
            Console.WriteLine($"num1의 값은 : {num1}");    //100

            if (true)
            {
                //처리하는 뭔지 모를 코드
                if (true) // <-조건문이 false가 난다
                {
                    //여기가 안돌아간다면 코드를 역으로 검증해봐야 한다.
                }
            }
        }
    }
}