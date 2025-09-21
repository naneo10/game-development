
namespace _20250919_day12
{
    /*
    [HashTable]
    -키와 값 쌍을 저장하는 자료구조
    -key는 유일한 ID 같은 느낌. 값은 사물함을 열고 그 안에 넣는 물건
    -값은 중복이 될 수 있다
    -키를 해시 함수에 의해 계산된 해시코드를 변환하여 데이터를 저장하고 검색하기 때문에 빠른 검색 속도를 제공
    -단, HashTable은 기본적으로 objecct Type을 키와 값에 모두 사용하기 때문에 타입 안정성이 떨어짐
    -제네릭 헤시테이블인 Dictionary가 많이 사용됨

    [해시 함수]
    -key를 해시코드로 변환하여 인덱스를 계산. 빠른 데이터 접근을 가능하게 해줌
    -key를 사물함 번호로 바꿔주는 계산법

    [충돌해결방안]
    -체이닝 개방주소법 ★★★

    [해시테이블 vs 딕셔너리] ★★★

    [Dictionary]
    -key - value 쌍을 저장
    -빠른검색, 추가, 삭제가 가능하며, 키는 중복될 수 없고, 각 키는 하나의 값과 연결

    -Add(Tkey, Tvalue): 키-값 추가
    -ContainsKey(Tkey): 키 존재 여부 확인
    -ContainsValue(Tvalue): 값 존재 여부 확인
    -TryGetValue(Tkey, out Tvalue vale): 안전한 값 조회
    -Remove(Tkey): 키 삭제
    -Clear(): 모든 요소 삭제
    -Count(): 요소 갯수 확인
    */
    internal class CHashTalbe
    {
        class Item
        {
            //프로퍼티
            public string name { get; set; }
            public int power { get; set; }

            //생성자
            public Item(string name, int power)
            {
                this.name = name;
                this.power = power;
            }

            //
            public override string ToString()
            {
                return $"{name} (파워: {power})";
            }
        }

        static void Main ()
        {
            Dictionary<int, string> players = new Dictionary<int, string>();

            players.Add(1, "전사");
            players.Add(2, "법사");
            players.Add(3, "도적");

            Console.WriteLine($"키 1: {players[1]}"); //내부적으로 인덱서가 구현이 되어있어 이렇게 접근이 가능하다

            if (players.ContainsKey(2))
            {
                Console.WriteLine("키 2가 존재한다");
            }

            players[3] = "궁수";

            players.Remove(1);

            foreach (var pair in players)
            {
                Console.WriteLine($"ID : {pair.Key} {pair.Value}");
            }

            int key = 3;

            if (players.TryGetValue(key, out string value))
            {
                Console.WriteLine($"{key}번 플레이어 : {value}");
            }
            else
            {
                Console.WriteLine($"{key}번 플레이어가 없다");
            }

            Dictionary<string, Item> inventory = new Dictionary<string, Item>();
            inventory.Add("칼", new Item("과일 깎는 칼", 10));
            inventory.Add("방패", new Item("나무방패", 5));
            inventory.Add("포션", new Item("힐링포션", 0));

            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            //ToString(): virtual로 생성되어있어서 override 할 수 있다
            Console.WriteLine(inventory.ToString()); //클래스 기반에 모든 오브젝트는 클래스를 상속 받는다

            if (inventory.ContainsKey("칼"))
            {
                Console.WriteLine("과일깎는 칼을 찾았다.");
                Console.WriteLine(inventory["칼"]);
            }

            inventory["방패"].power = 10;
            Console.WriteLine("강화된 방패 : " + inventory["방패"]);
        }
    }
}
