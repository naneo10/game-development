
namespace _20250909_day04
{
    /*
    [Random]class
    -의사 난수(Pseudo Random Number)를 생성
    -실제 무작위가 아닌 시드 값을 기반으로 한 예측 가능한 난수를 생성
    -보통 게임, 시뮬레이션, 간단한 무작위 이벤트 처리등에 사용

    [seed]
    -시드는 난수를 만드는데 필요한 출발 값(초기 값)
    -어떤 패턴의 난수가 나올지 결정하는 시작 값이 시드

    [Random class의 주요 매서드]
    -Next() : 0이상 int.MaxValue 이하 난수를 반환
    -Next(minValue, maxValue) : minValue 이상 maxValue미만의 난수 반환
    -NextDouble
    */
    internal class CRandomNumber
    {
        static void Main()
        {
            Random rand = new Random();
            //1,826,531,697
            //1,238,684,481
            int num1 = rand.Next(); //0~int.MaxValue 미만의 정수를 반환
            Console.WriteLine(num1);
            int num2 = rand.Next(10); //0이상 10미만의 정수
            Console.WriteLine(num2);
            int num3 = rand.Next(5,15); //5이상 15미만의 정수
            Console.WriteLine(num3);

            double num4 = rand.NextDouble(); //double.minValue 이상 double.maxVaule 미만 실수를 반환
            Console.WriteLine(num4);

            //Random randomDice = new Random();
            //int dice = randomDice.Next(1, 7);
            int dice = rand.Next(1, 7);

            Console.WriteLine($"주사위를 굴렸다. 나온 숫자는 : {dice}");

            if (dice == 6)
            {
                Console.WriteLine("6");
            }
            else if (dice >= 4)
            {
                Console.WriteLine("높은 숫자");
            }
            else
            {
                Console.WriteLine("다시도전");
            }

            int count = 0;
            bool isDead = false;

            while (!isDead)
            {
                count++;
                int damage = rand.Next(1, 11);
                Console.WriteLine($"{count}번쨰 공격! {damage}데미지");

                if(damage >= 8)
                {
                    Console.WriteLine("몬스터가 죽다.");
                    isDead = true;
                }
            }
            //TimeSpan: 콘솔 텍스트 딜레이
        }
    }
}
