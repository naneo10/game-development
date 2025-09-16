
namespace _25._09._11
{
    /*
    [숫자 야구 게임]
    
    #요구사항
    1.컴퓨터 숫자 생성
        -0~9 사이의 숫자 배열을 만든다
        -셔플로 배열을 무작위로 섞는다
        -앞 3개의 숫자를 정답(comNumber)으로 사용한다
            *숫자는 중복되지 않는다
    2.플레이어 입력
        -0~9 사이의 정수를 3개 입력받는다
        -같은 턴 내에서는 중복 입력을 허용하지 않는다
        -정수가 아닌 값 또는 범위를 벗어나면 다시 입력받는다
    3.판정 규칙
        -스트라이크(strike): 숫자와 자리 모두 같은 때
        -볼(ball): 숫자는 같지만 자리가 다를 때
        -아웃(out): 볼과 스트라이크가 모두 아닐 때
    4.종료 조건
        -스트라이크가 3개면 -> 승리
        -아웃이 3번 누적되면 -> 패배
    */
    /*
    #예시 출력
    ^볼/스트라이크 혼합된 경우
    컴퓨터가 낸 숫자 : 3 7 1
    0~9까지의 숫자를 입력하세요.
    1번 째 숫자를 입력하세요 : 1
    2번 째 숫자를 입력하세요 : 7
    3번 째 숫자를 입력하세요 : 3
    2볼 1스트라이크

    (설명: '1'은 숫자만 같고 자리 다름 -> 볼,
    '7'은 자리 / 숫자까지 같음 -> 스트라이크
    '3'은 숫자만 같음 -> 볼)

    ^정답 맞춘 경우
    컴퓨터가 낸 숫자 : 5 2 7
    0~9까지의 숫자를 입력하세요.
    1번 째 숫자를 입력하세요 : 5
    2번 째 숫자를 입력하세요 : 2
    3번 째 숫자를 입력하세요 : 7
    0볼 3스트라이크

    삼진 아웃! 승리!

    ^아웃으로 패배한 경우
    컴퓨터가 낸 숫자 : 1 9 4
    0~9까지의 숫자를 입력하세요.
    1번 째 숫자를 입력하세요 : 3
    2번 째 숫자를 입력하세요 : 5
    3번 째 숫자를 입력하세요 : 7
    아웃! 현재 아웃: 1
    ...
    3아웃으로 게임 종료!
    */

    internal class AssignMent_01
    {
        static void Main()
        {
            //총 합 변수
            int totalStrikeCount = 0;
            int totalBallCount = 0;
            int totalRounds = 0;

            //종료 조건
            int endStrikeCount = 0;
            int endOutCount = 0;

            do
            {
                totalRounds++;
                Console.WriteLine($"[ {totalRounds}회차 경기 시작 ]");
                //각 라운드 판정 결과합 변수생성
                int strikeCount = 0;
                int outCount = 0;
                int ballCount = 0;

                //컴퓨터 배열 생성
                int[] comNumber = new int[9];

                //0~9까지의 숫자 입력
                for (int i = 0; i < comNumber.Length; i++)
                {
                    comNumber[i] = i + 1;
                }

                //셔플로 배열을 무작위로 섞음
                Random randNumb = new Random();
                for (int i = comNumber.Length - 1; i > 0; i--)
                {
                    int j = randNumb.Next(i + 1); //^i에 +1을 하는 이유는?
                    int temp = comNumber[i];
                    comNumber[i] = comNumber[j];
                    comNumber[j] = temp;
                }

                //무작위 값을 출력
                Console.Write("computer 랜덤 값 : ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(comNumber[i] + $" ");
                }
                Console.WriteLine();

                //유저 배열 생성
                int[] userNumb = new int[3]; //값 3개를 입력 받는데 3개 이상으로 해버리면 0 중복 값으로 처리됨

                do //중복된 수 기입 시 반복
                {
                    //0~9 사이의 정수를 3개 입력받음
                    for (int i = 0; i < 3; i++)
                    {
                        int convertedNumb; //변환된 정수를 저장할 변수
                        bool isSuccess; //변환 성공 여부를 저장할 변수

                        bool call = userNumb.Count() != userNumb.Distinct().Count();

                        do //해당 조건을 충족할 때 까지 반복
                        {
                            Console.Write($"[{i + 1}번째] 0~9 사이의 정수를 3개 입력하세요. : ");
                            string inputNumb = Console.ReadLine(); //문자열까지 잡아내기 위해 string 타입으로

                            isSuccess = int.TryParse(inputNumb, out convertedNumb); //소수점과 문자를 확인하는 식
                            //중복 값을 확인하는 식

                            if (convertedNumb < 0 || convertedNumb > 9)
                            {
                                //유효 숫자를 벗어났을 경우
                                Console.WriteLine("범위에서 벗어난 수 입니다. 다시 입력해주세요.");
                            }
                            else if (!isSuccess)
                            {
                                //정수가 아닌 실수, 문자열을 입력했을 경우
                                Console.WriteLine("소수점과 문자열을 사용할 수 없습니다. 다시 입력해주세요.");
                            }

                            userNumb[i] = convertedNumb; // 반복구문 밖에서 필요한 변수이기에 작성
                        }
                        while (userNumb[i] < 0 || userNumb[i] > 9 || !isSuccess);
                    }//for

                    if (userNumb.Count() != userNumb.Distinct().Count())
                    {
                        Console.WriteLine("숫자를 중복 입력하지 마시오");
                        Console.WriteLine();
                    }
                }//do
                while (userNumb.Count() != userNumb.Distinct().Count());

                //컴퓨터, 유저 입력 값 할당
                /*
                int[][] jagged = new int[2][];
                jagged[0] = new int[3] { comNumber[0], comNumber[1], comNumber[2] };
                jagged[1] = new int[3] { userNumb[0], userNumb[1], userNumb[2] };
                */ //실패

                //1차원 배열로 시도 // 변수생성 및 값 할당
                int[] comCount = new int[] { comNumber[0], comNumber[1], comNumber[2] };
                int[] userCount = new int[] { userNumb[0], userNumb[1], userNumb[2] };

                //컴퓨터 값, 유저 입력 값 할당
                /*
                int[,] comCount = new int[1, 3];
                comCount[0, 0] = comNumber[0];
                comCount[0, 1] = comNumber[1];
                comCount[0, 2] = comNumber[2];

                Console.WriteLine($"comCount 0, 2 : {comCount[0,2]}");

                int[,] userCount = new int[1, 3];
                userCount[0, 0] = userNumb[0];
                userCount[0, 1] = userNumb[1];
                userCount[0, 2] = userNumb[2];

                Console.WriteLine($"userCount 0, 1 : {userCount[0,1]}");
                */ //실패

                //할당 값 확인
                /*
                Console.Write("comCount 할당 값 : ");
                for (int i = 0; i < comCount.Length; i++)
                {
                    Console.Write(comCount[i] + " ");
                }
                Console.WriteLine();

                Console.Write("userCount 할당 값 : ");
                for (int i = 0; i < userCount.Length; i++)
                {
                    Console.Write(userCount[i] + " ");
                }
                Console.WriteLine();
                */

                /*
                for (int r = 0; r < comCount.GetLength(0); r++)
                {
                    for (int c = 0; c < comCount.GetLength(1); c++)
                    {
                        Console.Write(comCount[r, c] + "\t");
                    }
                    Console.WriteLine();
                }
                */ //한 줄 비교도 가능한가?


                //3. 판정 규칙
                //스트라이크 판정
                /*
                if (comCount[0, 0] == userCount[0, 0])
                {
                    strikeCount++;
                    totalStrikeCount++;
                }
                if (comCount[0, 1] == userCount[0, 1])
                {
                    strikeCount++;
                    totalStrikeCount++;
                }
                if (comCount[0, 2] == userCount[0, 2])
                {
                    strikeCount++;
                    totalStrikeCount++;
                }
                */ //실패

                if (comCount[0] == userCount[0])
                {
                    strikeCount++;
                    totalStrikeCount++;
                }
                else if (comCount[0] == userCount[1] || comCount[0] == userCount[2])
                {
                    ballCount++;
                    totalBallCount++;
                }
                else
                {
                    outCount++;
                }

                if (comCount[1] == userCount[1])
                {
                    strikeCount++;
                    totalStrikeCount++;
                }
                else if (comCount[1] == userCount[0] || comCount[1] == userCount[2])
                {
                    ballCount++;
                    totalBallCount++;
                }
                else
                {
                    outCount++;
                }

                if (comCount[2] == userCount[2])
                {
                    strikeCount++;
                    totalStrikeCount++;
                }
                else if (comCount[2] == userCount[0] || comCount[2] == userCount[1])
                {
                    ballCount++;
                    totalBallCount++;
                }
                else
                {
                    outCount++;
                }

                /*
                //판정규칙 참조 : https://codechacha.com/ko/csharp-compare-arrays-for-equality/
                bool StrikeResult = Enumerable.SequenceEqual(comCount, userCount);
                Console.WriteLine($"스트라이크 판정 확인 : {StrikeResult}");
                */ //실패

                //볼 판정

                //아웃 판정
                /*
                if (count[0, 0] != count[1, 0] || count[0, 0] != count[1, 1] || count[0, 0] != count[1, 2])
                {
                    outCount++;
                    totalOutCount++;
                }
                if (count[0, 1] != count[1, 1] || count[0, 1] != count[1, 0] || count[0, 1] != count[1, 2])
                {
                    outCount++;
                    totalOutCount++;
                }
                if (count[0, 2] != count[1, 2] || count[0, 2] != count[1, 0] || count[0, 2] != count[1, 1])
                {
                    outCount++;
                    totalOutCount++;
                }
                */ //실패

                Console.WriteLine($"{ballCount}볼 {strikeCount}스트라이크");
                Console.WriteLine();

                if (strikeCount > 2)
                {
                    endStrikeCount++;
                    Console.WriteLine("삼진 아웃! 승리!");
                }
                if (outCount > 2)
                {
                    endOutCount++;
                    Console.WriteLine($"아웃! 현재 아웃: {endOutCount}");
                }

            }//do
            while (endStrikeCount == 0 && endOutCount < 3); // while 조건문에 값이 true면 do문 반복, false일 경우 do-while문 종료

            if (endOutCount > 2)
            {
                Console.WriteLine($"{endOutCount}아웃으로 게임 종료!");
            }

            Console.WriteLine();
            Console.WriteLine("============= 총 결산 =============");
            Console.WriteLine($"토탈 라운드 횟수 : {totalRounds}");
            Console.WriteLine($"토탈 스트라이크 횟수 : {totalStrikeCount}");
            Console.WriteLine($"토탈 볼 횟수 : {totalBallCount}");
            Console.WriteLine($"토탈 아웃 횟수 : {endOutCount}");
            Console.WriteLine("===================================");

        }//main
    }
}
