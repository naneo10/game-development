using System;
using System.Runtime.InteropServices;
namespace _20250905_day2
{
    /*
     자료형(DataType)
      -자료(데이터)의 형태를 지정 -> 데이터를 어떤 종류로 저장할 것인가? 컴퓨터에게 알려주는 약속
      -데이터가 메모리에 저장되는 형태와 처리되는 방식을 명시하는 역할
      -숫자 / 글자, 참과 거짓등을 명확하게 알려주어야 한다.
     
     [숫자 데이터 형식]
      -C#에서는 다양한 숫자 데이터 형식을 제공
      -숫자 데이터 형식은 크게 정수 데이터 형식과 소수점이 있는 실수 데이터 형식으로 나누고
      -다시 부호 있는 숫자와 부호 없는 숫자로 나눔

     [숫자 데이터 형식 종류(정수)]
      이름            형태                     크기                   표현범위                                                    .NET 형식
      sbyte      부호 O 정수형             1byte(8bit)               -128~127                                                    System.SByte
      byte       부호 X 정수형             1byte(8bit)                0~255                                                      System.Byte
      short      부호 O 정수형             2byte(16bit)              -32,768~32,767                                              System.Int16
      ushort     부호 X 정수형             2byte(16bit)               0~65,535                                                   System.UInt16
      int        부호 O 정수형             4byte(32bit)              -2,147,483,638~2,147,483,647                                System.Int32
      uint       부호 X 정수형             4byte(32bit)               0~4,294,967,295                                            System.UInt32
      long       부호 O 정수형             8byte(64bit)              -9,223,372,036,854,775,808~9,223,372,036,854,775,807        System.Int64
      ulong      부호 X 정수형             8byte(64bit)               0~18,446,744,073,709,551,615                               System.UInt64
      nint       부호 O 정수형     4byte(32bit) || 8byte(64bit)       플랫폼에 따라 다름(런타임에서 계산됨)                        System.IntPtr (C# 11 버전 부터)
      unint      부호 X 정수형     4byte(32bit) || 8byte(64bit)       플랫폼에 따라 다름(런타임에서 계산됨)                        System.UIntPtr(C# 11 버전 부터)

        int a = 123;
        System.Int32 b = 123;
                                                                                                        
     [숫자 데이터 형식 종류(실수)]
      이름            형태                  크기               표현범위                                                       .NET 형식
      float           실수                 4byte              ±1.5 x 10-45 에서 ±3.4 x 1038 (~6-9자리 숫자)                   System.Single
      double          실수                 8byte              ±5.0 × 10-324 에서 ±1.7 × 10308 (~15-17자리 숫자)               System.Double
      decimal         실수                16byte              ±1.0 x 10-28 에서 ±7.9228 x 1028 (28-29자리 숫자)               System.Decimal
        
        double a = 12.3;
        System.Double b = 12.3;

     [문자 데이터 형식]
      이름                형태                  크기               표현범위               .NET 형식
      char              문자표현            2byte(16bit)      U+0000에서 U+FFFF로          System.Char
      string     문자열을 표현할 때 사용         (  )          유니코드 문자 시퀀스          System.String
      
        *유니코드 2byte 소모 

     [논리 데이터 형식]
      이름            형태                  크기               표현범위               .NET 형식
      bool           논리형                1byte               참 or 거짓             System.Boolean
     */

    internal class DataType
    {
        static void Main(string[] args)
        {
            //한 프로젝트 안에 메인 메서드는 반드시 한 개(진입점)
            Console.WriteLine("방금 만든 CS파일");
            Console.WriteLine("bool :" + sizeof(bool) + "바이트"); //데이터 크기를 측정
            
            int number = 1234;
            string playerName = "난 홍길동"; //문자열에는 숫자를 담을수 없다
            string monsterName = "디아블로"; //문자와 문자열의 차이 '' 사용불가
            char c = 'A';

            playerName = "난 놀부";

            Console.WriteLine(playerName); //변수명과 초기화를 한 후 다시 초기화할 경우 밑에 구문 적용

            playerName = "난 흥부"; // 출력문 아래 있기에 위의 출력문에 영향을 주지 않음

            Console.WriteLine(playerName);

            playerName = "난 홍길동"; //출력문 아래 있기에 초기화된 변수 값 도출 x

            bool isCheck = true;
        }
    }
}
