
namespace _25._09._10
{
    /*
    [캐릭터 스탯 강화 매서드 구현]

    요구사항
    1.UpgradeStats(int hp, int atk, int hpIncrease = 10, int atkIncrease = 2) 메서드를 작성
    2.현재 hp, atk를 받아서 지정된 수치만큼 증가(디폴트 매개변수)
    3.강화 후의 hp와 atk 값을 문자열로 반환
    4.Main()에서 호출하여 결과를 확인

    ^Main()호출 예시
    static void Main()
    {
        int hp = 100;
        int atk = 20;

        Console.WriteLine($"강화 전: hp={hp}, atk={atk}");
        Console.WriteLine(UpgradeStats(hp, atk));

        hp = 110;
        atk = 22;
        Console.WriteLine($"강화 전: hp={hp}, atk={atk}");
        Console.writeLine(UpgradeStats(hp, atk);
    }

    ^예시 출력
    강화 전: hp=100, atk=20
    강화 후: hp=110, atk=22

    강화 전: hp=110, atk=22
    강화 후: hp=120, atk=24
    */
    internal class AssignMent_03
    {
        // 메서드 타입을 int 로 했을 시 인수 void 에서 bool로 변환할 수 없다는 오류발생
        // 메서드 타입을 void로 했을 시 반환 값이 없어서 오류발생
        // int 메서드로 int.Parse(()); 형식으로 반환하려 했으나,
        // 암시적으로 void 타입을 bool 타입으로 변환 할 수 없다며 오류 발생
        // 문자열이 반환되여야 하니 메서드 타입을 string으로 수정
        static string UpgradeStats(int hp, int atk, int hpIncrease = 10, int atkIncrease = 2)
        {
            int plusHp = hp + hpIncrease;
            int plusAtk = atk + atkIncrease;
            string result = $"강화 후: hp={plusHp}, atk={atk + atkIncrease}";
            return result;
        }
        static void Main ()
        {
            int hp = 220;
            int atk = 30;

            Console.WriteLine($"강화 전: hp={hp}, atk={atk}");
            Console.WriteLine(UpgradeStats(hp, atk));
            Console.WriteLine();

            hp = 300;
            atk = 45;

            Console.WriteLine($"강화 전: hp={hp}, atk={atk}");
            Console.WriteLine(UpgradeStats(hp, atk));
        }
    }
}
