
namespace _20250918_day11
{
    class Item
    {
        public string name { get; set; }
        public int power { get; set; }

        public Item (string name, int power)
        {
            this.name = name;
            this.power = power;
        }
    }

    internal class CExample
    {
        static int CompareItemPower (Item item1, Item item2) //item1 = item[0] 이런건가?
        {
            return item2.power.CompareTo(item1.power); //값이 item2가 크면 양수 같으면 0 작으면 -1
        }

        static void Main ()
        {
            List<Item> inven = new List<Item>
            {
                new Item("Sword", 10),
                new Item("Shield", 5),
                new Item("Potion", 0),
                new Item("Axe", 15)
            };

            Console.WriteLine("아이템 목록: ");

            foreach (var item in inven)
            {
                Console.WriteLine($"{item.name} : {item.power}");
            }

            inven.Sort(CompareItemPower);
            Console.WriteLine("아이템 정렬 후 아이템 목록");
            foreach (var item in inven)
            {
                Console.WriteLine($"{item.name} : {item.power}");
            }
        }
    }
}
