
namespace _20250915_day08
{
    /*
    [생성자]
    -객체를 생성할 때 ^'자동으로 호출'되는 메서드
    -객체의 초기상태(필드 값)를 설정하는 역할
    -클래스 이름과 동일하고 반환형이 없음
    -사용자 정의 생성자가 없으면 기본생성자가 생성된다

    ^Garbage Collecter 덕택에 소멸자를 사용하지 않아도 된다 //생성할 때 자동이니 소멸할 때도 자동으로 삭제해준다
    디스트럭터 thistructor ? distructor? er?

    오버로딩 오버라이딩
    */
    class Character
    {
        private string name;
        private int level;

        //이렇게 없으면 default 생성자를 자동으로 생성, 객체를 생성할 때 생성자가 없다 그러면 기본 값으로 만듬
        public Character()
        {
            //필드 값이 없을 경우 기본 값으로 생성
            //name = "초보자";
            //level = 1;
            //Console.WriteLine("캐릭터가 생성되었습니다.");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
    }

        //메서드라면 어떤게 가능한가?
        //생성자 오버로딩 *특별한 메서드
    class CharacterF
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public CharacterF()
        {
            Name = "초보자";
            Level = 1;
            Console.WriteLine("기본 캐릭터 생성완료");
        }
        public CharacterF(string name)
        {
            Name = name;
            Level = 1;
            Console.WriteLine($"이름이 설정 되었다. {name}");
        }
        public CharacterF(string name, int level)
        {
            Name = name;
            Level = level;
            Console.WriteLine($"이름은 : {name}, 레벨 : {level}");
        }
    }
    
    internal class Day08_04
    {
        static void Main ()
        {
            Character player = new Character(); // '()' 생성자
            Console.WriteLine($"이름: {player.Name}, 레벨: {player.Level}");

            CharacterF player1 = new CharacterF();
            CharacterF player2 = new CharacterF("전사");
            CharacterF player3 = new CharacterF("마법사", 5);
        }
    }
}
