
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Xml;

namespace ConsoleApp1
{
    /*
    [텍스트 RPG 평가 과제 (1단계/클래스 생성)

    요구사항
    Player, Monster 클래스를 만든다
    -속성: 이름, 체력(hp), 공격력(attack)
    -메서드: AttackTarget(상대), TakeDamage(int), IsDead()
    1.Nain에서 플레이어와 몬스터를 하나씩 생성한다
    2.전투는 턴제로 진행한다
        -플레이어 턴: 입력 받아 공격하거나 대기
        -몬스터 턴: 자동 공격
        -HP가 0 이하가 되면 전투를 종료하고 승패를 출력한다
    */

    //partial class : https://wjunsea.tistory.com/148
    #region 선공/후공 결정
    public class FirstAttack
    {
        public int Select(int num)
        {
            Random rad = new Random();
            int[] dice = new int[6];

            Console.WriteLine("서로 눈치 보는 중...");

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = i + 1;
            }
            for (int i = dice.Length - 1; i > 0; i--)
            {
                int j = rad.Next(i + 1);
                int temp = dice[i];
                dice[i] = dice[j];
                dice[j] = temp;
            }
            //조건식
            if (dice[0] > num)
            {
                Thread.Sleep(3000);
                Console.WriteLine("[플레이어 선공!]");
                return 0;
            }
            else
            {
                Thread.Sleep(3000);
                Console.WriteLine("[몬스터 선공!]");
                return 1;
            }
        }
    }
    #endregion

    #region 주사위 / 랜덤 값
    public class Dice
    {
        public int DiceNumb()
        {
            Random rad = new Random();
            int[] dice = new int[6];

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = i + 1;
            }
            for (int i = dice.Length - 1; i > 0; i--)
            {
                int j = rad.Next(i + 1);
                int temp = dice[i];
                dice[i] = dice[j];
                dice[j] = temp;
            }
            return dice[0];
        }
        
    }
    #endregion

    #region  전투 진입 / 다른 노드 진입 실행
    public class Form
    {
        public void Delay()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("열심히 걸어가는 중...");
                Thread.Sleep(5000);

                Random rnd = new Random();
                //주사위 굴려서 계속 나아갈지 몬스터와 조우할 지 결정
                int[] dice = new int[6];
                for (int i = 0; i < dice.Length; i++)
                {
                    dice[i] = i + 1;
                }
                for (int i = dice.Length - 1; i > 0; i--)
                {
                    int j = rnd.Next(i + 1);
                    var temp = dice[i];
                    dice[i] = dice[j];
                    dice[j] = temp;
                }
                if (dice[0] > 3)
                {
                    Console.WriteLine("몬스터와 조우했다!");
                    Thread.Sleep(1500);
                    Console.WriteLine("[전투 진입]");
                    break;
                }
                else
                {
                    Console.WriteLine("여기엔 아무 것도 없다. 더 나아가보자");
                    Thread.Sleep(1000);
                }
            }

        }   
    }
    #endregion

    #region  플레이어 클레스
    public class Player
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public Player(string name, int hp, int attack, int defense)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
            Defense = defense;
        }

        public int AttackTarget()
        {
            int atk = Attack;
            return atk;
        }

        public int TakeDamage(int atk)
        {
            int damage = atk - Defense;
            Hp -= damage;
            Console.WriteLine($"[{Name}]이(가) {damage} 피해를 받았다. (현재 체력: {Hp})");
            //반환 값 일단 보류
            return 0;
        }

        public void IsDead(int atk)
        {
            if (Hp <= 0)
            {
                Console.WriteLine($"[{Name}]이(가) {atk} 피해를 입고 쓰러졌습니다.");
            }
        }
    }
    #endregion

    #region 몬스터 클래스
    public class Monster
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public Monster (string name, int hp, int attack, int defense)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
            Defense = defense;
        }

        public int AttackTarget()
        {
            int atk = Attack;
            return atk;
        }

        public int TakeDamage(int atk)
        {
            int damage = atk - Defense;
            Hp -= damage;
            Console.WriteLine($"[{Name}]이(가) {damage} 피해를 받았다. (현재 체력: {Hp})");
            return 0;
        }

        public void IsDead(int atk)
        {
            if (Hp <= 0)
            {
                Console.WriteLine($"[{Name}]이(가) {atk} 피해를 입고 쓰러졌습니다.");
            }
        }
    }
    #endregion

    internal class AssignMent_01
    {
        static void Main ()
        {
            //환경셋
            Form form = new Form();
            FirstAttack first = new FirstAttack();

            //캐릭터, 몬스터 생성
            Player warrior = new Player("김이병", 300, 50, 5);
            Monster kobold = new Monster("코볼트", 120, 30, 0);

            Console.WriteLine($"[{warrior.Name}]이(가) 생성되었습니다.");
            Console.WriteLine($"《현재 체력 : {warrior.Hp}, 공격력 : {warrior.Attack}," +
                $"방어력 : {warrior.Defense}》");

            //노드 랜덤 선택
            form.Delay();

            //주사위 굴리기
            Dice dice = new Dice();

            //전투 진입

            //주사위 값을 비교해 선공 선택
            switch(first.Select(dice.DiceNumb()))
            {
                //플레이어 선공
                case 0:
                    {
                        do
                        {

                        }
                        while (true);
                    }
                break;
                //몬스터 선공
                case 1:
                    {

                    }
                break;
            }



            //캐릭터 공격


        }

        

    }
}