
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace _25._09._18
{
    /*
    [배열의 평균값 구하기]

    문구 설명
    -정수 배열 numbers가 매개변수로 주어지고 numbers의 원소의 평균값을 return하도록 solution 함수를 완성할 것

    제한사항
    -0 <= numbers의 원소 <= 1,000
    -1 <= numbers의 길이 <= 100
    -정답의 소수 부분이 .0 또는 .5인 경우만 입력으로 주어짐

    입출력의 예
    numbers                                 result
    [1,2,3,4,5,6,7,8,9,10]                  5.5
    [89,90,91,92,93,94,95,96,97,98,99]      94.0

    입출력의 예 설명
    입출력 예 #1
    -numbers의 원소들의 평균 값은 5.5
    입출력 예 #2
    -numbers의 원소들의 평균 값은 94.0

    코드작성
    static double Soultion(Linst<int> numbers)
    {

    }
    */
    /*
    break, continue : https://blog.naver.com/kijun/221977303159
    */
    internal class AssignMent_01
    {
        static void Main()
        {
            List<int> items = new List<int>();
            //진행 횟수 표기
            int count = 0;
            //배열 입력 종료
            bool End = false;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"[{count + 1}번째] 0 ~ 1,000 사이의 수를 입력하세요");

                while (true)
                {
                    //숫자, 문자 확인
                    int value;
                    string inputNum = Console.ReadLine();
                    bool confirm = int.TryParse(inputNum, out value);
                    if (!confirm)
                    {
                        Console.WriteLine("[숫자를 입력하세요]");
                        continue;
                    }

                    //숫자 범위 제한
                    if (value > 1000 || value < 0)
                    {
                        Console.WriteLine("[범위에서 벗어난 수입니다.]");
                        continue;
                    }

                    //중복 숫자 확인
                    bool isDuplicate = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (items[j] == value)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (isDuplicate)
                    {
                        Console.WriteLine("[반복된 숫자 입력]");
                        continue;
                    }
                    else if (!isDuplicate)
                    {
                        count++;
                        items.Add(value);
                        break;
                    }
                }// while
                #region 잘 담기고 있나?
                /*
                Console.WriteLine();
                Console.WriteLine("=============================================");
                Console.WriteLine("현재 items에 담긴 배열 : ");
                foreach (var item in items)
                {
                    Console.Write($"{item} -> ");
                }
                Console.WriteLine("null");
                Console.WriteLine($"현재 배열 갯수 : {items.Count}, 현재 용량 : {items.Capacity}");
                Console.WriteLine("=============================================");
                Console.WriteLine();
                */
                #endregion
                Console.WriteLine();
                if (i > 6)
                {
                    Console.WriteLine("배열을 더 추가 하시겠습니까? (Y / N)");

                    //조건식 및 입력 값 출력
                    while (true)
                    {
                        string inputConfirm = Console.ReadLine();
                        bool inputNumb = int.TryParse(inputConfirm, out int numbGC);

                        if (inputConfirm == "Y" || inputConfirm == "y")
                        {
                            Console.WriteLine("배열 추가를 계속 진행합니다.");
                            break;
                        }
                        else if (inputConfirm == "N" ||  inputConfirm == "n")
                        {
                            Console.WriteLine("배열 추가를 종료합니다.");
                            End = true;
                            break;
                        }
                        else if (inputNumb)
                        {
                            Console.WriteLine("숫자는 입력 값으로 받지 않습니다.");
                        }
                        else if (!inputNumb)
                        {
                            Console.WriteLine("문자열은 입력 값으로 받지 않습니다.");
                        }
                    }
                }

                //종료 선택 시 구문실행
                if (End)
                {
                    break;
                }

            } //for
            Console.WriteLine();
            //값이 잘 담기고 메서드도 잘 작동함 확인 완
            Soulution(items);

        }

        static double Soulution(List<int> numbers)
        {
            Console.WriteLine("numbers");
            string arr = string.Join(", ", numbers);
            Console.WriteLine(arr);

            //C# LINQ 합계 구하기 - Sum 메서드 : https://developer-talk.tistory.com/592
            #region LINQ의 메서드 활용해서 해결
            /*
            //List<int>: 조건식에 오류는 없어지지만 forecah문 오류 발생
            //타입 var: 'int'에는 'Sum'에 대한 정의가 포함되어 있지 않고 ....
            foreach (var item in list)
            {
                //list 배열을 foreach문으로 순차적으로 옮기면서 더해야 하는 것으로 생각했으나 -
                //무의미한 구문이었음.
            }
            */
            #endregion
            double total = numbers.Sum();

            Console.WriteLine("result");
            double result = total / numbers.Count;
            //특정 소수점 이하 올림, 버림 처리하기 : https://holjjack.tistory.com/228
            double changeResult = Math.Round(result, 1);

            Console.WriteLine(changeResult);

            //부동 소수점 == 비교 x : https://pang2h.tistory.com/184
            //나머지로 남은 소수점만 비교
            if (changeResult % 1 == .5 || changeResult % 1 == .0)
            {
                Console.WriteLine($"numbers의 원소들의 평균 값은 {changeResult}");
            }
            else
            {
                Console.WriteLine("조건 미충족");
            }
            return total;
        }
    }
}
