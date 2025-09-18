
namespace _20250918_day11
{
    /*
    [Stack]
    -LIFO(Last In First Out) 구조를 따르는 자료구조. 마지막에 들어온 데이터가 가장 먼저 나가는 구조
    -역순처리, DFS(깊이 우선 탐색), 되돌리기 기능등 ...
    -내부적으로 동적배열을 사용하여 구현되어 있음
    -요소를 추가하면 내부배열이 부족할 경우 더 큰 배열을 할당하고 기존데이터를 복사

    [주요 메서드]
    -Push(T item): 스택의 맨 위에 요소를 추가
    -Pop(): 스택의 맨 위 요소 제거 및 반환
    -Peek(): 스택의 맨 위 요소를 반환
    -Count: 현재 스택의 요소 개수 반환
    -Contains(T item): 특정요소가 있는지 확인
    -Clear(): 비우는 것

    [Queue]
    -FIFO(First in First Out)구조, 먼저 들어온 데이터가 먼저 나간다
    -동적배열기반 원형 큐 구조를 사용(서클라 큐)
    -작업 대기열, 이벤트 처리, 순차적 데이터 처리 등에 활용
    -퀘스트 로그, 메시지 큐 등등...

    [주요 메서드]
    -Enqueue(T item): 큐의 끝에 요소가 추가된다
    -Dequeue(): 큐의 앞에서 요소 제거 및 반환
    -Peek
    -Count
    -Clear
    */
    internal class CStack
    {
        static void Main ()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("첫 번째");
            stack.Push("두 번쨰");
            stack.Push("세 번째");

            Console.WriteLine($"현재 스택의 개수: {stack.Count}");

            //맨 위에있는 요소 확인
            Console.WriteLine($"맨 위 요소 : {stack.Peek()}");

            Console.WriteLine($"pop 실행: {stack.Pop()}");
            Console.WriteLine($"pop 실행: {stack.Pop()}");

            Console.WriteLine($"현재 스택의 개수: {stack.Count}");
            Console.WriteLine($"맨 위 요소 : {stack.Peek()}");

            Stack<int> stack1 = new Stack<int>();

            for(int i = 1; i <= 10; i++)
            {
                stack1.Push(i);
                Console.WriteLine($"puch({i}) -> count: {stack1.Count}");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("플레이어 1");
            queue.Enqueue("플레이어 2");
            queue.Enqueue("플레이어 3");

            //첫 번째 요소 출력
            Console.WriteLine($"{queue.Peek()}");

            while(queue.Count > 0)
            {
                Console.WriteLine($"{queue.Dequeue()}가 행동을 수행한다");
            }
            Console.WriteLine($"{queue.Count}");
        }
    }
}
