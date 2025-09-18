
namespace _25._09._17
{
    /*
    [추상클래스 과제 1번]
    몬스터 전투 시스템

    요구사항
    1.부모 클래스 Monster 추상 클래스
    -속성: name, hp
    -메서드:
        abstract void Attack() -> 반드시 자식 클래스에서 구현해야 함
        void PrintInfo() -> 이름과 hp 출력
    2.자식 클래스
    -Goblin -> Attack()구현 -> 고블린이 칼로 공격했다! 출력
    -Orc -> Attack()구현 -> 오크가 도끼로 공격했다! 출력
    -Dragon -> Attack()구현 -> 드래곤이 불을 내뿜었다! 출력
    3.Main() 에서 각 몬스터의 객체를 생성하고, PrintInfo()와 Attack()메서드를 호출하여 정보와 공격을 출력한다.
    */ //과제

    /*
    이름: 고블린, HP: 30
    고블린이 칼로 공격했다!

    이름: 오크, HP: 50
    오크가 도끼로 공격했다!

    이름: 드래곤, HP: 200
    드래곤이 불을 내뿜었다!
    */ //예시 출력

    abstract class Monster
    {
        protected string Name { get; set; }
        protected int Hp { get; set; }
        public Monster(string name, int hp) 
        {
            Name = name;
            Hp = hp;
        }
        //Virtual 대신 abstract
        public abstract void Attack();
        public void PrintInfo()
        {
            Console.WriteLine($"이름: {Name}, HP: {Hp}");
        }
    }

    //override void Atacck()를 정의하지 않으면 오류발생
    class Goblin : Monster
    {
        public Goblin(string name, int hp) : base(name, hp) { }
        public override void Attack()
        {
            Console.WriteLine($"{Name}이 칼로 공격했다!");
        }
    }

    class Orc : Monster
    {
        public Orc(string name, int hp) : base(name, hp) { }
        public override void Attack()
        {
            Console.WriteLine($"{Name}가 도끼로 공격했다!");
        }
    }

    class Dragon : Monster
    {
        public Dragon (string name, int hp) : base(name, hp) { }
        public override void Attack()
        {
            Console.WriteLine($"{Name}이 불을 내뿜었다!");
        }
    }

    internal class AssignMent_01
    {
        static void Main()
        {
            Monster goblin = new Goblin("고블린", 30);
            goblin.PrintInfo();
            goblin.Attack();

            Console.WriteLine();

            Monster orc = new Orc("오크", 50);
            orc.PrintInfo();
            orc.Attack();

            Console.WriteLine();

            Monster dragon = new Dragon("드래곤", 200);
            dragon.PrintInfo();
            dragon.Attack();
        }
    }
}
