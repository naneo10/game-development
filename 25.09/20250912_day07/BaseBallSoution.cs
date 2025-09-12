
namespace _20250912_day07
{
    internal class BaseBallSoution
    {
        //
        const int DIGITCOUNT = 3; //자리
        const int MINNUMBER = 0;
        const int MAXNUMBER = 9;
        const int OUTCOUNT = 3;

        static void Main ()
        {
            Random rand = new Random();
            int[] ballArr = ArrInit();

            Shuffle(ballArr, rand);

            int[] comNumber = Pick(ballArr, DIGITCOUNT);

            PrintNumber("컴퓨터가 낸 숫자", comNumber);

            int totalOut = 0;

            while (true)
            {
                Console.WriteLine("\n 0~9까지의 숫자를 입력해라");

                int[] myNumber = PlayerInput(DIGITCOUNT, MINNUMBER, MAXNUMBER);

                int ballCount, strikeCount;
                judgement(comNumber, myNumber, out ballCount, out strikeCount);
            }
        }
        //배열 초기화
        static int[] ArrInit()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        //셔플
        static void Shuffle(int[] arr, Random rand)
        {
            for (int i = arr.Length -1; i > 0; i--) //9번째 카드와
            {
                int k = rand.Next(i + 1); //9 + 1 카드를 섞어주고
                int temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
            }
        }

        //Pick
        static int[] Pick(int[] arr, int count)
        {
            int[] result = new int[count];
            for(int i = 0; i < count; i++)
            {
                result[i] = arr[i];
            }
            return result;
        }

        //숫자 출력
        static void PrintNumber(string str, int[] num)
        {
            Console.Write(str);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }

        //사용자 인풋
        static int[] PlayerInput(int count, int min, int max)
        {
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    Console.Write($"{i + 1}번째 숫자 입력: ");
                    string line = Console.ReadLine();

                    int value;
                    bool isSuccess = int.TryParse(line, out value);

                    if(!isSuccess)
                    {
                        Console.WriteLine("정수를 입력해라");
                        continue;
                    }
                    //범위검사
                    if(value < min || value > max)
                    {
                        Console.WriteLine($"{min}~{max}사이의 값을 입력해라!!");
                        continue;
                    }
                    //중복체크
                    if(Contains(arr, i, value))
                    {
                        Console.WriteLine("이미 입력한 숫자. 다시 입력해라");
                        continue;
                    }
                    arr[i] = value;
                    break;
                }
            }
            return arr;
        }

        //중복체크
        static bool Contains(int[] arr, int length, int value)
        {
            for(int i = 0; i < length; i++)
            {
                if (arr[i] == value) return true;
            }
            return false;
        }

        //판정
        static void judgement(int[] comNumber, in[] playerNumber, out int ball, out int strike)
        {
            ball = 0;
            strike = 0;

            for (int i = 0; i < comNumber.Length; i++)
            {
                for (int k = 0; k < playerNumber.Length; k++)
                {
                    if (comNumber[i] == comNumber[k])
                    {
                        if (i == k)
                        {
                            strike++;
                        }
                        else
                        {
                            ball++;
                        }
                    }
                }
            }
        }
    }
}
