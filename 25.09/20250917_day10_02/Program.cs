namespace _20250917_day10_02
{
    /*
    [일반화(Generic)]
    -데이터 형식에 의존하지 않고 재사용 가능한 코드 작성을 가능하게 하는 기능
    -클래스, 메서드, 인터페이스 등을 정의할 때 데이터 형식을 일반화 하여 다양한 타입에 대해 동일한 코드를 사용할 수 있도록 해준다
    -C#에서 제네릭은 주로 컬렉션 클래스(List, Dictionary<Tkey, TValue>)등에서 많이 사용한다
    -제네릭을 사용하면 다양한 데이터 타입에 대해 동일한 알고리즘을 적용할 수 있어 코드 중복을 줄이고 유지보수를 용의하게 함

    [제네릭의 주요 개념]
    -타입 매개변수: 일반화된 타입을 나타내는 매개변수로, 클래스나 메서드 정의 시에 사용
    -제네릭 클래스: 타입 매개변수를 사용하여 정의된 클래스
    -제네릭 메서드: 타입 매개변수를 사용하여 정의된 메서드
    -제네릭 인터페이스: 타입 매개변수를 사용하여 정의된 인터페이스
    */

    class Utils
    {
        //제네릭 메서드
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void ArrayCopy<T>(T[] source, T[] output)
        {
            for (int i = 0; i < source.Length; i++)
            {
                output[i] = source[i];
            }
        }
    }

    //제네릭 클래스
    class Box<T>
    {
        private T item;
        public void SetItem(T item)
        {
            this.item = item;
        }
        public T GetItem()
        {
            return item;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //제네릭 메서드
            int x = 10, y = 20;
            Utils.Swap(ref x, ref y);
            Console.WriteLine($"{x}, {y}");

            string str1 = "Hellow", str2 = "World";
            Utils.Swap(ref str1, ref str2);
            Console.WriteLine($"{str1}, {str2}");

            int[] iSrc = { 1, 2, 3, 4, 5 };
            float[] fSrc = { 1f, 2f, 3f, 4f, 5f };

            int[] iDst = new int[iSrc.Length];
            float[] fDst = new float[fSrc.Length];

            Utils.ArrayCopy<int>(iSrc, iDst); //일반화 자료형을 매개변수를 통해 추측이 가능한 경우 생략이 가능하다
            Utils.ArrayCopy<float>(fSrc, fDst);

            List<int> iList = new List<int>();

            Box<int> intbox = new Box<int>();

            intbox.SetItem(100);
            Console.WriteLine(intbox.GetItem());

            Box<string> strBox = new Box<string>();
        }
    }
}
