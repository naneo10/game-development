
namespace _20250905_day2
{
  /*
   연산자(Operator)
   -프로그래밍 언어에서는 일반적인 수학연산과 유사한 연산자들이 지원됨
   -C#은 여러 연산자를 제공함

   [산술연산자]
   -덧셈, 뺄셈, 곱셈, 나눈셈... 나머지 
  */
    internal class Operator
    {
        static void Main()
        {
            Console.WriteLine("===산술 연산자===");
            Console.WriteLine(1 + 1);  //2
            Console.WriteLine(3 - 1);  //2
            Console.WriteLine(10 * 3); //30
            Console.WriteLine(3 / 2);  //1  몫을 구하고 소수점 나머지는 절삭
            Console.WriteLine(7 % 3); //1  못을 버리고 나머지를 구한다

            int num1 = 15;
            int num2 = 12;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);

            //출력: Console.WriteLine
            //입력: Console.ReadLine

            //우리가 입력을 받아야 됨
            Console.WriteLine("입력하세요");

            string input = Console.ReadLine();
            Console.WriteLine($"입력한 데이터 : {input}");
            Console.WriteLine(input.GetType()); //변수의 데이터 타입 확인

            Console.WriteLine();

            int inputNum = int.Parse(Console.ReadLine()); //문자열만 받아줌 데이터 형변환 필요 'int.Parse()'
            Console.WriteLine(inputNum);

            //내가 두 수의 입력을 받아서 더하기를 하고 싶다?

            //첫 번째 입력
            Console.WriteLine("첫 번째 수 입력");
            int inputNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 수 입력");
            int inputNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"합한 수 : {inputNum1 + inputNum2}");

            //입력받은 두 수의 합을 sumResult라는 변수에 저장
            //int sumResult = inputNum1 + inputNum2;
            //sumResult에 저장된 결과 출력
            //Console.WriteLine(sumResult);

            //변수 3개를 합쳐서 출력 확인
            Console.WriteLine("첫 번째 문장");
            string inputString1 = Console.ReadLine();
            Console.WriteLine("두 번째 문장");
            string inputString2 = Console.ReadLine();
            Console.WriteLine("세 번째 문장");
            string inputString3 = Console.ReadLine();
            Console.WriteLine($"변수 3개 : {inputString1 + inputString2 + inputString3}");

            //변수를 받고 문장을 합쳤을 때 자동으로 띄어쓰기가 되는지 확인
            Console.WriteLine("첫 번째 문장");
            String inputString4 = Console.ReadLine();
            Console.WriteLine("두 번째 문장");
            String inputString5 = Console.ReadLine();
            Console.WriteLine("세 번째 문장");
            String inputString6 = Console.ReadLine();
            Console.WriteLine("네 번째 문장");
            String inputString7 = Console.ReadLine();
            Console.WriteLine($"변수 4개 띄어쓰기 : {inputString4 + " " + inputString5 + 
                " " + inputString6 + " " + inputString7}");

            //과제
            //1.데이터타입 종류 정리
            //2.연산자 종류 확인, 두 수의 입력을받아 연산해보기


            int currentYear = 2025
            Console.WriteLine("태어난 년도 기입");
            int birthYear = int.Parse(Console.ReadLine());
            int age;

            age = currentYear - birthYear;
            Console.WriteLine($"당신의 나이는 : {age}");


        }

    }
}
