
using System.Security.Cryptography.X509Certificates;

namespace _25._09._09
{
    /*
    과제
    01. 가위바위보 게임

    요구사항
    1.매 라운드 1=가위, 2=바위, 3=보 정수만 허용(플레이어 입력)
    2.컴퓨터 선택: 랜덤 클래스를 활용하여 1~3중 하나 선택
    3.플레이어와 컴퓨터 비교는 int타입으로 할 것
    4.판정 규칙
        -플레이어 가위 vs 컴퓨터 바위 : 컴퓨터 승
        -플레이어 보 vs 컴퓨터 바위 : 플레이어 승
        -플레이어 보 vs 컴퓨터 보 : 무승부
    5.게임은 5판으로 제한하며 최종결과를 출력할 것
    */
    internal class AssignMent_01
    {
        static void Main()
        {
            //랜덤 데이터 타입 변수명 지정 및 초기화
            Random random = new Random();

            //반복문 안에서 초기화 되지 말아야 하는 변수 값
            int playCount = 0;
            int win = 0;
            int lose = 0;
            int draw = 0;

            //5회 반복을 위한 for문
            for (int i = 0; i < 5; i++)
            {
                //반복 회차를 표기 하기 위한 구문
                playCount++;

                //회차 별 승패를 구분하기 위한 변수명 지정 및 초기화
                int playerWin = 0;
                int computerWin = 0;
                string textResult = "";

                //사용자에게 보여주는 선택지
                Console.WriteLine($"[{playCount}번째 판] 너의 선택은 (1: 가위, 2: 바위, 3: 보)");
                //선택지에 입력한 값을 변수로 받기 위한 구문
                int player = int.Parse(Console.ReadLine());

                //상수 변수명 'computer' 지정 및 랜덤 메서드
                int computer = random.Next(1,3);

                //상수로 나오는 값을 문자열로 나타내기 위한 구문
                string playerType = "";
                string computerType = "";
                
                //switch문을 사용하여 입력 값, 결과 값으로 나온 실수를 명시된 문자열로 변경
                switch (player)
                {
                    case 1: { playerType += "가위"; } break;
                    case 2: { playerType += "바위"; } break;
                    case 3: { playerType += "보"; } break;
                    default: { Console.WriteLine("범위 내의 값을 입력하세요."); } break;
                }

                switch (computer)
                {
                    case 1: { computerType += "가위"; } break;
                    case 2: { computerType += "바위"; } break;
                    case 3: { computerType += "보"; } break;
                }

                //무승부 비교
                if (player == 1 && computer == 1)
                {
                    //최종 결과 무승부 값 변수를 증감
                    draw++;
                }
                else if (player == 2 && computer == 2)
                {
                    draw++;
                }
                else if (player == 3 && computer == 3)
                {
                    draw++;
                }

                //가위 변수 비교
                if (player == 1 && computer != 1)
                {
                    if (player == 1 && computer == 2)
                    {
                        //최종 결과 패배 값 변수를 증감
                        lose++;
                        //이번 판의 결과를 나타내기 위한 증감
                        computerWin++;
                    }
                    else if (player == 1 && computer == 3)
                    {
                        ////최종 결과 승리 값 변수를 증감
                        win++;
                        playerWin++;
                    }
                }

                //바위 변수 비교
                if (player == 2 && computer != 2)
                {
                    if (player == 2 && computer == 1)
                    {
                        win++;
                        playerWin++;
                    }
                    else if (player == 2 && computer == 3)
                    {
                        lose++;
                        computerWin++;
                    }
                }

                //보 변수 비교
                if (player == 3 && computer != 3)
                {
                    if (player == 3 && computer == 2)
                    {
                        win++;
                        playerWin++;
                    }
                    else if (player == 3 && computer == 1)
                    {
                        lose++;
                        computerWin++;
                    }
                }

                //판당 결과를 표기하기 위한 구문
                int result = playerWin - computerWin;

                switch (result)
                {
                    case -1: { textResult = "컴퓨터 승"; } break;
                    case 0: { textResult = "무승부"; } break;
                    case 1: { textResult = "플레이어 승"; } break;
                }

                //결과에 따라 값이 달라지는 부분은 변수로 받아서 변수로 출력
                Console.WriteLine($"플레이어 : {playerType} vs 컴퓨터 : {computerType} {textResult}" );
                Console.WriteLine();
            }
            Console.WriteLine("...");
            Console.WriteLine("=== 최종 결과 ===");
            //최종 결과 값을 도출하기 위해 for문 밖 변수에 값을 받음
            Console.WriteLine($"승: {win}, 패: {lose}, 무승부: {draw}");

            //최종 결과 값의 결과를 나타내기 위해 if문을 사용
            if (win > lose)
            {
                Console.WriteLine("최종 승리!");
            }
            else if (win == lose)
            {
                //5판 모두 비결 경우 대비
                //값을 잘못 입력하여 시행횟수가 짝수이며 무승부로 떨어질 경우 대비
                //잘못 된 값 입력 시 재실행하는 구문으로 수정 필요
                Console.WriteLine("최종 무승부!");
            }
            else
            {
                Console.WriteLine("최종 패배!");
            }
        }
    }
}
