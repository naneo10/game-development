
namespace _25._09._17
{
    /*
    [추상클레스, 인터페이스 과제]
    추상클래스와 인터페이스로 캐릭터 만들기

    요구사항
    1.추상 클래스 Character
    -필드/프로퍼티: name, health, attackPower
    -메서드
    :ShowStatus(): 상태 출력
    :TakeDamage(int damage): 체력 감소

    2.인터페이스
    -IAttackable : void Attack()
    -IHealable : void Heal()

    3.구현 클래스
    -Warrior : Character 상속 + IAttackable 구현
    -Mage : Character 상속 + IAttackable, IHealable 구현

    4.Main()
    -전사/마법사 생성 -> 상태 출력 ShowStatus() -> Attack() 호출
    -마법사만 Heal() 추가호출
    -TakeDamage(int damage)로 각각 피해 적용 후 상태 재출력
    */ //과제

    /*
    [ 아르곤 ] 체력: 150, 공격력: 20
    [ 메디브 ] 체력: 100, 공격력: 15
    아르곤이(가) 강력한 검 공격을 ㅎ합니다! (공격력: 20)
    메디브이(가) 파이어볼을 던졌습니다! (공격력: 15)
    메디브이(가) 체력을 회복했습니다! (현재 체력: 120)
    아르곤이(가) 30 피해를 입었습니다! (남은 체력: 120)
    메디브이(가) 40 피해를 입었습니다! (남은 체력: 80)
    */ //예시 출력

    abstract class Character
    {
        protected string Name { get; set; }
        protected int Health { get; set; }
        protected int AttackPower { get; set; }

        public Character (string name)
        {
            Name = name;
        }

        public void ShowStatus ()
        {
            Console.WriteLine($"[{Name}] 체력: {Health}, 공격력: {AttackPower}");
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name}이(가) {damage} 피해를 입었습니다! (남은 체력: {Health})");
        }
    }

    interface IAttackable
    {
        public void Attack();
    }

    interface IHealable
    {
        public void Heal();
    }

    class Warrior : Character , IAttackable
    {
        public Warrior(string name) : base(name)
        {
            Name = name;
            Health = 150;
            AttackPower = 20;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name}이(가) 강력한 검 공격을 합니다! (공격력: {AttackPower})");
        }
    }

    class Mage : Character , IAttackable , IHealable
    {
        public Mage(string name) : base(name)
        {
            Name = name;
            Health = 100;
            AttackPower = 15;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name}이(가) 파이어볼을 던졌습니다! (공격력: {AttackPower})");
        }

        public void Heal ()
        {
            Health += 20;
            Console.WriteLine($"{Name}이(가) 체력을 회복했습니다! (현제 체력: {Health})");
        }
    }

    internal class AssignMent_04
    {
        static void Main ()
        {
            Warrior warrior = new Warrior("아르곤");
            Mage mage = new Mage("메디브");

            warrior.ShowStatus();
            mage.ShowStatus();

            warrior.Attack();
            mage.Attack();
            mage.Heal();

            warrior.TakeDamage(30);
            mage.TakeDamage(40);
        }
    }
}
