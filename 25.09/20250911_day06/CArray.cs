
namespace _20250911_day06
{
    /*
    [배열(Array)]
    -동일한 자료형의 요소들로 구성된 데이터 집합
    -인덱스를 통해서 배열요소(Element)에 접근할 수 있다
    -배열의 처음 요소의 인덱스는 0부터 시작
    -배열의 크기는 한 번 설정하면 변경할 수 없지만 List<T>같은 컬렉션을 사용하면 동적으로 크기 조절이 가능하다

    [index]
    -배열의 요소들을 메모리에 연속적으로 배치하는 원리로 구현
    -이를 이용해서 배열의 특정요소의 메모리 주소를 계산할 수 있음

    [배열기본]
    -배열을 만들기 위해 자료형과 크기를 정하여 생성
    -배열의 요소에 접근하기 위해 [인덱스]를 사용
    -배열의 Lengh를 통해 크기를 확인
    
    ^자료형[] 배열의 이름 = new 자료형[크기];
    */
    internal class CArray
    {
        static void Main()
        {
            //이젠 이런 변수 선언은 없는 걸로
            //int score;
            //int score1;
            //int score2;
            //int score3;
            //int score4;

            int[] scores = new int[5]; //크기가 5인 배열을 선언

            //인덱스는 크기의 -1
            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;

            Console.WriteLine($"scores 배열의 0번째 요소: {scores[0]} ");
            Console.WriteLine($"scores 배열의 1번째 요소: {scores[1]} ");
            Console.WriteLine($"scores 배열의 2번째 요소: {scores[2]} ");
            Console.WriteLine($"scores 배열의 3번째 요소: {scores[3]} ");
            Console.WriteLine($"scores 배열의 4번째 요소: {scores[4]} ");
            //Console.WriteLine($"scores 배열의 4번째 요소: {scores[5]} "); 인덱스 벗어남

            Console.WriteLine(scores.Length);

            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            //선언 및 초기화
            int[] arr1;
            arr1 = new int[5];

            int[] arr2 = new int[3] { 1, 2, 3 }; //크기가 3인 배열을 선언하고 배열요소를 초기화
            int[] arr3 = new int[] { 1, 2, 3 }; //배열의 요소들을 초기화 하는 경우 배열의 크기를 생략 가능
            int[] arr4 = { 1, 2, 3 }; //배열의 요소들을 초기화 하는 경우 배열생성을 생략할 수 있다

            Console.WriteLine("scores[i] += 2;");
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] += 2;
                Console.WriteLine(scores[(int)i]); // 12,22,32,42,52
            }

            //foreach
            Console.WriteLine("foreach");
            foreach (int s in scores) // in: scores에서 순차적으로 꺼내면서 임시변수 s에 저장
            {
                //scores[s] += 2;
                Console.WriteLine(s);
            }

            int[] array = { 1, 5, 9, 3, 7 };

            int len = array.Length;

            int max = array.Max();

            Console.WriteLine("array.Max()");
            Console.WriteLine(max);

            Array.Sort(array);
            Array.Reverse(array);
        }
    }
}
