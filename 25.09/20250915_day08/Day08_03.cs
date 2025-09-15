
namespace _20250915_day08
{
    /*
    [프로퍼티 (Property)]
    -필드를 캡슐화 하여 안전하게 접근하도록 도와주는 기능
    -getter(읽기)와 setter(쓰기)를 통해 내부 데이터를 보호하면ㅅ, 필요할 때만 값을 읽거나 변경
    -외부에서는 필드에 직접 접근하지 못하고 프로퍼티를 통해 조작이 가능하다

    [읽기 전용 프로퍼티]
    -get만 제공할 경우 읽기만 가능한 프로퍼티
    -객체의 데이터를 외부에서 변경하지 못하도록 함

    [쓰기 전용 프로퍼티]
    -set만 제공하고 get을 없애면 쓰기만 가능한 프로퍼티
    */

    class Circle
    {
        private double pi = 3.14;
        public double Area(double radius)
        {
            return radius * radius * pi; //특정 메서드를 통해서 필드로 접근
        }
    }

    //기본 프로퍼티
    class Character
    {
        private string name; //직접접근 불가(외부에서)

        //프로퍼티
        public string Name
        {
            get 
            { 
                return name; //값 읽기(getter) , set을 제거할 경우 읽기전용으로 변경
            }

            set
            {
                name = value; //값 설정(value는 할당된 값을 의미. 사용자가 프로퍼티에 값을 설정할 때 전달되는 값)
            }
        }
    }


    //[프로퍼티 로직(검증)]
    //-set에서 유효성 검사를 통해 잘못된 값이 입력되지 않도록 보호 가능
    class CharacterF
    {
        private int level;

        public int Level
        {
            get { return level; }
            set
            {
                if(value < 1)
                {
                    level = 1;
                }
                else
                {
                    level = value;
                }
            }
        }
    }

    /*
    [자동구현 프로퍼티]
    -필드를 직접 선언하지 않고도 자동으로 필드를 생성하는 프로퍼티를 제공
    -간단한 속성을 정의할 때 유용하다

    class 클래스명
    {
        private string _name;
        public string Name
        {
            get {return _neme; }
            set {_name = value; }
        }
    }

    */
    class CharacterS
    {
        public string name { get; set; } //자동구현 프로퍼티
    }

    //private 프로퍼티
    class Game
    {
        private int Score {  get; set; } //private? 클래스 내부에서만 접근 가능

        public void IncreaseScore(int s)
        {
            Score += s;
            Console.WriteLine(Score); //특정 메서드만 통해서 값을 변경 가능하다
        }
    }
    internal class Day08_03
    {
        static void Main()
        {
            Character player = new Character();
            player.Name = "슬라임";
            Console.WriteLine(player.Name);

            CharacterS characterS = new CharacterS();
            characterS.name = "고블린";
            Console.WriteLine(characterS.name);

            Game game = new Game();
        }
    }
}
