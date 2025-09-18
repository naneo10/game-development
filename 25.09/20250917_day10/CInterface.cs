
namespace _20250917_day10
{
    /*
    [인터페이스]
    -클래스가 구현해야하는 메서드의 규약을 정의하는 것
    -어떤 동작을 수행해야 하는지만 정의하고 실제 구현은 하지 않음
    -클래스가 특정 기능을 반드시 구현하도록 강제

    [특징]
    -메서드의 구현이 없음
    -메서드를 반드시 구현해야 한다는 규칙만 정의
    -직접적인 코드가 없고 자식 클래스가 반드시 구현해야 함

    -클래스는 하나의 부모 클래스만 상속 받을 수 있지만, 여러개의 인터페이스를 상속 받을 수 있음
    -객체의 행동을 정의하는데 사용
    -IAttackble처럼 특정한 기능을 보장하는데 유용
    -코드 변경없이 새로운 클래스가 같은 동작을 수행하도록 보장
    */

    //인터페이스 선언
    interface IAttackble
    {
        void Attack();
    }

    interface IDamageble
    {
        void TakeDamage(int damage);
    }

    class Warrior : IAttackble
    {
        //인터페이스 메서드 구현
        public void Attack()
        {
            Console.WriteLine("강력한 공격!!");
        }
    }

    class Archer : IAttackble
    {
        public void Attack()
        {
            Console.WriteLine("화살을 쏩니다");
        }
        public void Attack1()
        {
            Console.WriteLine("불화살을 쏩니다!!");
        }
    }

    class Mage : IAttackble, IDamageble
    {
        public void Attack()
        {
            Console.WriteLine("법사가 지팡이를 휘두른다");
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"법사가 {damage}만큼 피해를 입었다");
        }
    }

    /*
    1. Warrior warrior = new Warrior();
    -Warrior 타입의 객체 생성
    -참조타입은 Warrior클래스
    -호출가능한 멤버: Warrior의 모든 public, protected멤버 가능

    2. IAttackble archer = new Archer();
    -.Archer객체를 생성하지만 IAttackble 타입으로 참조
    */
    internal class CInterface
    {
        static void Main ()
        {
            Warrior warrior = new Warrior(); //1
            warrior.Attack();

            IAttackble archer = new Archer(); //2
            archer.Attack();
            //IAtackble타입 이기 때문에 archer클래스 내부에 있는 메서드 호출 불가.
            //archer.Attack1(); 인터페이스 타입이기 때문에 아쳐 클래스 내부에 있는 메서드를 호출할 수 없다 //다운 캐스팅을 활용해야 한다
        }
    }
}
