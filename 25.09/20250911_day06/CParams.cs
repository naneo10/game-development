
namespace _20250911_day06
{
    /*
    메서드를 만들어서 사용해야하는 이유
    가위바위보를 메서드를 써서 분류해볼 것 / 복습
    */
    internal class CParams
    {
        static void Main ()
        {
            //로또번호를 만들어볼까요?
            //1~45가 있고
            //무작위로 섞어야함
            //그중에서 6개만 뽑으면 됨

            int[] lotto = new int[45]; //배열을 생성
            //0번 째 인덱스 부터 44번째 인덱스까지 숫자를 넣어줘야함. (1~45)

            //초기화 (입력)
            //인덱스 안에 1~45의 숫자를 입력
            for(int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = i + 1;
            }

            for (int i = 0; i < lotto.Length; i++)
            {
                Console.WriteLine(lotto[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            //이제 섞어야 함 (처리)
            Random rand = new Random();
            //Fisher-yates Shuffle 알고리즘 : 배열을 무작위로 섞을때 자주 사용
            //원리: 마지막에 들어간 배열부터 변경을 시작하고 변경이 된 항목은 랜덤 알고르즘에서 제외가 된다.

            Console.WriteLine("Random rand = new Random();");
            for(int i = lotto.Length - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1); //미만
                int temp = lotto[i];
                lotto[i] = lotto[k];
                lotto[k] = temp;
            }

            //for (int i = 0; i < lotto.Length; i++ )
            //{
            //    Console.Write(lotto[i] + "\t");
            //}

            //출력 (결과)
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(lotto[i]);
            }

            int[] arr = { 1, 2, 3 };
            Console.WriteLine("Print([1]);");
            Print([1]); //배열 자체를 넘김

            Console.WriteLine("PrintNumber(1);");
            PrintNumber(1); //컴파일러가 내부적으로 배열로 매핑을 해준다
            Console.WriteLine("PrintNumber(1, 2, 3, 4, 5)");
            PrintNumber(1, 2, 3, 4, 5); //몇 개의 인자가 올지 모르는 상황에서 사용하면 편리하다
            Console.WriteLine("PrintNumber(1, 2, 3, 4, 5, 6, 7)");
            PrintNumber(1, 2, 3, 4, 5, 6, 7);

            Console.WriteLine("GetMonsterAtk");
            GetMonsterAtk();
        }

        static void Print (int[] num)
        {
            foreach (int n in num)
            {
                Console.WriteLine($"{n}");
            }
        }

        //params
        //가변인자를 받을때 사용
        //메서드를 호출할 때 매개변수를 몇 개든 자유롭게 넘겨줄 때 사용
        //배열처럼 동작

        static void PrintNumber(params int[] num) //params는 하나 밖에 사용못한다. 그리고 이 형태는 마지막에 배치되어야 한다.
        {
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
        }

        static int[] GetMonsterAtk ()
        {
            int[] atk = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}번째 몬스터의 공격력 입력 : ");
                atk[i] = int.Parse(Console.ReadLine());
            }
            return atk;
        }
    }
}
