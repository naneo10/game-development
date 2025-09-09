namespace _20250909_day04
{
    internal class Program
    {
        //과제 풀이
        //1. 성적 등급 판정기
        //2. 입장료
        //3. 직업 및 스킬 선택
        static void Main(string[] args)
        {
            //성적 등급 판정기
            //입력받기
            Console.WriteLine("점수를 입력하세요 (0~100) : ");
            string input = Console.ReadLine();
            //int score = int.Parse(input);

            //TryParse: 변환이 성공하면 true, 실퍃면 false
            //실패하더라도 단순히 false만 돌려주기 때문에 안전
            //out int score: 변환이 성공했을 때 변환된 정수 값을 score 변수에 저장
            //TryParse 호출이 끝난 후 score에는 변환된 정수가 들어가게 됨
            //아래 if문은 변환이 실패하면 '!' 때문에 if문이 실행되고 성공하면 실행히 되지 않는다
            if(!int.TryParse(input, out int score))
            {
                Console.WriteLine("잘못된 입력입니다.");
                return;
            }
            if(score < 0 || score > 100)
            {
                Console.WriteLine("점수는 0에서 100점 사이여야 한다");
                return; //메서드를 빠져 나온다 / 0~100점 외 점수 기입시 메인을 종료하겠다.
            }
            if (score >= 90) Console.WriteLine("A등급");
            else if (score >= 80) Console.WriteLine("B등급");
            else if (score >= 70) Console.WriteLine("C등급");
            else if (score >= 60) Console.WriteLine("D등급");
            else Console.WriteLine("F등급");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //입장요금 계산기
            Console.WriteLine("입장요금 계산기. 나이를 입력하세요.");
            string ageInput = Console.ReadLine();
            if(!int.TryParse(ageInput, out int age)||age < 0)
            {
                Console.WriteLine("잘못된 입력입니다.");
                return;
            }
            Console.WriteLine("학생입니까? (Y/N)");
            string stInput = Console.ReadLine();

            //13세 미만 : 5,000
            //13~19 : 학생 7,000 / 아니면 8,000
            //20 이상 : 학생 9,000 / 아니면 10,000

            int price = 0;
            
            if (age < 13)
            {
                price = 5000;
            }
            else if(age <= 19)
            {
                if (stInput == "y")
                {
                    price = 7000;
                }
                else if(stInput == "n")
                {
                    price = 8000;
                }
                else
                {
                    Console.WriteLine("학새 여부는 y나 n으로만 입력하시오");
                    return;
                }
            }
            else
            {
                if (stInput == "y")
                {
                    price = 9000;
                }
                else if (stInput == "n")
                {
                    price = 10000;
                }
                else
                {
                    Console.WriteLine("학새 여부는 y나 n으로만 입력하시오");
                    return;
                }
            }

            Console.WriteLine($"요금은{price}입니다");

            //직업선택
            Console.WriteLine("직업을 선택해라(1: 전사, 2: 마법사, 3: 도적):");
            int jobSelect = int.Parse(Console.ReadLine());

            switch (jobSelect)
            {
                case 1:
                    Console.WriteLine("전사를 선택했다. 어떤 스킬을 사용할 것인가? (1: 그냥 공격, 2: 방어):");
                break;

                case 2:
                    Console.WriteLine("마법사를 선택했다. 어떤 스킬을 사용할 것인가? (1: 화염공격, 2: 치유마법):");
                break;

                case 3:
                    Console.WriteLine("도적을 선택했다. 어떤 스킬을 사용할 것인가? (1: 은신, 2: 크리티컬공격):");
                break;
            }
            int skillSelect = int.Parse(Console.ReadLine());
            switch (jobSelect)
            {
                case 1:
                    switch (skillSelect)
                    {
                        case 1:
                            Console.WriteLine("그냥 공격함. 적에게 큰 피해를 입히지 못했다.");
                            break;
                        case 2:
                            Console.WriteLine("방어태세. 몬스터로 부터 방어를 강화한다.");
                            break;
                    }
                    break;

                case 2:
                    switch (skillSelect)
                    {
                        case 1:
                            Console.WriteLine("강력한 화염공격을 한다.");
                            break;
                        case 2:
                            Console.WriteLine("치유마법을 시전함. 내 체력을 회복한다.");
                            break;
                    }
                    break;
            }
        }
    }
}
