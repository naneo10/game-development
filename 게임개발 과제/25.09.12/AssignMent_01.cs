
using Microsoft.VisualBasic;

namespace _25._09._12
{
    /*
    [열거형을 활용한 직업선택 구현하기]
    
    요구사항
    1.job이라는 열거형을 정의한다.
        -Warrior, Mage, Rogue 세 가지 직업을 포함한다.
    2.사용자에게 직업 번호(1~3)를 입력받는다.
    3.입력한 값에 맞는 직업 이름과 특징을 출력한다.
    */

    /*
    [예시 출력]
    직업을 선택하세요 (1: 전사, 2: 마법사, 3: 도적): 2
    당신은 마법사를 선택했습니다!
    특징: 강력한 마법으로 원거리 공격이 가능합니다.
    */

    /*
    public 이란? : https://geukggom.tistory.com/83
    enum 그리고 switch case : https://yundongdong.tistory.com/7
    enum타입과 switch문 : https://gavenkr.tistory.com/14
    int를 Enum으로 변환 : https://www.delftstack.com/ko/howto/csharp/csharp-int-to-enum/
    */
    internal class AssignMent_01
    {
        enum job
        {
            Warrior,
            Mage,
            Rogue
        }

        static void Main ()
        {
            //값 입력
            Console.WriteLine("직업은 선택하시오. (1: 전사, 2: 마법사, 3: 도적");
            int choiceJ = int.Parse(Console.ReadLine());

            //enum타입으로 변환

            int select = choiceJ - 1;

            job selectChange = (job)select;

            switch (selectChange)
            {
                case job.Warrior:
                    {
                        Console.WriteLine("당신은 전사를 선택했습니다!");
                        Console.WriteLine("특징: 강력한 힘으로 접근전에 능합니다.");
                    }
                    break;
                case job.Mage:
                    {
                        Console.WriteLine("당신은 마법사를 선택했습니다!");
                        Console.WriteLine("특징: 강력한 마법으로 원거리전에 능합니다.");
                    }
                    break;
                case job.Rogue:
                    {
                        Console.WriteLine("당신은 도적을 선택했습니다!");
                        Console.WriteLine("특징: 재빠른 신체능력으로 회피에 능합니다.");
                    }
                    break;
            }
        }
    }
}
