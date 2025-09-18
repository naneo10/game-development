using GameCharacter = Game.Characters.Warrior;

namespace Game.Utils
{
    static class MathHelpher
    {
        public static int CalculateDamage(int baseDamage, int strength)
        {
            return baseDamage + (strength * 2);
        }
    }
}

//namespace는 중첩도 가능하다
//너무 길어질 경우 별명을 지어준다
namespace Game
{
    namespace Characters
    {
        class Warrior
        {
            public void Attack()
            {

            }
        }
    }
}

/*
namespace
-클래스, 인터페이스, 구조체, 열겨형 등등 타입을 그룹화 역할
-이름 충돌을 방지하고 모듈화를 용이하게 해준다
-대규모 프로젝트에서 코드구조를 체계적으로 유지시켜준다
*/
namespace _20250917_day10
{
    internal class CNameSpace
    {
        static void Main ()
        {
            int damage = Game.Utils.MathHelpher.CalculateDamage(1, 2);
            GameCharacter warrior = new GameCharacter();
        }
    }
}
