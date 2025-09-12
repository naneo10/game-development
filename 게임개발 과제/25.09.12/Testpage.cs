
namespace _25._09._12
{
    internal class Testpage
    {
        static void Main ()
        {
            //0~15의 배열 초기화
            int[,] num = new int[3, 5];

            //배열 값 할당
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    //num[i, j] = i + 1;
                    //num[i, j] = j + 1;
                    //num[i, j] = [i, j]; 불가능
                }
            }

            //GetLength(0) : 2차원 배열에서 행의 길이를 리턴
            //GetLength(1) : 2차원 배열에서 열의 길이를 리턴

            //제대로 할당 됬는지 확인
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write($"{i}행 {j}열 : {num[i,j]}  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("랜덤 값 할당 확인");
            //2차원 배열 행, 열에 랜덤값 할당하기
            Random testRand = new Random();

            for (int i = num.GetLength(0) -1; i > 0; i--)
            {
                for (int j = num.GetLength(1) -1; j > 0; j--)
                {
                    //행 섞기
                    //int k = testRand.Next(i, j);
                    //int temp = num[i, j];
                    //num[i, j] = num[j, k];
                    //num[j, k] = temp;

                    //열 섞기
                }
            }
            
            //원하는 2차원 배열에 행 가져오기

        }
    }
}
