
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

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
    C# LINQ의 내부구조 및 장단점 : https://highcl.tistory.com/50
    */

    /*
    카드추가 : https://stackoverflow.com/questions/61398404/how-do-i-add-a-deck-of-cards-to-an-array-in-c-sharp
    ToList, ToArray 메서드 : https://developer-talk.tistory.com/655
    IEnumerable 인터페이스란? : https://developer-talk.tistory.com/345
    원하는 갯수만 추출 : https://chashtag.tistory.com/entry/C-List-%EC%9B%90%ED%95%98%EB%8A%94-%EA%B0%9C%EC%88%98%EB%A7%8C-%EC%96%BB%EA%B8%B0-Take-Skip
    */

    public class Card
    {
        //get, set : https://jeongkyun-it.tistory.com/23
        public string Type { get; set; }
        public string Numb { get; set; }

        public int CompareValue
        {
            // property get, set : https://developer-talk.tistory.com/39
            get
            {
                switch (Numb)
                {
                    case "A":
                        return 1;
                    case "J":
                        return 11;
                    case "Q":
                        return 12;
                    case "K":
                        return 13;
                    default:
                        return int.Parse(Numb);
                }
            }
        }
    }
    public class AssignMent_03
    {
        static void Main()
        {
            string[] types = { "♠", "♥", "♣", "◆" };
            string[] numbs = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            List<Card> deck = (from t in types
                               from n in numbs
                               select new Card { Type = t, Numb = n }).ToList();

            int useCard = 0;

            int money = 10000;
            int betting = 0;

            /*
            foreach (var check in deck)
            {
                Console.WriteLine($"타입 : {check.Type}, 넘버 : {check.Numb} ");
            }
            */

            Random rand = new Random();
            int Round = 0;

            do
            {
                Round++;

                Console.WriteLine($"=======현재 {Round}라운드=======");

                //타입 3개 랜덤으로 뽑기
                var chosenType = types.OrderBy(a => rand.Next()).Take(3).ToList();
                //띄어쓰기 : https://shanael.tistory.com/64
                //"," : https://learn.microsoft.com/ko-kr/dotnet/api/system.string.join?view=net-8.0
                /*
                Console.WriteLine("Type: " + string.Join(", ", chosenType));
                */

                //Contains의 true인 카드만 남기기
                var playDeck = deck.Where(a => chosenType.Contains(a.Type)).ToList();

                //랜덤 3장 뽑기
                playDeck = playDeck.OrderBy(a => rand.Next()).ToList();
                var drawn = playDeck.Take(3).ToList();
                var publicCard = drawn.Take(2).ToList();

                foreach (var draw in publicCard)
                {
                    Console.Write("타입: " + string.Join(", ", draw.Type) + " " + string.Join(", ", draw.Numb) + " / ");
                }
                Console.WriteLine("? ? ?(배팅카드)");
                Console.WriteLine();

                //배팅
                do
                {
                    //현재 보유금
                    Console.WriteLine($"현재 보유금액 {money}원");
                    Console.WriteLine("배팅 금액을 입력하시오.");
                    string inputCount = Console.ReadLine();

                    int value;
                    bool isSuccess = int.TryParse(inputCount, out value);

                    if (!isSuccess)
                    {
                        Console.WriteLine("정수를 입력하시오");
                    }
                    else if (value < 1000 || value > money)
                    {
                        Console.WriteLine("최소 배팅금액은 1,000이며, 소지금 초과 배팅은 불가하다.");
                    }
                    else
                    {
                        betting = value;
                        break;
                    }
                }
                while (true);

                Console.WriteLine();

                //배팅규칙

                //룰
                if (drawn[0].CompareValue < drawn[2].CompareValue && drawn[2].CompareValue < drawn[1].CompareValue)
                {
                    money += betting;
                    Console.WriteLine($"{betting}원을 획득했다");
                }
                else if (drawn[0].CompareValue > drawn[2].CompareValue && drawn[2].CompareValue > drawn[1].CompareValue)
                {
                    money += betting;
                    Console.WriteLine($"{betting}원을 획득했다");
                }
                else
                {
                    money -= betting;
                    Console.WriteLine($"{betting}원을 잃었다");
                }


                //사용한 카드 수 계산
                useCard += drawn.Count();
                Console.WriteLine($"현재 사용한 카드 수 : {useCard}");

                //사용한 카드 삭제
                deck.RemoveAll(a => drawn.Contains(a));
                Console.WriteLine();
            }
            while (money >= 1000 && useCard <= 50);
            Console.WriteLine("======= 게임 종료 =======");
            if (money < 1000)
            {
                Console.WriteLine("소지금이 부족합니다.");
            }
            else
            {
                Console.WriteLine("카드를 모두 사용하였습니다.");
            }
        }//Main
    }

}
