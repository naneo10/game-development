
using System.Reflection.Metadata.Ecma335;

namespace _25._09._18
{
    /*
    [중복된 숫자 개수]
    문제 설명
    -정수가 담긴 배열 array와 정수 n이 매개변수로 주어질 때, array에 n이 몇 개 있는지를
        return 하도록 solution 함수를 완성할 것

    제한 사항
    -0 <= array.Length <= 100
    -0 <= array의 원소 <= 1,000
    -0 <= n <= 1,000

    입출력 예
    array               n          result
    [1,1,2,3,4,5]       1           2
    [0,2,3,4]           1           0
    */
    internal class AssignMent_03
    {
        static void Main ()
        {
            List<int> array = new List<int>();
            bool end = false;
            int n = 0;
            int count = 0;
            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"[{count+1}번 째] 정수를 입력하시오. (0 <= 입력 값 <= 1,000)");

                string inputNumF = Console.ReadLine();
                bool numConfirmF = int.TryParse(inputNumF, out int value);

                if (!numConfirmF)
                {
                    Console.WriteLine("숫자를 입력하시오");
                    continue;
                }

                if (value < 0 || value > 1000)
                {
                    Console.WriteLine("지정된 범위에서 벗어난 수");
                }
                else
                {
                    array.Add(value);
                    count++;
                }

                if (count > 6)
                {
                    Console.WriteLine("배열을 계속 추가하시겠습니까? Y/N");
                    while (true)
                    {
                        string input = Console.ReadLine();
                        bool inputNumb = int.TryParse(input, out int numGC);

                        if (inputNumb)
                        {
                            Console.WriteLine("입력 값 범위에서 벗어났습니다.");
                            continue;
                        }
                        if (input == "Y" || input == "y")
                        {
                            break;
                        }
                        else if ( input == "N" || input == "n")
                        {
                            end = true;
                            break;
                        }
                    }
                }//if
                if (end)
                {
                    break;
                }
            }//for

            while (true)
            {
                Console.WriteLine("선택한 숫자가 배열에 몇 개 있는지 확인해드립니다. 0 <= n <= 1000");

                string inputNumS = Console.ReadLine();
                bool numConfirmS = int.TryParse(inputNumS, out int valueS);

                if (!numConfirmS)
                {
                    Console.WriteLine("숫자를 입력하시오");
                    continue;
                }

                if (valueS >= 0 || valueS <= 1000)
                {
                    n = valueS;
                    break;
                }
                else
                {
                    Console.WriteLine("범위에서 벗어난 수");
                    continue;
                }
            }//while

            Console.WriteLine();
            Solution(array, n);
        }//main

        static int Solution(List<int> arr, int n)
        {
            Console.Write("array :");
            Console.Write("[ ");
            string sumA = string.Join(", ", arr);
            Console.Write(sumA);
            Console.WriteLine(" ]");

            Console.WriteLine();

            Console.Write("n :");
            Console.WriteLine(n);

            Console.WriteLine();

            var confirm = from num in arr
                          where (num == n)
                          select num;
            Console.Write("result :");
            Console.WriteLine(confirm.Count());

            return arr.Count;
        }
    }
}
