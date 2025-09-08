
namespace assignment_25._09._08
{
    /*
    과제 03

    ===3. 직업 및 스킬 선택기 (중첩 switch 이용) ===

    요구사항
    1.각 직업별 제공되는 스킬 중 하나 선택(1번 / 2번)
        a.직업선택(1.전사, 2.마법사, 3.도적) int 타입으로 처리
    2.직업과 스킬에 맞는 메시지를 출력
    3.잘못된 선택 시 "잘못된 선택" 출력
    */
    internal class AssignMent_03
    {
        static void Main()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("직업을 선택하세요. (1. 전사, 2. 마법사, 3. 도적)");
                int workFor = int.Parse(Console.ReadLine());

                switch (workFor)
                {
                    case 1:
                        {
                            Console.WriteLine("전사로 전직.");

                            for (int j = 0; j < 3; j++)
                            {
                                Console.WriteLine("어떤 스킬을 사용하시겠습니까? (1. 더블어택, 2. 힘 상승)");
                                int WarriorSkill = int.Parse(Console.ReadLine());

                                switch (WarriorSkill)
                                {
                                    case 1: { Console.WriteLine("더블어택을 사용합니다!"); }break;
                                    case 2: { Console.WriteLine("힘이 일정시간 조금 상승합니다!"); }break;
                                    default: { Console.WriteLine("해금되지 않음"); }break;
                                }
                            }
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("마법사로 전직.");

                            for (int j = 0; j < 3; j++)
                            {
                                Console.WriteLine("어떤 스킬을 사용하시겠습니까? (1. 아이스볼트, 2. 지력 상승)");
                                int WizardSkill = int.Parse(Console.ReadLine());

                                switch (WizardSkill)
                                {
                                    case 1: { Console.WriteLine("아이스볼트를 시전합니다!"); }break;
                                    case 2: { Console.WriteLine("지력이 일정시간 조금 상승합니다!"); }break;
                                    default: { Console.WriteLine("아직 지력이 부족합니다."); }break;
                                }
                            }
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("도적으로 전직.");

                            for (int j = 0; j < 3; j++)
                            {
                                Console.WriteLine("어떤 스킬을 사용하시겠습니까? (1. 은신, 2. 민첩 상승)");
                                int ThiefSkill = int.Parse(Console.ReadLine());

                                switch (ThiefSkill)
                                {
                                    case 1: { Console.WriteLine("은신을 시전합니다!"); }break;
                                    case 2: { Console.WriteLine("민첩이 일정시간 조금 상승합니다!"); }break;
                                    default: { Console.WriteLine("아직 경험이 부족합니다."); }break;
                                }
                            }
                        }
                        break;

                    default: { Console.WriteLine("존재하지 않는 직업입니다."); }break;
                }
            }
        }
    }
}
