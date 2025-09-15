
using System.Security.Cryptography.X509Certificates;

namespace _25._09._15
{
    /*
    [캐릭터 정보 출력하기]

    요구사항
    1.Character 클래스를 만든다.
    2.Character 클래스는 다음 필드(속성)를 가진다.
    -이름(string)
    -레벨(int)
    -체력(int)
    -공격력(int)
    3.Character 클래스에 다음 메서드를 가진다.
    -PrintInfo(): 캐릭터 정보를 출력하는 메서드
    4.Main()에서 Character 객체를 생성하고 정보를 출력한다.
    */ //구현과제

    /*
    [예시출력]
    이름: 홍길동, 레벨: 3, HP: 100, 공격력: 20
    */ //예시출력
    class Character
    {
        private string name = "홍길동";
        private int level = 3;
        private int HP = 100;
        private int Atk = 20;

        //식별자 : https://blog.naver.com/jgt337/220785304967
        //void는 값을 반환하는게 아니기에 매개변수는 빈칸으로 둔다
        public void PrintInfo()
        {
            Console.WriteLine($"이름: {name}, 레벨: {level}, HP: {HP}, 공격력: {Atk}");
        }
    }
    internal class AssignMent_01
    {
        static void Main()
        {
            Character playInfo = new Character();
            playInfo.PrintInfo();
        }
    }
}
