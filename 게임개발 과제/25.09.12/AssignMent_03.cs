
namespace _25._09._12
{
    /*
    [월남뽕 게임 과제]
    1.카드 초기화 & 셔플
    -52장 덱을 0~51로 초기화한다.
    -임의의 두 인덱스를 뽑아 스왑하여 셔플한다.

    2.라운드 진행(3장 사용)
    -매 라운드 앞에서 부터 3장을 사용한다: A(공개), B(공개), C(배팅 카드).
    -세 장의 문양 (♠ ♣ ◆ ♥)과 숫자(A,2 ~ 10,J,Q,K)를 한 줄에 출력한다.
    -사용한 카드 수를 !누적 관리 한다.

    3.배팅 입력
    -시작 자금은 money = 10,000으로 한다.
    -화면에 내가 가진 스드머니: money를 표시한다.
    -베팅금액을 입력하시오!를 출력하고 정수 배팅액을 입력받는다
    -최소 배팅액은 1000이며, 소지금 초과 베팅은 불가하다.

    4.판정 규칙 & 정산
    -승리 조건: A < C < B 또는 A > C > B (정확히 사이 값일 때만)
    -위 조건이면 money += betting 을 하고 "betting 원을 획득했다"를 출력한다.
    -아니면 money -= betting을 하고 "betting 원을 잃었다"를 출력한다.
    -라운드 종료 후 현재 사용한 카드 수: useCard를 출력한다.

    5.종료 조건
    -덱 소진: 사용 카드가 부족하면 종료한다.
    -파산: 소지금이 1,000 미만이면 종료한다.

    6.입력 검증
    -잘못된 입력 시(정수가 아닌 경우) 재입력 요구.
    -배팅엑이 최소 배팅액 미만이거나 소지금 초과 시 재입력 한다.

    *체크
    -A는 무조건 1로 가정한다.
    */

    /*
    인덱스 범위 : https://blog.naver.com/yulian/223774028139
    */

    internal class AssignMent_03
    {
        static void Main ()
        {
            Random random = new Random();

            //0~51까지의 정수를 담을 배열 생성
            int[] playCard = new int[52];

            //카드 할당
            for (int i = 0; i < playCard.Length; i++)
            {
                playCard[i] = i;
                Console.WriteLine(playCard[i]);
            }
            for (int i = playCard.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = playCard[i];
                playCard[i] = playCard[j];
                playCard[j] = temp;
            }

            //임의의 두 인덱스가 될 네 인덱스
            int[,] cardTypeNum = new int[4, 13];


            //랜덤으로 인덱스 두 개를 선택하고 각 인덱스에 13개의 값을 할당한다?
        }
    }
}
