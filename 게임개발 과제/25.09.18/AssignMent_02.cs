
namespace _25._09._18
{
    /*
    [배열 두 배 만들기]

    문제 설명
    -정수 배열 numbers가 매개변수로 주어지고 numbers의 각 원소에 두 배 한 원소를 가진 배열을
        return 하도록 solution 함수를 완성할 것

    제한 사항
    -0 <= numbers의 원소 <= 10,000
    -1 <= numbers의 길이 <= 1,000

    입출력의 예
    numbers                 result
    [1,2,3,4,5]             [2,4,6,8,10]
    [1,2,100,-99,1,2,3]     [2,4,200,-198,2,4,6]

    입출력 예 설명
    입출력 예 #1
    -[1,2,3,4,5]의 각 원소에 두 배를 한 배열 [2,4,6,8,10]을 return함.
    입출력 예 #2
    -[1,2,100,-99,1,2,3]의 각 원소에 두 배를 한 배열 [2,4,200,-198,2,4,6]을 return함
    */
    internal class AssignMent_02
    {
        static void Main ()
        {
            List<int> numb = new List<int>();

            int count = 0;
            bool end = false;

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"[{count+1}번째] 배열에 담을 값을 입력하세요. ");

                while (true)
                {
                    string inputNumb = Console.ReadLine();
                    bool confirmNumb = int.TryParse(inputNumb, out int value);

                    if (!confirmNumb)
                    {
                        Console.WriteLine("숫자만 입력 가능합니다.");
                        continue;
                    }

                    if (value > 10000 || value < -10000)
                    {
                        Console.WriteLine("입력 가능한 값 범위를 벗어났습니다.");
                        continue;
                    }

                    bool isDuplicate = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (numb[j] == value)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (isDuplicate)
                    {
                        Console.WriteLine("중복된 숫자를 입력할 수 없습니다.");
                        continue;
                    }
                    else if (!isDuplicate)
                    {
                        count++;
                        numb.Add(value);
                        break;
                    }
                }//while

                if (i > 6)
                {
                    Console.WriteLine("배열을 더 추가하시겠습니까? (Y/N)");
                    while (true)
                    {
                        string inputString = Console.ReadLine();
                        bool stringConfirm = int.TryParse(inputString, out int numGC);

                        if (stringConfirm)
                        {
                            Console.WriteLine("숫자는 입력 값에 포함되어있지 않습니다.");
                            continue;
                        }
                        if (inputString == "Y" || inputString == "y")
                        {
                            break;
                        }
                        else if (inputString == "N" || inputString == "n")
                        {
                            Console.WriteLine("배열 추가입력을 종료합니다.");
                            end = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("다른 문자열은 입력할 수 없습니다.");
                            continue;
                        }
                    }
                }

                if (end)
                {
                    break;
                }
            }//for
            Console.WriteLine();
            Solution(numb);
        }

        static List<int> Solution(List<int> numbers)
        {
            //numbsers
            Console.WriteLine("numbers : ");
            Console.Write("[");
            string result = string.Join(", ", numbers);
            Console.Write(result);
            Console.WriteLine("]");

            //result
            Console.WriteLine("result : ");
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= 2;
            }
            Console.Write("[ ");
            string sc = string.Join(", ", numbers);
            Console.Write(sc);
            Console.WriteLine(" ]");

            return numbers;
        }
    }
}
