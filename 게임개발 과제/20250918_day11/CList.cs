
namespace _20250918_day11
{
    /*
    [LikedList]
    -요소들이 연결리스트 구조로 저장되는 자료구조
    -더블형태 양방향으로 이루어져 있다(싱글은 방향이 단방향)
    -노드들간의 연결이 이루어지기 때문에 중간 삽입 삭제가 빠르다. (prev값 - 데이터 - next값)으로 되어있어 prev값과 next값을 찾아서 삽입

    [List]
    -동적배열 기반
    -배열과 유사하지만 크기가 자동으로 조정
    -내부적으로 배열을 사용하지만 크기가 부족하면 새로운 배열을 생성하고 복사 (약 2배 새로운 배열 생성, 2의 제곱으로 상승)
    -인덱스로 접근을 지원(빠르다)

    -Add(): 리스트의 맨 끝에 요소 추가
    -Insert(): 특정 위치에 삽입
    -Remove(): 특정 요소를 제거
    -Contains(): 특정요소가 있는지 확인
    -IndexOf(): 특정요소가 있는 인덱스
    -Clear(): 모든 요소 제거
    -Sort(): 요소 정렬
    */
    internal class CList
    {
        static void Main ()
        {
            List<int> items = new List<int>();
            items.Add(1);
            items.Add(2);
            items.Add(3);
            items.Add(4);
            items.Add(5);

            Console.WriteLine("추가 후");
            PrintList(items);

            items.Insert(1, 10);
            Console.WriteLine("특정 위치 삽입 후");
            PrintList(items);

            Console.WriteLine("삭제 후");
            items.Remove(4);
            PrintList(items);

            int idx = items.IndexOf(5); //없는 값 입력 시 '-1'로 리턴
            Console.WriteLine(idx);

            Console.WriteLine("Contains 확인");
            Console.WriteLine(items.Contains(0)); //리스트 배열안에 해당 'int', 'string' 값이 있는지 확인 후 결과에 따라 'true', 'false'로 반환
        }

        static void PrintList(List<int> list)
        {
            //var: 지역변수에서만 허용, 컴파일러가 대입되는 값을 보고 자동으로 추론
            foreach (var item in list)
            {
                Console.Write($"{item} ->");
            }
            Console.WriteLine("null");
            Console.WriteLine($"요소의 갯수: {list.Count}, 용량: {list.Capacity}");
        }
    }
}
