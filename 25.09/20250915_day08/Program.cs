namespace _20250915_day08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] card = new int[52];

            InitCards(card);
            ShuffleCards(card);

            int money = 10000;
            int useCard = 0;

            while (true)
            {
                bool isPlay = PlayRound(card, ref useCard, ref money);

                if (!isPlay) break;
            }
        }

        //1.카드 초기화
        static void InitCards(int[] card)
        {
            for(int i = 0; i < 52; i++)
            {
                card[i] = 1;
            }
        }

        //2.셔플
        static void ShuffleCards(int[] card)
        {
            Random rand = new Random();
            for (int i = card.Length - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                int temp = card[i];
                card[i] = card[k];
                card[k] = temp;
            }
        }

        //3.출력
        static void PrintCard(int val)
        {
            //◆ ♠ ♥ ♣
            int shape = val / 13;
            int number = val % 13 + 1;

            switch (shape) 
            {
                case 0: Console.Write("♠"); break;
                case 1: Console.Write("♣"); break;
                case 2: Console.Write("◆"); break;
                case 3: Console.Write("♥"); break;
            }
            
            switch (number)
            {
                case 1: Console.Write("A \t"); break;
                case 11: Console.Write("J \t"); break;
                case 12: Console.Write("Q \t"); break;
                case 13: Console.Write("K \t"); break;
                default: Console.Write(number + " \t"); break;
            }
        }

        //4.라운드 진행
        static bool PlayRound(int[] card, ref int useCard, ref int money)
        {
            int[] numbers = new int[3];

            //카드 3장 출력
            for (int i = 0; i < 3; i++)
            {
                int val = card[useCard + i];
                numbers[i] = val % 13 + 1;
                PrintCard(val);
                Console.WriteLine();
                Console.WriteLine($"내가 가진 시드머니 : {money}");

                if(money<1000)
                {
                    Console.WriteLine("파산 집으로 돌아가라");
                    return false;
                }

                Console.WriteLine("배팅액을 입력하시오");
                string input = Console.ReadLine();

                if(!int.TryParse(input, out int betting))
                {
                    return true;
                }
                if(betting<1000 || betting>money)
                {
                    return true;
                }

                //승리 판정
                bool win = IsWin(numbers);

                if (win)
                {
                    money += betting;
                    Console.WriteLine($"{betting}원을 획득했다");
                }
                else
                {
                    money -= betting;
                    Console.WriteLine($"{betting}원을 잃었다");
                }
                useCard += 3;
                Console.WriteLine($"현재 사용한 카드 수 : {useCard}");

                if (useCard >= 51)
                {
                    Console.WriteLine("카드가 없으니까 종료한다.");
                    return (true);
                }
            }

        }

        //5.판정
        //A<C<B 또는 A>C>B
        static bool IsWin(int[] numbers)
        {
            return (numbers[0] < numbers[2] && numbers[2] < numbers[1]) ||
                   (numbers[0] > numbers[2] && numbers[2] > numbers[1]);
        }
    }
}
