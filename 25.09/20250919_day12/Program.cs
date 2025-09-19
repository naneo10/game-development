namespace _20250919_day12
{
    /*
    과제풀이
    */
    internal class Program
    {
        //1.평균
        //static double Solution(List<int> numbers)
        //{
        //    double sum = 0;

        //    foreach (var num in numbers)
        //    {
        //        sum += num;
        //    }

        //    float answer = (float)sum / numbers.Count;

        //    return answer;
        //}

        ////2.두배
        //static List<int> Solution(List<int> numbers)
        //{
        //    List<int> answer = new List<int>(numbers.Count); //매개변수에서 크기를 정해놓고 시작 메모리에서 여유

        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        answer.Add(numbers[i] * 2);
        //    }
        //    return answer;
        //}

        //3.중복
        static int Solution (List<int>arr, int n)
        {
            int count = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == n)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 1, 2, 3, 5 };
            int n = 1;
            int result = Solution(arr, n);
            Console.WriteLine(result);
        }
    }
}
