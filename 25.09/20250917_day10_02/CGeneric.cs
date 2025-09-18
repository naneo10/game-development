
namespace _20250917_day10_02
{
    /*
    [Generic 제약]
    -일반화 자료형을 선언할 때 제약조건을 선언하여, 사용당시 쓸 수 있는 자료형을 제한
    -제네릭 타입 제한 where T: 조건형식으로 사용하며, 여러개를 조합할 수 있음
    -불필요한 타입이 들어가는 것을 방지하고, 원하는 기능을 보장하는데 유용하다
    */

    /*
    class StructT<T> where T : struct{} //'T'는 구조체만 사용 가능
    class ClassT<T> where T : class{} //'T'는 클래스만 사용 가능
    class NewT<T> where T : new{} //'T'는 매개변수 없는 생성자가 있는 자료형만 사용 가능

    class ParentT<T> where T : Parent{} //'T'는 Parent 파생 클래스만 사용 가능
    class InterfaceT<T> where T : IComparalbe{} //'T'는 인터페이스를 포함한 자료형만 사용가능
    */

    internal class CGeneric
    {
        //클래스 타입(참조타입)만 허용
        class ReferenceOnly<T> where T : class
        {
            public T data { get; set; }
            public ReferenceOnly(T date)
            {
                this.data = data;
            }
        }

        class ValueOnly<T> where T : struct
        {
            public T data { get; set; }
            public ValueOnly(T date)
            {
                this.data = data;
            }
        }

        class InterfaceT<T> where T : IComparable
        {

        }
        
        class Character { public string name { get; set; } }
        class Warrior : Character { }
        class Mage { }

        class CharacterManager<T> where T : Character { }

        static void Main ()
        {
            ReferenceOnly<string> refInstance = new ReferenceOnly<string>("Hellow");
            //ReferenceOnly<int> intInstance = new ReferenceOnly<int>(100);

            //ValueOnly<string> valueInstance = new ValueOnly<string>("Hellow");
            ValueOnly<int> valueInstance = new ValueOnly<int>(100);

            InterfaceT<int> interfaceT = new InterfaceT<int>(); //Int32가 'IComparalbe'을 포함하고 있어서 가능하다

            CharacterManager<Character> c1 = new CharacterManager<Character>();
            CharacterManager<Warrior> c2 = new CharacterManager<Warrior>();
            //CharacterManager<Mage> c2 = new CharacterManager<Mage>(); //상속받지 않았기에 사용할 수 없다
        }
    }
}
