
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
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
            Console.WriteLine();

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
        public int Delay()
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
                //전투 진입 시 '0'값 반환
                if (dice[0] <= 3)
                {
                    Console.WriteLine("몬스터와 조우했다!");
                    Thread.Sleep(1500);
                    Console.WriteLine("[전투 진입]");
                    Console.WriteLine();
                    return 0;
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

        public int AttackTarget(Monster monster)
        {
            int playerDamage = Attack - monster.Defense;
            return playerDamage;
        }

        public int TakeDamage(int monsterDamage)
        {
            Hp -= monsterDamage;
            Console.WriteLine($"[{Name}]이(가) {monsterDamage} 피해를 받았다! " +
                $"(현재 체력: {Hp})");
            return Hp;
        }

        public bool IsDead()
        {
            if (Hp <= 0)
            {
                return true;
            }
            return false;
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

        public int AttackTarget(Player player)
        {
            int monsterDamage = Attack - player.Defense;
            return monsterDamage;
        }

        public int TakeDamage(int playerDamage)
        {
            Hp -= playerDamage;
            Console.WriteLine($"[{Name}]이(가) {playerDamage} 피해를 받았다. (현재 체력: {Hp})");
            return Hp;
        }

        public bool IsDead()
        {
            if (Hp <= 0)
            {
                return true;
            }
            return false;
        }
    }
    #endregion

    internal class AssignMent_01
    {
        enum SelectNumber
        {
            None,
            Attack,
            Wait,
            Etc
        }

        static void Main ()
        {
            //환경셋
            Form form = new Form();
            FirstAttack first = new FirstAttack();
            Random rad = new Random();
            SelectNumber selectNumber;

            //몬스터 선택지
            int[] monsterSelect = { 1, 2 };

            //캐릭터, 몬스터 생성
            Player warrior = new Player("김이병", 300, 50, 5);
            Monster kobold = new Monster("코볼트", 120, 30, 0);

            Console.WriteLine($"[{warrior.Name}]이(가) 생성되었습니다.");
            Console.WriteLine($"《현재 체력 : {warrior.Hp}, 공격력 : {warrior.Attack}, " +
                $"방어력 : {warrior.Defense}》");

            //노드 랜덤 선택 (전투, 비전투 구현)
            switch (form.Delay())
            {
                //전투 노드
                case 0:
                    {
                        //주사위 굴리기
                        Dice dice = new Dice();

                        //몬스터 정보
                        Console.WriteLine($"[{kobold.Name}]이(가) 앞을 막아선다!");
                        Console.WriteLine($"《체력 : {kobold.Hp}, 공격력 : {kobold.Attack}, 방어력 : {kobold.Defense}》");
                        Console.WriteLine();

                        //주사위 값을 비교해 선공 선택
                        switch (first.Select(dice.DiceNumb()))
                        {
                            //플레이어 선공
                            case 0:
                                {
                                    int count = 0;
                                    do
                                    {
                                        count++;
                                        while (true)
                                        {
                                            #region 플레이어 공격
                                            Console.WriteLine($"[{count}번째 턴] 1. 공격, 2. 대기(방어)");
                                            string inputNumb = Console.ReadLine();
                                            bool comfirmNumb = int.TryParse(inputNumb, out int value);

                                            //문자 입력 시
                                            if (!comfirmNumb)
                                            {
                                                Console.WriteLine("당황할 시간이 없다!");
                                                Console.WriteLine();
                                                continue;
                                            }

                                            if (value == 1)
                                            {
                                                Console.WriteLine("자세를 가다듬는다.");
                                                kobold.TakeDamage(warrior.AttackTarget(kobold));

                                                if (kobold.IsDead())
                                                {
                                                    Console.WriteLine($"[{kobold.Name}]이(가) 치명적인 피해를 입고 쓰러졌다!");
                                                    Thread.Sleep(2000);
                                                    Console.WriteLine($"[{warrior.Name}]의 승리!");
                                                    break;
                                                }
                                            }
                                            else if (value == 2)
                                            {
                                                warrior.Defense = warrior.Defense + 5;
                                                Console.WriteLine($"방패를 들고 자세를 낮춘다! " +
                                                    $"(방어력 상승: {warrior.Defense})");
                                            }
                                            else
                                            {
                                                Console.WriteLine("신중하게 선택해야한다!");
                                                Console.WriteLine();
                                                continue;
                                            }
                                            Console.WriteLine("[플레이어 턴 종료]");
                                            Console.WriteLine();
                                            #endregion

                                            //방어자세 초기화
                                            if (monsterSelect[0] == 2)
                                            {
                                                kobold.Defense -= 5;
                                            }

                                            #region  몬스터 공격
                                            //몬스터 공격
                                            Console.WriteLine($"{kobold.Name}이(가) 빈틈을 노려보고 있다!");
                                            Thread.Sleep(3000);
                                            for (int i = monsterSelect.Length - 1; i > 0; i--)
                                            {
                                                int j = rad.Next(i + 1);
                                                int temp = monsterSelect[i];
                                                monsterSelect[i] = monsterSelect[j];
                                                monsterSelect[j] = temp;
                                            }

                                            if (monsterSelect[0] == 1)
                                            {
                                                Console.WriteLine("가방에서 활을 꺼내든다!");
                                                warrior.TakeDamage(kobold.AttackTarget(warrior));

                                                if (warrior.IsDead())
                                                {
                                                    Console.WriteLine($"[{warrior.Name}]이(가) 치명상을 입고 쓰러졌다!");
                                                    Thread.Sleep(2000);
                                                    Console.WriteLine($"[{warrior.Name}]의 패배");
                                                    break;
                                                }
                                            }
                                            else if (monsterSelect[0] == 2)
                                            {
                                                kobold.Defense = kobold.Defense + 5;
                                                Console.WriteLine($"방어자세를 취한다! (방어력 상승: {kobold.Defense})");
                                            }
                                            Console.WriteLine("[몬스터 턴 종료]");
                                            Console.WriteLine();
                                            #endregion

                                            //방어자세 초기화
                                            if (value == 2)
                                            {
                                                warrior.Defense -= 5;
                                            }
                                            break;
                                        }//while
                                    }//do
                                    while (kobold.Hp > 0 && warrior.Hp > 0);
                                }
                                break;
                            //몬스터 선공
                            case 1:
                                {
                                    int count = 0;
                                    do
                                    {
                                        count++;
                                        while (true)
                                        {
                                            #region 몬스터 공격
                                            Console.WriteLine($"{kobold.Name}이(가) 빈틈을 노려보고 있다!");
                                            Thread.Sleep(3000);
                                            for (int i = monsterSelect.Length - 1; i > 0; i--)
                                            {
                                                int j = rad.Next(i + 1);
                                                int temp = monsterSelect[i];
                                                monsterSelect[i] = monsterSelect[j];
                                                monsterSelect[j] = temp;
                                            }

                                            if (monsterSelect[0] == 1)
                                            {
                                                Console.WriteLine("가방에서 활을 꺼내든다!");
                                                warrior.TakeDamage(kobold.AttackTarget(warrior));

                                                if (warrior.IsDead())
                                                {
                                                    Console.WriteLine($"[{warrior.Name}]이(가) 치명상을 입고 쓰러졌다!");
                                                    Thread.Sleep(2000);
                                                    Console.WriteLine($"[{warrior.Name}]의 패배");
                                                    break;
                                                }

                                            }
                                            else if (monsterSelect[0] == 2)
                                            {
                                                kobold.Defense = kobold.Defense + 5;
                                                Console.WriteLine($"방어자세를 취한다! (방어력 상승: {kobold.Defense})");
                                            }
                                            Console.WriteLine("[몬스터 턴 종료]");
                                            Console.WriteLine();
                                            #endregion

                                            //방어자세 초기화
                                            int value = 0;
                                            if (value == 2)
                                            {
                                                warrior.Defense -= 5;
                                            }

                                            #region 플레이어 공격
                                            while (true)
                                            {
                                                Console.WriteLine($"[{count}번째 턴] 1. 공격, 2. 대기(방어)");
                                                string inputNumb = Console.ReadLine();
                                                bool comfirmNumb = int.TryParse(inputNumb, out value);

                                                //문자 입력 시
                                                if (!comfirmNumb)
                                                {
                                                    Console.WriteLine("당황할 시간이 없다!");
                                                    Console.WriteLine();
                                                    continue;
                                                }

                                                if (value == 1)
                                                {
                                                    Console.WriteLine("자세를 가다듬는다.");
                                                    kobold.TakeDamage(warrior.AttackTarget(kobold));

                                                    if (kobold.IsDead())
                                                    {
                                                        Console.WriteLine($"[{kobold.Name}이(가) 치명상을 입고 쓰러졌다!");
                                                        Thread.Sleep(2000);
                                                        Console.WriteLine($"[{warrior.Name}]의 승리!");
                                                    }
                                                    break;
                                                }
                                                else if (value == 2)
                                                {
                                                    warrior.Defense = warrior.Defense + 5;
                                                    Console.WriteLine($"방패를 들고 자세를 낮춘다! " +
                                                        $"(방어력 상승: {warrior.Defense})");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("신중하게 선택해야한다!");
                                                    Console.WriteLine();
                                                    continue;
                                                }
                                            }
                                            Console.WriteLine("[플레이어 턴 종료]");
                                            Console.WriteLine();
                                            #endregion

                                            //방어자세 초기화
                                            if (monsterSelect[0] == 2)
                                            {
                                                kobold.Defense -= 5;
                                            }
                                            break;
                                        }//while
                                    }//do
                                    while (kobold.Hp > 0 && warrior.Hp > 0);
                                }
                                break;
                        }
                    }
                    break;
            }//switch //노드 랜덤 선택 (전투, 비전투 구현)

        }

        

    }
}