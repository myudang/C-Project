namespace ConsoleProgram2
{
    internal class Program
    {
        static void Main(string[] args) // 프로그램 시작 지점 (각 프로젝트에서 단 한개만 존재)
        {

            #region 연산자

            /*
            
            A > B : A가 B보다 크다. (>)
            A < B : A가 B보다 작다. (<)
            A >= B : A가 B보다 크거나 같다. (>=)
            A <= B : A가 B보다 작거나 같다. (<=)
            A == B : A와 B가 같다. (==)
            A != B : A와 B가 같지않다. (!=)

            */

            #endregion

            #region 변수와 상수

            /*
            
            변수 : 
            상수 : 프로그램이 실행될 때 더 이상 값을 변경할 수 없는 메모리 공간

            메모리 공간을 갖고 있는 상수를 '심볼릭 상수'라고 한다.
            메모리 공간을 갖고 있지 않는 상수를 '리터럴 상수'라고 한다. 

            컴파일 타임 상수 선언
            const int level = 99;
            level : 심볼릭 상수, 99 : 리터럴 상수. level의 값은 바꿀 수 있지만, 99라는 값 차체는 다른 값으로 바꿀 수 없음

            고정된 값은 상수로 사용한다. 예시) 이름

            */

            #endregion

            int monsterHp = 100;
            int playerHp = 100;
            int playerMp = 50;
            char alphabet = 'A';

            #region if문

            // if문 : 특정 조건을 만족하면 실행되는 명령문

            if (monsterHp > 0) // 조건식
            {
                Console.WriteLine("몬스터가 아직 살아있습니다."); // 조건식이 참이면 실행, 거짓이면 실행되지않음
            }

            #endregion

            #region else if문

            // else if문: if문의 조건이 틀렸지만, else if문의 조건이 맞다면 실행되는 명령문
            // else if문을 사용하려면 if문이 선언되어 있어야 한다.

            if (playerHp > 101)
            {
                Console.WriteLine("캐릭터의 체력이 100보다 큽니다.");
            }

            else if (playerHp > 90) // 조건식
            {
                Console.WriteLine("캐릭터의 체력은 90보다 큽니다."); // 조건식이 참이면 실행, 거짓이면 실행되지않음
                // else if문은 계속 추가할 수 있다.
            }

            #endregion

            #region else문

            // else문 : if문과 else if문이 모두 틀리면 실행되는 명령문
            // else문을 사용하려면 if문이 선언되어 있어야 한다.
            // 단 else if문은 없어도 된다.

            if (playerMp == 100)
            {
                Console.WriteLine("캐릭터의 마나는 100입니다.");
            }

            else if (playerMp != 50)
            {
                Console.WriteLine("캐릭터의 마나는 50이 아닙니다.");
            }

            else
            {
                Console.WriteLine("해당 조건이 없습니다.");
            }

            #endregion

            // if문과 else if문, else문이 모두 있을때 위에서 부터 명령어가 실행되고
            // 조건이 맞는 부분이 실행되면 if문을 빠져나온다.
            // 만약 if문과 else if문이 모두 맞으면 제일 위에 있는 if문만 실행.
            
            #region swtich문

            // switch문 : 어떤 결과에 따라 그 결과부터 실행되는 명령문

            switch (alphabet)
            {
                case 'A': Console.WriteLine("A입니다.");
                    break;
                case 'B': Console.WriteLine("B입니다.");
                    break;
                case 'C': Console.WriteLine("C입니다.");
                    break;
                default: Console.WriteLine("예외 상황 발생.");
                    break;
            }

            #endregion

            #region for문

            // for문 : 초기식을 연산하여 조건식의 결과에 따라 특정 횟수만큼 반복하는 반복문

            /*
            
            1. 초기식
            2. 조건식 < 조건이 참 이라면
            3. 내용 < 한 번 실행
            4. 증감식 < 초기식을 증감
            다시 2번으로 돌아감
            조건식이 거짓일 때까지 반복

            */

            // for문의 조건식이 항상 참이면 무한반복한다.

            for (int i = 1; i <= 5; i++) // 초기식; 조건식; 증감식;
            {
                if (i == 3)
                {
                    Console.WriteLine(i + "입니다.");
                }
                
            }

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(i + "단");
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " * " + j + " = "  + i*j);
                }
            }

            #endregion

            #region 논리연산자

            /*
            
            AND연산자 : 2개의 조건이 모두 참이면 실행되는 연산자. (&&)
            OR 연산자 : 2개의 조건중 하나라도 참이면 실행되는 연산자. (||)


            */

            if(10 == 10 && 10 < 20)
            {
                Console.WriteLine("두 개의 조건이 성립됩니다.");
            }

            if (10 == 10 || 10 == 20)
            {
                Console.WriteLine("두 개중 하나의 조건이 성립됩니다.");
            }

            #endregion


            #region 사분면 알아내기

            int x = 3, y = 2;

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1사분면 입니다.");
                }
                else if (y < 0)
                {
                    Console.WriteLine("4사분면 입니다.");
                }
                else
                {
                    Console.WriteLine("x절편입니다.");
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("2사분면 입니다.");
                }
                else if (y < 0)
                {
                    Console.WriteLine("3사분면 입니다.");
                }
                else
                {
                    Console.WriteLine("x절편입니다.");
                }
            }
            else if (x == 0 || y == 0)
            {
                if(x != 0)
                {
                    Console.WriteLine("x절편 입니다.");
                }
                
                else if(y != 0)
                {
                    Console.WriteLine("y절편 입니다.");
                }

                else
                {
                    Console.WriteLine("원점 입니다.");
                }
            }

            #endregion

            Console.WriteLine("----------------------------------------------------------");

            #region 사분면 알아내기 2

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1사분면 입니다.2");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2사분면 입니다.2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3사분면 입니다.2");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4사분면 입니다.2");
            }
            else if (y == 0 && x > 0 || x < 0)
            {
                Console.WriteLine("x절편 입니다.2");
            }
            else if (x == 0 && y > 0 || y < 0)
            {
                Console.WriteLine("y절편 입니다.2");
            }
            else
            {
                Console.WriteLine("원점 입니다.2");
            }

            #endregion
        }
    }
}