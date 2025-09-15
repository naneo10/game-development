
namespace _25._09._15
{
    /*
    [아이템 클래스 정보출력(생성자 활용)]

    요구사항
    1.Item 클래스를 만든다.
    2.Item 클래스는 다음 필드(속성)를 가진다.
    -이름(string)
    -가격(int)
    -설명(string)
    3.Item 클래스는 생성자를 이용하여 모든 필드를 초기화한다.
    4.Item 클래스에 다음 메서드를 가진다.
    -PrintInfo(): 아이템 정보를 출력하는 메서드
    5.Main()에서 Character 객체를 생성하고 정보를 출력한다.
    */ //구현과제

    /*
    [예시 출력]
    아이템: 마법봉, 가격: 500, 설명: 강력한 마법을 사용할 수 있는 아이템
    */ //예시출력

    class Item
    {
        private string name;
        private int price;
        private string manual;

        public Item()
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Manual
        {
            get { return manual; }
            set { manual = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"아이템: {name}, 가격: {price}, 설명: {Manual}");
        }
    }

    internal class AssingMent_02
    {
        static void Main ()
        {
            Item item = new Item();
            item.Name = "마법봉";
            item.Price = 500;
            item.Manual = "강력하고 튼튼하고 오랜시간동안 마법을 사용할 수 있는 아이템";

            item.PrintInfo();
        }
    }
}
