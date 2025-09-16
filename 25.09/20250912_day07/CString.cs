
namespace _20250912_day07
{
    /*
    [string]
    -string은 문자열(문자의 연속)을 저장하는 참조형
    -System.String 이라는 클래스로 구현되어 있음
    -한 번 생성된 문자열은 수정할 수 없음. 변경되는 것 처럼 보이지만 새로운 문자열을 생성하기 때문
    */
    internal class CString
    {
        static void Main ()
        {
            string str = "asdfasdfasdf";
            str = "asdf";
            Console.WriteLine(str);

            string str1 = "abcde"; //내부적으로 인덱서 형태로 구현되어있기에 / 배열형태로 접근 가능
            Console.WriteLine(str1[0]);
            //str[1] = 'c'; //문자열의 배열접근은 읽기 전용이다

            string str2 = "Hello";
            string str3 = "World";

            string st4 = str2 + " " + str3; //오버로딩 // +연산자로 문자열을 연결
            Console.WriteLine(st4);

            /*
            [string 불변성]
            -다른 기본자료형과 다르게 크기가 졍해져 있지 않음(charactor의 집합이므로 갯수에 따라 크기가 유동적)
            -기본자료형과 같이 값 형식을 구현하기 위해 string클래스에 처리를 값 형식처럼 동작하도록 구현
            -이를 구현하기 위해 string같의 대입이 있을 경우 참조에 의한 주소 값 복사
            -결과적으로 데이터 자체를 복사하는 값 형식으로 사용하지만 힙 영역을 사용하기 때문에 string이 설정되면 변경할 수 없다
            */

            string str5 = "abcde";  //힙 영역에 abcded 문자열이 생성되고 스택에 저장되어 있는 str5가 참조로 가게된다
            str5 = "abc";           //새로운 힙 영역에 abc가 생성되고 str5가 이를 참조하도록 변경된다
                                    //agcded는 Garbage Collector에 의해 정리가 됨

            str5 = str5 + "123";    //"abc" + "123" 새로운 힙 영역에 abc123이 생성되고 참조가 됨

            string str6 = str5;     //str5, str6 같은 힙 영역을 참조한다
            Console.WriteLine(str5);
            Console.WriteLine(str6);
            Console.WriteLine(object.ReferenceEquals(str5, str6));

            str5 = "asdfasdfasdfasdf";
            Console.WriteLine(str5); //같은 영역을 참조했더라도 둘 중 하나가 수정하여도 서로 영향을 주지 않음
            Console.WriteLine(str6);
            Console.WriteLine(object.ReferenceEquals(str5, str6));

            string str7 = "Hellow"; //부등호로 할당이 아니라 직접 할당해도 같은 힙 영역을 참조함
            string str8 = "Hellow";
            Console.WriteLine(object.ReferenceEquals(str7, str8));

            //문자열을 붙이기
            string str10 = "abc" + 123 + "def" + 456;
        }
    }
}
