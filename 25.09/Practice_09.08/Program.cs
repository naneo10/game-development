namespace Practice_09._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //내 나이는 몇 살일까?
            int currentYear = 2025;
            Console.WriteLine("태어난 년도 기입");
            int birthYear = int.Parse(Console.ReadLine());
            int age;

            age = currentYear - birthYear;
            Console.WriteLine($"당신의 나이는 : {age}");


            //연산자 활용
            int a = 10;

            a += 5;
            Console.WriteLine(a);

            a -= 6;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a); //int라서 소수점 절삭

            a %= 7;
            Console.WriteLine(a); //6
        }
    }
}
