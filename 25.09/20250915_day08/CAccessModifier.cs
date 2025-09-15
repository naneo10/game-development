
namespace _20250915_day08
{
    /*
    [접근 제한자]
    -클래스, 필드, 메서드, 프로퍼티 등에 접근 할 수 있는 범위를 결정하는 키워드
    -접근 제한자를 적절히 활용하면 캡슐화를 통해 데이터를 보호하고 필요한 부분만 공개

    [접근 제한자]
    public                      어디서든 접근 가능
    private                     클래스 내부에서만 접근 가능
    protected                   현재 클래스 + 상속받은 클래스에서 접근 가능
    internal                    같은 프로젝트에서만 접근 가능
    protected internal          같은 프로젝트 + 상속받은 클래스 접근
    private protected           같은 클래스 + 같은 프로젝트 내에서 상속받은 클래스에서 접근가능

    클래스 기본 제한자 internal
    */

    public class Outer
    {
        private class Inner //중첩 클래스를 사용할 경우 'Outer'내에서만 사용 가능
        {

        }
    }

    class Character
    {
        //제한자 공란으로 할 시 default 값으로 private가 적용됨
        public string name = "홍길동"; //누구나 접근 가능
        //메서드는 퍼블릭으로 작성 외부에서 사용하기 위해서
    }

    class Characters
    {
        private int level = 1;
        public void SetLevel(int newLevel)
        {
            if (newLevel > 0)
            {
                level = newLevel;
            }
        }
        public void Show()
        {
            Console.WriteLine($"현재 레벨: {level}");
        }
    }

    //부모
    class CharacterD
    {
        protected int health = 100; //부모 자식 상속관계 + 나 자신
        public int hp = 100;
        private int mp = 50; //비자금은 줄 수 없다
    }

    //자식
    class Warrior : CharacterD
    {
        public void TakeDamage()
        {
            health = 10; //자식클래스에서 접근 가능
            hp -= 20;
            //mp -= 20; //비자금 할당 불가
        }
    }

    internal class CAccessModifier
    {
        static void Main()
        {
            Character c = new Character();
            Console.WriteLine(c.name);

            Characters player = new Characters();
            //player.level = 10; 접근 불가(private)
            player.SetLevel(10);
            player.Show();
        }
    }
}
