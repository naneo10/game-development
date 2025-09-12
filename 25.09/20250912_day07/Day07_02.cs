
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace _20250912_day07
{
    /*
    string의 다양한 메서드들...
    IndexOf: 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾는다.
            ㄴ찾는 문자열/문자가 있으면 첫 번째 위치를 반환. 없으면 실패의 의미인 '-1'을 리턴
    LastIndexOf: 위와 동일하지만 뒤에서 부터 찾는다.
    StartsWith: 현재 문자열이 지정된 문자로 시작하는가
    EndWith: 현재 문자열이 지정된 문자열로 끝나는가

    Contains: 현재 문자열이 지정된 문자열을 포함하고 있는가
    Replace: 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새로운 문자열을 반환
    SubString: 특정 위치부터 일정 길이만큼 잘라낸 새 문자열 반환
    Trim: 문자열의 앞뒤 공백 제거
    Split: 특정 구분자로 문자열을 잘라준다 이후 배열로 변환

    고전적 문제
    문자열 뒤집기
    */
    internal class Day07_02
    {
        static void Main()
        {

            string str = "Hello World Game";
            Console.WriteLine($"Game이 시작되는 위치는 : {str.IndexOf("Game")}"); //12
            Console.WriteLine($"d가 시작되는 위치는 : {str.IndexOf('d')}"); //10
            
            Console.WriteLine($"Hello로 시작하는가? : {str.StartsWith("Hello")}");
            Console.WriteLine($"Hello로 시작하는가? : {str.StartsWith("Game")}");

            Console.WriteLine($"World를 test로 변경 {str.Replace("World","test")}");

            string original = "Hello, World";
            string sub = original.Substring(7, 5); //7번째 인덱스 부터 5문자열 출력
            Console.WriteLine(sub);

            string space = "        Hello,          World         ";
            string trim = space.Trim();
            Console.WriteLine(trim); //중간은 제외하고 시작과 끝 공백 날림

            string s = "공백으로 문장을 잘게 잘 게 잘라볼 까";
            string[] words = s.Split(' ');

            foreach( var word in words )
            {
                Console.WriteLine(word); // [공백으로], [문장을], [잘게], [잘], [잘라볼], [까]
            }

            string text = Console.ReadLine();

            string reverse = ReverseString(text);
            Console.WriteLine(reverse);

            //스트링빌더
            //새로운 문자열을 만들지 않고 기본 데이터를 수정
            //만약에 문자열 관련 조작이 많을 경우 스트링빌더를 활용하면 성능상 이점이 있다.

            const int ITER = 100000;

            //string
            Stopwatch stringSW = Stopwatch.StartNew();
            string result = "";

            for (int i = 0; i < ITER; i++)
            {
                result += "a";
            }
            stringSW.Stop();

            Console.WriteLine($"스트링 : {stringSW.ElapsedMilliseconds}밀리초");

            Stopwatch stringBuilderSw = Stopwatch.StartNew();

            //StringBuilder resultStringBuilder = new StringBuilder();


        }
        //문자열 뒤집기
        //Hello -> olleH

        static string ReverseString(string input)
        {
            string result = "";

            for (int i = input.Length - 1; i <= 0; i--)
            {
                result += input[i];
            }
            Console.WriteLine(result);
            return result;
        }

        static string ReverseString1(string input)
        {
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);

            return new string(charArr);
        }
    }
}
