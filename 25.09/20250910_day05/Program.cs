namespace _20250910_day05
{
    internal class Program
    {
        //풀이
        static void Main(string[] args)
        {
            //별 찍기

            Console.WriteLine("별찍기 선택");
            Console.WriteLine("1. 왼쪽 직각 삼각형");
            Console.WriteLine("2. 왼쪽 역직각 삼각형");
            Console.WriteLine("3. 오른쪽 직각 삼각형");
            Console.WriteLine("4. 오른쪽 역직각 삼각형");

            while ( true )
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            for (int i = 1; i <= 5; i++)
                            {
                                for (int k = 1; k <= i; k++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 2:
                        //위에서 부터 별 5개로 시작해서, 한 줄 내려갈때 마다 1개씩 줄어듬
                        {
                            for (int i = 5; i >= 1; i--)
                            {
                                for (int k = 1; k <= i; k++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 3:
                        //오른쪽
                        //규칙: 왼쪽 공백 = 5-i, 별 i개


                        for (int i = 1; i <= 5; i++)
                        {
                            //공백
                            for(int k = 1; k <=5 - i; k++)
                            {
                                Console.Write(" ");
                            }
                            for(int k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        //오른쪽 역직각
                        for(int i = 1; i >= 1; i--)
                        {
                            for(int k = 1; k <=5 - i; k++)
                            {
                                Console.Write(" ");
                            }
                            for(int k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            }
        }
    }
}
