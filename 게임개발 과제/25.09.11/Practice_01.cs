
namespace _25._09._11
{
    /*
    var 변수 : https://whyprogrammer.tistory.com/241
    C# LINQ란? : https://hijuworld.tistory.com/56
    배열 중복 값 제거 : https://developer-talk.tistory.com/215#google_vignette
    */
    internal class Practice_01
    {
        static void Main ()
        {
            //배열 생성 및 초기화
            int[] testSource = new int[5];

            //배열에 수 할당
            for (int i = 0; i < testSource.Length; i++)
            {
                testSource[i] = i + 1;
            }

            for (int i = 0; i < testSource.Length; i++)
            {
                Console.WriteLine(testSource[i]);
            }

            //GroupBy 참조 : https://kwonyeeun.tistory.com/138
            int[] items = new int[5] { 1, 2, 3, 4, 5 };

            var countByitem = items.GroupBy(i => i)
                                   .Select(g => new { Item = g.Key, Count = g.Count() });

            foreach ( var entry in countByitem )
            {
                Console.WriteLine($"아이템 종류 : {entry.Item} = 중복카운터 : {entry.Count}");
            }

            Console.WriteLine();

            //LINQ 참조
            int[] nums = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numQuery = from num in nums
                           where (num % 3) == 0
                           select num;
            foreach(int num in numQuery)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            //count() 활용 //중복된 수 숫자 찾는거 아니라 폐기
            /*
            int[] numbers = new int[15] { 1, 2, 2, 3, 3, 3, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
            int numCount = numbers.Count(n => n%2 == 0); //중복된 숫자 찾는거라더만 낚아버리네
            Console.WriteLine($"count 활용 (중복된 수 숫자) : {numCount}");
            */

            //count 값을 입력 받았을 때 테스트
            int[] testNumb = new int[5];
            /*필요 없어짐
            int numGroup;
            */

            //값을 입력 받아서 배열에 할당
            for (int i = 0; i < testNumb.Length; i++)
            {
                /*
                bool classification;

                do //잘못 된 것 같다 일단 폐기
                {
                    Console.WriteLine("5번 수를 입력하시오.");
                    string inputNumb = Console.ReadLine();

                    //잘못 된 수입력 시 반복시키기 위해 작성한 구문
                    //어떻게 testNumb[] 배열안에 할당시키지?
                    classification = int.TryParse(inputNumb, out numGroup);

                    if (!classification)
                    {
                        Console.WriteLine("다시 입력하시오");
                    }
                }
                while (!classification);
                */

                Console.WriteLine("testNumb 배열에 할당시킬 값을 5번 입력하시오");
                testNumb[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"현재 입력된 값 : {testNumb[i]}");
            }

            //제대로 할당 됬는지 확인
            Console.Write("현재 포함된 값 : ");
            for (int i = 0; i < testNumb.Length; i++)
            {
                Console.Write(testNumb[i] + $", ");
            }

            Console.WriteLine();

            //중복된 요소 확인
            Console.WriteLine("===== 중복된 요소 확인 =====");
            var testCount = testNumb
                                    .GroupBy(i => i)
                                    .Where(g => g.Count() > 1)
                                    .Select(g => g.Key);
            foreach (int item in testCount)
            {
                Console.Write($"현재 중복된 데이터는 {item} 입니다.");
            }

            //잘못 된 식을 대입했기에 결과 값도 X
            /*
            //이제 중복된 숫자 카운트
            int testNumbCount = testNumb.Count(a => a % a == 0); //Count 매개변수 안 a는 b, c로 바꿔도 무관
            Console.WriteLine($"중복된 수 숫자 : {testNumbCount}"); //드디어 성공

            Console.WriteLine();
            */

            /* 위의 식 폐기와 동시에 불필요
            for (int i = 0; i < testNumb.Length; i++)
            {
                Console.WriteLine($"testNumb에 저장된 배열 : {testNumb[i]}");
            }
            */

        }
    }
}
