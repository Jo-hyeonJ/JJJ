using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 컨트롤 + d 줄 복사 후 붙여넣기
            // 줄에 대고 컨 + c 줄 복사

            Console.WriteLine("World!"); // 출력 명령문
            Console.WriteLine("ssss");
            Console.WriteLine();

            // 자료형 변수명 // 변수를 선언하는 규칙
            // 자료형 : 어떠한 변수에 담기는 값의 종류
            // int : 정수가 담긴다, number : 변수의 이름

            int number; // 변수
            number = 10+20; // number에 숫자를 대입한다 

            Console.WriteLine(number); // number를 출력
            Console.WriteLine();

            // Q. int 자료형 변수 score를 만들고 그곳에 300을 대입해 출력하다.

            int score = 300;
            // number라는 글자와 number변수의 값을 합쳐서 문자로 출력 (+)
            // 출력문에 변수를 넣으면 변수의 값이 출력된다.
            // 출력문에 문자열을 대입하면 문자열이 그대로 출력된다.
            Console.WriteLine("score는 "+score);
            Console.WriteLine();

            // 줄 띄움 여부, 문자열은 쌍따옴표로 가둬야함
            Console.WriteLine("Hello");
            Console.WriteLine("World");

            Console.Write("Hello");
            Console.Write("World");

            Console.WriteLine();

            // 변수
            // = 어떠한 값을 담을 수 있는 공간

            // 변수명
            // = 특정 메모리 영역에 이름을 붙인다.

            // 자료형 (정수, 실수, 문자열, 객체 등등)
            // = 해당 메모리에 어떠한 종류의 값이 들어가는가를 정해준다.
            // 값에 따라 할당 되는 메모리가 달라진다.

            int number1; // 컴퓨터에게 int형 변수 number1을 만들어라 ( = 선언해라)
            number1 = 10; // number1를 영역에 10을 대입하라

            Console.WriteLine();

            // = 기호
            // 우측에 있는 값을 좌측에 대입하라 라는 기호이다.

            Console.WriteLine(number1);

            Console.WriteLine();

            // 값의 초기화
            // = 어떠한 변수에 최초로 값을 대입한다.
            int n = 0; // int 자료형 변수 n을 선언과 동시에 초기화

            // 변수의 규칙
            // 변수는 동일한 이름으로 2개 이상 선언할 수 없다.
            // 왜냐면 특정성을 구분지을수가 없기 때문이다.

            // 자료형의 종류

            // 정수형
            // int : 4 byte 정수형
            // short : 2 byte 정수형
            // char : 1 byte 정수형 [-128~127, 0~255]

            byte a = 128; // 범위를 초과하는 값 대입 시 오류가 발생한다.
            short b = 4000;
            int c = 100000000;

            // unsigned : 부호 없음. 음수 범위만큼 양수의 범위를 확장한다.
            byte d = 128;
            ushort e = 10000;
            uint f = 100000;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


            Console.WriteLine();

            // int a = "sdddsd"; (변수에는 적합한 자료형의 값 밖에 들어가지 않는다.)

            // 실수형
            // = 소수점 이하 값을 포함하는 값

            float aa = 123.456f;
            double bb = 234.5678457;
            decimal cc = 123.412312452m;

            // 문자형
            char aaa = 'a'; // ''안에는 한 글자만 넣을 수 있다.
            string bbb = "AAAA"; // ""안에는 여러 글자를 넣을 수 있다.

            // 논리 자료형
            bool isOn = true;   // 참(true)과 거짓(flase)를 담을 수 있는 자료형

            // 출력문의 서식 지정자
            // = 지정한 형식대로 문자열을 출력해준다.
            // {0} = 서식의 순서를 나타내는 중괄호이다. 괄호 내부에는 수열에 맞는 숫자를 제외한 그 무엇도 들어가선 안된다.
            // 한번 사용된 수열은 중복해서 사용이 가능하다. {0}{0}{0}{0}{0}{0}{0}{0}

            int password = 1234;
            Console.WriteLine("비밀번호는 " + password + "입니다.");

            Console.WriteLine("비밀번호는 {0}입니다.", password);
            //                            ↑ 쉼표 이후 나오는 변수 값을 대입한다.

            Console.WriteLine("문자는 {0}, 문자열은 {1}, 비밀번호는 {2}", aa, bb, password);

            Console.WriteLine();

            // Q. 내 아이디와 비밀번호(숫자), 좋아하는 알파벳을 각각의 변수에 대입한 뒤, 출력해보자.

            string ID = "rea5150";
            int password1 = 123456;
            char fn = 'S';

            Console.WriteLine();

            Console.WriteLine("아이디는 {0}, 비밀번호는 {1}, 좋아하는 알파벳은 {2}이다.", ID, password1, fn);

            // 서식 지정자의 종류

            int money = 1200000;
            Console.WriteLine("남은 돈 : {0:c}", money); // 서식 지정자 내부의 c = 통화로 표시한다.
            Console.WriteLine("남은 돈 : {0:N2}", money); // n자리 수를 .으로 구분하라
            Console.WriteLine("남은 돈 : {0:x}", money); // 16진수로 표현
            Console.WriteLine("남은 돈 : {0:d}", money); // 10진수로 표현
            Console.WriteLine("남은 돈 : {0:p}", money); // 백분율로 표현
                                                      // 더 많은 것은 C# 서식 지정자 검색

            Console.WriteLine();

            // 서식 지정자의 자리 맞춤
            // = 콘솔창의 줄의 자리수를 맞추는 기호

            Console.WriteLine("{0,-10}:{1}", "아이디는 ", ID);
            Console.WriteLine("{0,10}:{1}", "비밀번호는 ", password1);
            Console.WriteLine("{0,-10}:{1}", "알파벳은 ", fn);

            // 문자열 보관법
            Console.WriteLine($"a의 값은: {a}, b의 값은 :{b}");

            string str = "AAA\n"; // \n 띄워쓰기
            string str2 = "BBB\\"; // \을 2번 쓰면 \이 한번 출력된다. \를 시스템 예약어로 인식하는 것을 인위적으로 해제하는 것
            Console.Write(str);
            Console.Write(str2);

            // 주소 형식
            string path = "C:\\Users\\Administrator\\source\\repos\\ConsoleApp2"; // \를 문자열로 인식 시키기
            string path2 = @"C:\Users\Administrator\source\repos\ConsoleApp2"; // @를 붙인 문자열은 \를 예약어로 인식하지 않는다.



        }
    }
}