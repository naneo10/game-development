
namespace _25._09._15
{
    /*
    [은행 계좌 관리(접근 제한 지정자 활용)]

    요구사항
    1.BankAccount 클래스를 만든다.
    2.BankAccount 클래스는 다음 필드(속성)를 가진다.
    -owner (계좌 주인 이름, private)
    -balance (잔액, private)
    3.BankAccount 클래스에 다음 메서드를 가진다.
    -Deposit(int amount): 입금 가능(public)
    -Withdraw(int amount): 출금 가능(public)
    -ShowInfo(): 계좌 주인과 잔액 출력(public)
    4.Main()에서 계좌를 만들고 입출금 과정을 확인한다.
    */ //구현과제

    /*
    [예시출력]
    홍길동님의 계좌 잔액: 1000원
    500원 입금 -> 현재 잔액: 1500원
    700원 출금 -> 현재 잔액: 800원
    잔액 부족으로 출금할 수 없습니다.
    */ //예시출력

    class BankAccount
    {
        private string owner;
        private int balance = 1000;

        //계좌명 검색
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        //입금 가능
        public int Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"{amount}원 입금 -> 현재 잔액: {balance}");
            return balance;
        }

        //출금 가능
        public  int Withdraw(int amount)
        {
            balance -= amount;
            Console.WriteLine($"{amount}원 출금 -> 현재 잔액: {balance}원");
            if (balance - amount < 1000)
            {
                Console.WriteLine("잔액 부족으로 출금할 수 없습니다.");
            }
            return balance;
        }

        //잔액 출력
        public void ShowInfo()
        {
            Console.WriteLine($"{owner}님의 계좌 잔액: {balance}");
        }
    }

    internal class AssignMent_03
    {
        static void Main ()
        {
            BankAccount account = new BankAccount();
            account.Owner = "홍길북";

            //계좌 정보 호출
            account.ShowInfo();

            //계좌 입금 메서드
            account.Deposit(500);

            //계좌 출금 메서드
            account.Withdraw(800);
        }
    }
}
