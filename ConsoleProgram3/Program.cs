namespace ConsoleProgram3
{
    class GameObject
    {
        int scale;
    }

    internal class Program
    {

        #region 함수 선언

        // void는 값을 반환하지 않는 반환형
        static void Attack() // 함수 선언 : (자료형) (함수의 이름) (매개 변수)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("공격");
            }
        }

        static int Damage() // 반환형이 존재하는 함수는 값을 무조건 반환해야한다.(int 같은 것)
        {
            // 값을 반환할 때 반환형에 알맞는 자료형의 값을 반환해야한다.
            return 100; // int이므로 정수 값 반환
        } // 프로그램이 끝날 때 Damage 함수에 100이라는 값이 반환 됨

        static char Name()
        {
            return 'a';
        } //서브 루틴의 종류

        static float AttackSpeed()
        {
            return 3.5f;
        }

        // 매개 변수란? 함수의 정의에서 전달받은 인수를 함수 내부로 전달하기 위해 사용하는 변수
        static void Stat(int x) // x는 지역 변수
        {
            Console.WriteLine("매개 변수 x의 값은 : " + x + "입니다.");
        }

        static int Cal(int x, int y)
        {
            int c;
            c = x + y;
            return c;
        }

        #endregion

        #region 매개변수 한정자 함수 선언

        // ref 키워드
        static void ItemData(ref int count) // 참조자(ref) : 한 마디로 같은 메모리 값 안에 여러 개의 이름을 사용 하는 것
        {
            count += 100;
        }

        // out 키워드
        static void RaycastHit(out float ray)
        {
            // out 키워드는 함수 내부에 값을 무조건 초기화 해야 한다.
            ray = 99.9f;
        }

        // in 키워드 
        // const 참조자로 받음
        static void ItemInformation(in int data)
        {
            // 읽기 전용
            Console.WriteLine("data의 값은 " + data + "입니다.");
        }



        #endregion

        #region 재귀 함수

        // 재귀 함수란? 어떤 함수에서 자신을 다시 호출하여 작업을 수행하는 함수
        static void Process(int count)
        {
            Console.WriteLine("작업 처리");

            if(count == 1)
            {
                return;
            }

            Process(count - 1);
            
        }

        #endregion

        // 정적 변수 : 프로그램이 실행될 때 메모리에 올라가며, 프로그램이 종료될 때 메모리에서 사라진다. 
        static void Main(string[] args) // 메인 루틴
        {
            #region 함수

            /*
            
            C, C++ : 함수
                     main 함수 외부에 함수 선언 가능.

            C#, JAVA : 메소드 > class가 최소 단위
                       class 내부에 함수(메소드)를 선언해야한다.

            함수란? 하나의 특별한 목적의 작업을 수행하기 위해 독립적으로 설계된 코드의 집합

            메인 루틴을 진행하다가 서브 루틴의 함수를 만나면 잠시 실행을 멈추고 서브 루틴을 진행한다.
            그러다가 서브 루틴의 실행이 종료되면 다시 메인 루틴을 진행한다.

            */

            #endregion

            #region 메모리 영역

            /*
            
            (낮은 주소)
            CODE : 함수의 주소, 리터럴 상수 저장 
            DATA : .rodata > 문자열 저장
                   .data > (초기화가 이루어진) 전역변수, 정적변수 저장
            BSS : (초기화가 이루어지지 않은) 전역변수, 정적변수 저장
            HEAP : 사용자가 직접 할당한 메모리(C#에서는 사용자가 메모리를 해제하지 않아도 된다.) > 
            STACK : 함수 내부에 선언된 변수로 함수 내부에서만 사용가능하고, 함수가 종료되면 메모리에서 해제되는 영역> 지역변수, 매개 변수 저장
            (높은 주소)

            */

            #endregion

            #region 함수의 사용

            // void 함수()
            Attack();
            // int 함수()
            Console.WriteLine("Damage : " + Damage());
            // char 함수()
            Console.WriteLine("Name : " + Name());
            // float 함수()
            Console.WriteLine("AttackSpeed : " + AttackSpeed());
            // void 함수(매개 변수)
            // 인수란? 함수가 호출될 때 매개 변수에 실제로 전달되는 값
            Stat(100); // 여기서 인수의 값은 100
            // int 함수(매개 변수)
            Console.WriteLine("x + y의 값은 " + Cal(10, 20) + "입니다.   "); //매개 변수가 2개였으니 인수도 2개를 사용

            #endregion

            Console.WriteLine("-------------------------------------------------------");

            #region 매개변수 한정자 함수 사용

            int item = 100;
            ItemData(ref item);
            Console.WriteLine("item의 값은 " + item + "입니다.");

            // out 키워드는 외부의 변수를 초기화하지 않아도 인수로 전달할 수 있다.
            float ray; // 얘를 초기화 하지 않아도 된다.
            RaycastHit(out ray);
            Console.WriteLine("ray의 값은 " + ray + "입니다.");

            // in 키워드는 무언가를 수정 하면 안될때 읽기 전용으로 되게 사용한다.
            int database = 30;
            ItemInformation(database);

            #endregion

            Console.WriteLine("-------------------------------------------------------");

            #region 재귀 함수 사용

            Process(3);

            #endregion
           

        }
    }
}