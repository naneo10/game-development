
namespace _25._09._10
{
    /*
    [공격 데미지 계산기 (메서드 오버로딩) 메서드 구현
    
    요구사항
    1.CalculateDamage 메서드를 다음과 같이 3가지 버전으로 작성
        CalculateDamage(int atk, int def) - 방어력을 뺀 피해량 반환
        CalculateDamage(int atk, int def, bool isCriticl) - 치명타 시 x1.5 배율 적용
        CalculateDamage(int atk, int def, int bonusDamage) - 추가 피해량 포함
        Main()에서 각 버전을 호출하여 결과를 출력

    ^Main()호출 예시
    static void Main()
    {
        Console.WriteLine("기본 공격: " + CalculateDamage(50, 25));
        Console.WriteLine("치명타 공격: " + CalculateDamage(50, 25, true));
        Console.WriteLine("보너스 포함 공격: " + CalculateDamage(50, 25, 5);
    }

    ^예시 출력
    기본 공격: 25
    치명타 공격: 37
    보너스 포함 공격: 30
    */
    internal class AssignMent_04
    {
        static int CalculateDamage (int atk, int def)
        {
            return atk - def;
        }

        //int를 타입으로 잡았으나 소수점이 포함되어 오류발생
        //float 타입으로 했을 때 'double'형식을 'float'형식으로 변환할 수 없다는 오류발생
        //float과 double이 실수형태이고 허용범위의 차이 뿐이라 생각하는데 다른 차이점이 있는지 확인 필
        static double CalculateDamage (int atk, int def, bool isCritical)
        {
            double critical = 0;
            int normalDamage = 0;
            double ct = 0;

            if (isCritical == true)
            {
                normalDamage = atk - def;
                critical = normalDamage * 1.5;
                //소수점 이하 값을 절삭하는 방법은?
                //참조: https://easy-coding.tistory.com/113
                ct = Math.Truncate(critical);
            }
            return ct;
        }

        static int CalculateDamage (int atk, int def, int bonusDamage)
        {

            return atk - def + bonusDamage;
        }

        static void Main ()
        {

            Console.WriteLine($"기본 공격: " + CalculateDamage(50, 25));
            Console.WriteLine($"치명타 공격: " + CalculateDamage(50, 25, true));
            Console.WriteLine($"보너스 포함 공격: " + CalculateDamage(50, 25, 5));
        }
    }
}
