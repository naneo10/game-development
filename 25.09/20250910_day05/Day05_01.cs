
using System.ComponentModel.Design;

namespace _20250910_day05
{
    internal class Day05_01
    {
        //가위 바위 보
        static void Main ()
        {
            Console.WriteLine("=== 가위 바위 보 게임 (5판 진행)===");
            Console.WriteLine("입력방법: 1 = 가위, 2 = 바위, 3 = 보");

            Random rng = new Random();

            int win = 0;
            int lose = 0;
            int draw = 0;

            int round = 0;

            //가위 바위 보 메인루프
            while (true)
            {
                round++;
                if (round >= 6) break;

                Console.WriteLine($"[{round}번째 판] 너의 선택은 ( 1: 가위, 2: 바위, 3: 보)");
                Console.Write("->");
                string input = Console.ReadLine();

                if(!int.TryParse(input, out int userChoice) || userChoice < 1 || userChoice > 3)
                {
                    Console.WriteLine("잘못된 입력이다. 1, 2, 3 중에 입력");
                    //다시
                    continue;
                }

                int comChoice = rng.Next(1, 4);

                //예시 1
                //string userName = "";
                //if (userChoice == 1) userName = "가위";
                //else if (userChoice == 2) userName = "바위";
                //else userName = "보";

                //string comName = "";
                //if (comChoice == 1) comName = "가위";
                //else if (comChoice == 2) comName = "바위";
                //else comName = "보";

                //예시 2
                //삼항연산자는 중첩하는게 오히려 보기가 힘들 수 있다.
                string userName = userChoice == 1 ? "가위" : userChoice == 2 ? "바위" : "보";
                string comName = comChoice == 1 ? "가위" : comChoice == 2 ? "바위" : "보";

                Console.WriteLine($"유저는 : {userName}");
                Console.WriteLine($"컴퓨터 : {comName}");

                bool isUserWin = (userChoice == 1 && comChoice == 3) || (userChoice == 2 && comChoice == 1) || (userChoice == 3 && comChoice == 2);
                //승패 판정
                if (userChoice==comChoice)
                {
                    Console.WriteLine("무승부 입니다.");
                    draw++;
                }
                else if (isUserWin)
                {
                    Console.WriteLine("이겼음");
                    win++;
                }
                else
                {
                    Console.WriteLine("졌음");
                    lose++;
                }
                Console.WriteLine($"현재 승:{win}, 패: {lose}, 무승부: {draw}\n");
            }//while

            //최종결과
            Console.WriteLine("===최종 결과===");
            Console.WriteLine($"승: {win}, 패: {lose}, 무승부: {draw}");
            if (win > lose) Console.WriteLine("최종승리");
            else if (win < lose) Console.WriteLine("최종패배");
            else Console.WriteLine("무승부");
        }
    }
}
