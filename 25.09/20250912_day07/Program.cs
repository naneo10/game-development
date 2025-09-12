namespace _20250912_day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //난수 발생
            Random rand = new Random();

            //0~9까지의 정수를 담을 배열 생성
            int[] number = new int[10];
            for(int i = 0; i < number.Length; i++)
            {
                number[i] = i;
            }
            for (int i = number.Length - 1; i > 0; i--) 
            {
                int k = rand.Next(i + 1);
                int temp = number[i];
                number[i] = number[k];
                number[k] = temp;
            }

            int[] comNumber = new int[3];

            for (int i = 0; i < 3; i++)
            {
                comNumber[i] = number[i];
            }

            Console.Write("컴퓨터가 낸 숫자 : ");

            for(int i = 0; i < 3; i++)
            {
                Console.Write(comNumber[i]+ " ");
            }
            Console.WriteLine();

            //플레이어가 매턴 입력할 3개
            int[] myNumber = new int[3];
            
            int totalCount = 0;

            //메인루프
            while (true)
            {
                Console.WriteLine("\n0~9까지의 숫자들을 입력하세요.");

                //플레이어 3개 입력
                for (int i = 0; i < 3; i++)
                {
                    while (true)
                    {
                        Console.Write($"{i + 1}번째 숫자를 입력하세요 : ");
                        string line = Console.ReadLine();

                        //숫자인지 검사
                        int value;
                        bool isSuccess = int.TryParse(line, out value);
                        if(!isSuccess)
                        {
                            Console.WriteLine("정수를 입력해라");
                            continue;
                        }

                        //범위검사
                        if(value < 0 || value > 9)
                        {
                            Console.WriteLine("0~9사이의 값을 입력해라!");
                            continue;
                        }

                        //중복검사
                        bool isDuplicate = false;
                        for(int k = 0; k < i; k++)
                        {
                            if (myNumber[k]==value)
                            {
                                isDuplicate = true;
                                break;
                            }
                        }
                        if (isDuplicate)
                        {
                            Console.WriteLine("이미 입력한 숫자임. 다시입력");
                            continue;
                        }
                        //값 입력
                        myNumber[i] = value;
                        break;
                    }//while
                }//for

                int ballCount = 0;
                int strikeCount = 0;

                //핵심(판정)
                for (int i = 0; i < 3; i++) //com
                {
                    for (int k = 0; k < 3; k++) //player
                    {
                        if (comNumber[i] == myNumber[k]) //값이 같으면
                        {
                            if (i == k) strikeCount++; //자리까지 같으면
                            else ballCount++; //아니면 볼
                        }
                    }
                }
                if (strikeCount==0 && ballCount==0)
                {
                    totalCount++;
                    Console.WriteLine($"아웃! 현재 아웃 : {totalCount}");
                }
                else
                {
                    Console.WriteLine($"{ballCount}볼 {strikeCount}스트라이크");
                }
                if (strikeCount==3)
                {
                    Console.WriteLine("삼진아웃");
                    break;
                }
                if (totalCount >= 3)
                {
                    Console.WriteLine("게임종료");
                    break;
                }


            }//while
        }
    }
}
