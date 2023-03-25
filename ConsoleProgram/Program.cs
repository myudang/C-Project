namespace ConsoleProgram
{
    internal class Program
    {
        static void Main(string[] args) // 메인 함수
        {

            Console.WriteLine("Hello, World!"); // Console.WriteLine() : 특정 문자열 출력 함수 (개행 O)
            Console.Write("Hello, World"); // Console.Write() : 특정 문자열 출력 함수 (개행 X)
            Console.WriteLine("Hello, World!");

            // 변수란? 데이터를 저장할 수 있는 메모리 공간을 생성하는 것.
            // 메모리 공간을 확보할 때는 자료형을 먼저 선언해준다. (char, int, short, string 등)

            // bool : 1byte (참, 거짓)
            // char : 1byte (문자)
            // short : 2byte (정수)
            // int : 4byte (정수)
            // float : 4byte (실수)
            // double : 8byte (실수)

            // 자료형 선언 예시 : int hp = 100
            // int : 자료형, hp : 변수, 100 : 값(피연산자)

            char grade = 'S'; // char에 값을 대입할때는 '' 사이에 값을 대입
            int hp = 100; // "=" 표시는 오른쪽의 피연산자의 값을 왼쪽의 변수에 저장하는 연산자  (대입 연산자)
            float att = 36.5f; // float에 값을 대입할때는 값 뒤에 f를 붙힘

            Console.WriteLine("grade : " + grade);
            Console.WriteLine("hp : " + hp);
            Console.WriteLine("att : " + att);




        }
    }
}