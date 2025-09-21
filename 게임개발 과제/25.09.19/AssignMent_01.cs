
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Threading;
using System.Xml;

namespace ConsoleApp1
{
    #region 과제4: 인터페이스 활용
    interface IAttackable
    {
        int AttackTarget(Player player);
        int AttackTarget(Monster monster, int num);

        int TakeDamage(int num);
    }
    #endregion

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

    #region  과제1, 3: 플레이어 클레스
    public class Player //: IAttackable
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public string SkillName { get; set; }
        public int SkillDamage { get; set; }

        public Player(string name, int hp, int attack, int defense)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
            Defense = defense;
        }

        //스킬
        public List<Skill> skills = new List<Skill>();
        public void AddSkill(Skill skill)
        {
            skills.Add(skill);
        }

        public List<Skill> SkillList()
        {
            Console.Write("보유한 스킬 : ");
            foreach (Skill skill in skills)
            {
                Console.Write("[ ");
                Console.Write($"{skill.Name}");
                Console.Write(" ]");
            }
            Console.WriteLine();
            return skills;
        }

        //공격
        public int AttackTarget(Monster monster, int num)
        {
            int playerDamage = 0;
            switch (num)
            {
                case 1:
                    {
                        playerDamage = skills[0].Damage - monster.Defense;
                    }
                    break;
                case 2:
                    {
                        playerDamage = skills[1].Damage - monster.Defense;
                    }
                    break;
            }
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

    #region 과제1: 몬스터 클래스
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

    #region 과제2: enum 플레이어
    public class PlayerEnum
    {
        public enum AttackType
        {
            Attack = 1,
            Wait = 2,
        }

        public void Action(string inputNumb, Monster monster, Player player)
        {
            if (int.TryParse(inputNumb, out int value))
            {
                AttackType choice = (AttackType)value;
                switch (choice)
                {
                    case AttackType.Attack:
                        {
                            while (true)
                            {
                                Console.WriteLine("자세를 가다듬는다. 공격할 스킬을 선택하자!");
                                player.SkillList();
                                inputNumb = Console.ReadLine();

                                bool checkNum = int.TryParse(inputNumb, out int numGC);

                                switch (numGC)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine($"[{player.skills[0].Name}]");
                                            monster.TakeDamage(player.AttackTarget(monster, numGC));
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine($"[{player.skills[1].Name}]");
                                            monster.TakeDamage(player.AttackTarget(monster, numGC));
                                        }
                                        break;
                                }
                                if (numGC == 1 || numGC == 2)
                                {
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }

                            if (monster.IsDead())
                            {
                                Console.WriteLine($"[{monster.Name}]이(가) 치명적인 피해를 입고 쓰러졌다!");
                                Thread.Sleep(2000);
                                Console.WriteLine($"[{player.Name}]의 승리!");
                            }
                        }
                        break;
                    case AttackType.Wait:
                        {
                            player.Defense = player.Defense + 5;
                            Console.WriteLine($"방패를 들고 자세를 낮춘다! " +
                                $"(현재 방어력: {player.Defense})");
                        }
                        break;
                }
            }
        }
    }

    #endregion

    #region 과제2: enum 몬스터
    public class MonsterEnum
    {
        public enum AttackType
        {
            Attack = 1,
            Wait
        }

        public void Action(Monster monster, Player player)
        {
            Random rad = new Random();
            int[] monsterSelect = new int[] { 1, 2 };

            for (int i = monsterSelect.Length - 1; i > 0; i--)
            {
                int j = rad.Next(i + 1);
                int temp = monsterSelect[i];
                monsterSelect[i] = monsterSelect[j];
                monsterSelect[j] = temp;
            }

            int value = monsterSelect[0];

            AttackType choice = (AttackType)value;
            switch (choice)
            {
                case AttackType.Attack:
                    {
                        Console.WriteLine("가방에서 활을 꺼내든다!");
                        player.TakeDamage(monster.AttackTarget(player));

                        if (player.IsDead())
                        {
                            Console.WriteLine($"[{player.Name}]이(가) 치명상을 입고 쓰러졌다!");
                            Thread.Sleep(2000);
                            Console.WriteLine($"[{player.Name}]의 패배");
                        }
                    }
                    break;
                case AttackType.Wait:
                    {
                        monster.Defense = monster.Defense + 5;
                        Console.WriteLine($"방어자세를 취한다! (현재 방어력: {monster.Defense})");
                    }
                    break;
            }
        }
    }
    #endregion

    #region 과제3: Skill 클래스
    public class Skill
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Skill (string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
    #endregion

    internal class AssignMent_01
    {
        static void Main ()
        {
            #region 환경셋
            //셋팅
            Form form = new Form();
            FirstAttack first = new FirstAttack();
            Random rad = new Random();
            PlayerEnum player = new PlayerEnum();
            MonsterEnum monster = new MonsterEnum();
            Skill[] skillF = new Skill[3];

            //캐릭터, 몬스터 생성
            Player warrior = new Player("김이병", 150, 20, 5);
            Monster kobold = new Monster("코볼트", 120, 30, 0);

            //스킬 생성
            skillF[0] = new Skill("일반공격", warrior.Attack * 1);
            skillF[1] = new Skill("이중공격", warrior.Attack * 2);
            skillF[2] = new Skill("방패치기", warrior.Attack * 2);

            //시작 구문
            Console.WriteLine($"[{warrior.Name}]이(가) 여행을 시작합니다!.");
            Console.WriteLine($"《현재 체력 : {warrior.Hp}, 공격력 : {warrior.Attack}, " +
                $"방어력 : {warrior.Defense}》");

            Thread.Sleep(2000);
            #endregion

            #region 스킬 선택
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                while(true)
                {
                    Console.WriteLine("스킬을 2가지 선택하시오!");
                    foreach ( var skill in skillF)
                    {
                        Console.Write("[ ");
                        Console.Write($"스킬 이름 : {skill.Name}");
                        Console.Write(" ]");
                    }
                    Console.WriteLine();

                    string choiceSkill = Console.ReadLine();
                    bool confirmNum = int.TryParse(choiceSkill, out int num);

                    //스킬 선택
                    switch (num)
                    {
                        case 1:
                            {
                                Console.WriteLine($"[{skillF[0].Name}]을 선택하셨습니다");
                                Console.WriteLine();
                                warrior.AddSkill(skillF[0]);
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine($"[{skillF[1].Name}]을 선택하셨습니다");
                                Console.WriteLine();
                                warrior.AddSkill(skillF[1]);
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine($"[{skillF[2].Name}]을 선택하셨습니다");
                                Console.WriteLine();
                                warrior.AddSkill(skillF[2]);
                            }
                            break;
                    }

                    //조건식
                    if (num > 0 && num < 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 선택입니다.");
                        Console.WriteLine();
                        continue;
                    }
                }
            }
            //선택한 스킬 확인
            warrior.SkillList();
            Thread.Sleep(3000);
            #endregion


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
                                    int value = 0;
                                    do
                                    {
                                        count++;
                                        while (true)
                                        {
                                            //플레이어 공격
                                            Console.WriteLine($"[{count}번째 턴] 1. 공격, 2. 대기(방어)");

                                            while (true)
                                            {
                                                string inputNumb = Console.ReadLine();
                                                bool saveNumb = int.TryParse(inputNumb, out value);

                                                if (!saveNumb)
                                                {
                                                    Console.WriteLine("잘못된 판단이다!");
                                                    continue;
                                                }
                                                else if (value == 1 || value == 2)
                                                {
                                                    player.Action(inputNumb, kobold, warrior);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("잘못된 판단이다!");
                                                    continue;
                                                }
                                            }
                                            Console.WriteLine();

                                            if (kobold.Hp <= 0)
                                            {
                                                break;
                                            }

                                            //몬스터 방어자세 초기화
                                            if (kobold.Defense == 5)
                                            {
                                                kobold.Defense -= 5;
                                            }

                                            //몬스터 공격
                                            Console.WriteLine($"[{kobold.Name}]이(가) 빈틈을 노려보고 있다!");
                                            Thread.Sleep(3000);
                                            
                                            monster.Action(kobold, warrior);
                                            Console.WriteLine();

                                            //플레이어 방어자세 초기화
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
                                    int value = 0;
                                    do
                                    {
                                        count++;
                                        while (true)
                                        {
                                            #region 몬스터 공격
                                            Console.WriteLine($"[{kobold.Name}]이(가) 빈틈을 노려보고 있다!");
                                            Thread.Sleep(3000);

                                            monster.Action(kobold, warrior);
                                            Console.WriteLine();
                                            #endregion

                                            if (warrior.Hp <= 0)
                                            {
                                                break;
                                            }

                                            //방어자세 초기화
                                            if (value == 2)
                                            {
                                                warrior.Defense -= 5;
                                            }

                                            #region 플레이어 공격
                                            Console.WriteLine($"[{count}번째 턴] 1. 공격, 2. 대기(방어)");
                                            while(true)
                                            {
                                                string inputNumb = Console.ReadLine();
                                                bool saveNumb = int.TryParse(inputNumb, out value);

                                                if (!saveNumb)
                                                {
                                                    Console.WriteLine("잘못된 판단이다!");
                                                    continue;
                                                }
                                                else if (value == 1 || value == 2)
                                                {
                                                    player.Action(inputNumb, kobold, warrior);
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("잘못된 판단이다!");
                                                    continue;
                                                }
                                            }

                                            Console.WriteLine();
                                            #endregion

                                            //방어자세 초기화
                                            if (kobold.Defense == 5)
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