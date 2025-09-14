
using System.Security.AccessControl;

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

    /*
    LINQ : https://hijuworld.tistory.com/56
    List<> : https://coding-shop.tistory.com/130
    카드추가 : https://stackoverflow.com/questions/61398404/how-do-i-add-a-deck-of-cards-to-an-array-in-c-sharp
    C# LINQ의 내부구조 및 장단점 : https://highcl.tistory.com/50
    */

    public class Card
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
    };

    internal class AssignMent_03
    {
        enum Cards
        {
             A = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, J = 11, Q = 12, K = 13
        }
        static void Main()
        {
            var cardTypes = new List<string>()
            {
                "♠", "◆", "♥", "♣"
            };

            List<Card> deck = new List<Card>();

            var cardsValues = Enum.GetValues(typeof(Cards));
            for (int c = 0; c < cardsValues.Length; c++)
            {
                foreach (var cardType in cardTypes)
                {
                    deck.Add(new Card
                    {
                        Name = Enum.GetName(typeof(Cards), c),
                        Type = cardType,
                        //Value = cardsValues[c]
                    });
                }
            }

        }
    }

}
