
namespace _20250911_day06
{
    /*
    [다차원 배열]
    -배열의 []안에 차원수 만큼 ','를 추가
    
    [가변배열(Jagged Array)]
    -배열의 []괄호를 배열 갯수만큼 추가
    -배열의 크기를 각각 설정 가능
    -2차원 배열의 한 형태이긴 하지만 길이가 다르다
    -주로 데이터 길이가 일정하지 않은 경우
    */
    internal class CJaggedArray
    {
        static void Main()
        {
            //int[] scores = new int[] { 1, 2 }; //1차원 배열

            int[,] map = new int[2, 3]; //2행 3열
            map[0, 0] = 1;
            map[0, 1] = 2;
            map[0, 2] = 3;
            map[1, 0] = 4;
            map[1, 1] = 5;
            map[1, 2] = 6;

            //GetLength(0): 2차원 배열에서 행의 길이
            //GetLength(1): 2차원 배열에서 열의 길이
            for(int r = 0; r < map.GetLength(0); r++)
            {
                for(int c = 0; c < map.GetLength(1); c++)
                {
                    Console.Write(map[r, c]+ "\t");
                }
                Console.WriteLine();
            }

            //jaggedArray
            //:행이 별로도 저장되기에 캐시효율이 떨어진다.
            //:대규모 계산에선 상대적으로 속도가 떨어질 수 있다.
            //:초기화가 번거롭다.
            int[][] jagged = new int[3][]; //새로운 배열객체를 3개를 만들고 []갯수 만큼 할당을 하겠다
            jagged[0] = new int[5];
            jagged[1] = new int[2];
            jagged[2] = new int[3];

            //new: 동적으로 할당할 때 사용
            //[0][0] [0][1] [0][2] [0][3] [0][4] --> new int[5];
            //[1][0] [1][1]                      --> new int[2];
            //[2][0] [2][1] [2][2]               --> new int[3];

            jagged[0] = [1, 2, 3, 4, 5]; //[3]'[]'이기에 원하는 만큼 숫자를 추가할 수 있다.
            jagged[1] = [6, 7]; //갯수만큼 원하는 메모리가 할당된다.
            jagged[2] = [8, 9, 10];
            Console.WriteLine(jagged[1][1]); //7 jagged[1] 의 [6, 7]의 1에 항목이 출력
        }
    }
}
