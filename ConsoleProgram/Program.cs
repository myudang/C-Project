namespace ConsoleProgram
{
    internal class Program
    {
        static void Main(string[] args) // 메인 함수
        {
            #region WriteLine 설명
            /*
            
            Console.WriteLine("Hello, World!"); // Console.WriteLine() : 특정 문자열 출력 함수 (개행 O)
            Console.Write("Hello, World"); // Console.Write() : 특정 문자열 출력 함수 (개행 X)

            */
            #endregion

            #region 변수 설명
            /*
            
            변수란? 데이터를 저장할 수 있는 메모리 공간을 생성하는 것.
            메모리 공간을 확보할 때는 자료형을 먼저 선언해준다. (char, int, short, string 등)

            bool : 1byte (참, 거짓)
            char : 1byte (문자)
            short : 2byte (정수)
            int : 4byte (정수)
            float : 4byte (실수)
            double : 8byte (실수)
            자료형 선언 예시 : int hp = 100
            int : 자료형, hp : 변수, 100 : 값(피연산자)

            */
            #endregion

            #region 변수의 이름 규칙
            /*
            
            변수의 이름에는 규칙이 있다.
            1.변수의 이름은 숫자로 시작할 수 없다. (예시: int 1count = 1; [X])
            2.변수의 이름으로 키워드를 사용할 수 없다. (예시: int float = 2; [X])
            3.변수의 이름에 공백이 포함될 수 없다. (예시: int league of = 3; [X])
            4.변수의 이름으로 특수문자는 "_" 만이 가능하다. (예시: int league_of = 4; [O], int league$of = 4; [X])
            5.변수의 이름으로 한글도 가능하지만 왠만하면 영어로 사용한다. (예시: int 체력 = 5; [0])
            6.변수의 이름은 대소문자를 구분한다. (예시: int value, int VALUE; [O])
            7.변수의 이름은 중복될 수 없다. (예시: int attack = 7, char attack = attack[X])

            */
            #endregion

            #region 프로그램 실행 순서

            bool condition = true; // true는 1을 반환, false는 0을 반환
            condition = false; // 이미 선언된 변수는 다시 선언하지 않아도 값만 바꿀 수 있다. (값을 새로 덮어 씀)

            int data = 100;
            data = 101;

            float pi = 3.141592f;
            pi = 4.141592f;


            #endregion

            char grade = 'S'; // char에 값을 대입할때는 '' 사이에 값을 대입
            int hp = 100; // "=" 표시는 오른쪽의 피연산자의 값을 왼쪽의 변수에 저장하는 연산자  (대입 연산자)
            float att = 36.5f; // float에 값을 대입할때는 값 뒤에 f를 붙힘

            Console.WriteLine("grade : " + grade);
            Console.WriteLine("hp : " + hp);
            Console.WriteLine("att : " + att);


            

        }
    }
}