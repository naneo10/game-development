namespace _20250908_day3
{
    
    internal class Program
    {
            /*
            [증감연산자] ###
            -증감연산자는 ++, -- 기호를 이용하는 연산자로 피연산자의 값을 1증가 또는 감소시킨다.
    
            ++a: 선 증가 후 연산(먼저 증가 후 그 다음 연산)
            a++: 선 연산 후 증가(먼저 연산하고 그 다음 증가)
            --a: 선 감소 후 연산(먼저 감소시키고 그 다음 연산)
            a--: 선 연산 후 감소(먼저 연산하고 그 다음 감소)

            [전위 연산과 후위연산[
            -증감연산자의 위치가 변수의 앞에 위치하는 표현을 전위방식, 뒤에 위치하는 표현을 후위방식이라고 함.
            *연산자를 하나를 호출, 두 개를 호출 처리속도 차이
            num++
            num = num+1
            */
        static void Main(string[] args)
        {
            //int num = 1;
            //num = num + 1;
            //Console.WriteLine(num);

            Console.WriteLine("===증감 연산자===");
            int num = 10;
            Console.WriteLine($"num의 값 : {num}");
            ++num;
            Console.WriteLine($"++num후 num의 값 : {num}");
            num++;
            Console.WriteLine($"num++후 num의 값 : {num}");
            --num;
            Console.WriteLine($"--num후 num의 값 : {num}");
            num--;
            Console.WriteLine($"num--후 num의 값 : {num}");

            int num1 = 10;
            int num2 = 20;
            int c;
            int d;
            c = ++num1;
            Console.WriteLine($"변수 c의 값 : {c}, 변수 num1의 값 : {num1}"); //둘 다 11
            d = num2++;
            //후위방식: 선연산 후 증가
            Console.WriteLine($"변수 d의 값 : {d}, 변수 num2의 값 : {num2}"); //d = 20, num2 = 21


            /*
            [비교연산자(관계연산자)] ###
            //몬스터의 체력이 10이상 이라면 공격을 받을 수 있다.
            참과 거짓으로만 결과가 도출된다.
            a > b   a가 b보다 크다 (초과)
            a < b   a가 b보다 작다 (미만)

            a >= b  a가 b와 같거나 크다
            a <= b  a가 b와 같거나 작다
            a == b  a와 b가 같다
            a != b  a와 b는 같지 않다
            */

            Console.WriteLine("===비교 연산자===");
            int num5 = 1;
            int num6 = 2;

            bool result;
            bool result1;

            result = (num5 > num6); //num5 가 num6보다 큰가?
            result1 = (num5 != num6); //num5와 num6은 같지 않다.

            Console.WriteLine($"{result}"); //False -> 거짓
            Console.WriteLine($"{result1}"); //True -> 참



            /*
            [논리연산자]
            &&: 연산자의 결과는 피연산자가 모두 참인 경우에만 참

            피연산자            연산자           피연산자            결과
            0                   &&              0                   0
            0                   &&              1                   0
            1                   &&              0                   0
            1                   &&              1                   1

            ||: 연산자의 결과는 피연산자 둘중 하나가 참이면 참

            피연산자            연산자           피연산자            결과
            0                   ||              0                   0
            0                   ||              1                   1
            1                   ||              0                   1
            1                   ||              1                   1

            !: 연산자의 결과는 피연산자가 참이면 거짓이고 거짓이면 참
            */

            Console.WriteLine("===논리 연산자===");
            int num7 = 3;
            int num8 = 5;

            bool result4;
            bool result5;
            bool result6;

            result4 = (num7 > 0) && (num8 < 10); //True
            Console.WriteLine(result4);

            result5 = (num7 <= 2) || (num8 > 5); //False
            Console.WriteLine(result5);

            result6 = !(num != 0); //True
            Console.WriteLine(result6);

            /*
            [복합대입연산자]
            += a+=b -> a = a + b 와 같다
            -= a-=b -> a = a - b 와 같다
            *= a*=b -> a = a * b 와 같다
            /= a/=b -> a = a / b 와 같다
            %= a%=b -> a = a % b 와 같다
            <<= a<<=b -> a = a << b 와 같다 //비트연산
            >>= a>>=b -> a = a >> b 와 같다 //이동 시킨다
            |=
            ^=
            &=
            */

            Console.WriteLine("===복합대입 연산자===");
            int x = 5;
            int y = 3;
            x += y; //x = x+y;
            Console.WriteLine(x);

            /*
            [비트연산자]
            -데이터를 비트단위로 처리하는 연산자
            -메모리 공간을 줄여서 성능을 높이는 이점이 있음
            종류       연산식       설명
            &          a&b          두 개의 비트가 모두 1일때 1을 반환
            |          a|b          두 개의 비트 중에 하나가 1일때 1을 반환
            ^          a^b          두 개의 비트가 서로 같지 않을 경우 1을 반환
            ~          ~a           보수연산이라고도 하며 비트를 반전
            <<         a<<3         비트를 이동
            >>         a>>1         비트를 이동

            ** 비트란?
            -2진수 값 하나 (0또는 1)를 저장할 수 있는 최소 메모리 공간을 의미
            -1bit로 표현할 수 있는 데이터수는 1과 0
            -2bit 00, 01, 10, 11
            -3bit 8개
            -1byte는 8bit이므로 256개의 경우를 표현할 수 있음
            */

            Console.WriteLine("===비트 연산자===");
            /*
            128  64  32  16  8  4  2  1
             0    0   0   0  0  0  0  0

            0001 0100       //20
            0001 0000       //16
            ----------------------&
            0001 0000       //16
            */
            int bitNum1 = 20;
            int bitNum2 = 16;

            int bitRes = bitNum1 & bitNum2;
            Console.WriteLine(bitRes);

            //비트를 한 칸씩 옮길 때 마다 2곱, 2나누기
            // 0000 1010
            int shiftNum = 10;
            int shiftRes = shiftNum << 2; //왼쪽으로 옮겨라. 얼마만큼? 2칸
            Console.WriteLine(shiftRes);  //40

            shiftRes = shiftNum >> 1;
            Console.WriteLine(shiftRes);  //5
        }
    }
}
