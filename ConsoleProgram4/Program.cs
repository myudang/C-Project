namespace ConsoleProgram4
{
    // 클래스란? 사용자 정의 데이터 유형으로 속성과 함수가 포함되어 있으며 클래스를 통해 객체를 생산하여 접근하고 사용할 수 있는 집합체

    class Monster
    {
        #region 접근 지정자
        /* 접근 지정자
        접근 지정자는 기본적으로 private로 설정된다
        
        public : 클래스의 속성을 내부나 외부 어디서든지 접근할 수 있는 접근 지정자.
        private : 클래스의 속성을 내부에서만 사용할 수 있으며, 외부와 자기가 상속하고 있는 클래스에서는 접근이 불가능한 접근 지정자
        protected : 클래스의 속성을 내부와 자기가 상속하고 있는 클래스에서만 접근이 가능하며, 외부에서는 접근이 불가능함
        */
        #endregion

        // 바이트 패딩 : 멤버 변수를 메모리에서 cpu로 읽을 때 한번에 읽을 수 있도록 컴파일러가 레지스터 라는 블록에 맞춰서 바이트를 패딩 해주는 최적화 작업
        public char grade; // 1byte
        private int hp; // 4byte
        public double defense; // 8byte


        public void Attack()
        {
            Console.WriteLine("공격"); 
        }
    }

    class Unit
    {
        // 상속이란? 상위 클래스의 속성을 하위 클래스가 사용할 수 있도록 설정해주는 기능
        public string name;
        protected int health;
        private float killScore;

        /*
        생성자 
        클래스의 인스턴스가 생성되는 시점에서 자동으로 호출되는 특수한 멤버 함수
        */
        public Unit()
        {
            // 생성자의 경우 객체가 생성될 때 단 한 번만 호출되며, 생성자는 반환형이 존재하지 않는다.
            Console.WriteLine("Unit 클래스가 생성되었습니다.");
        }
    }

    class ArrayList
    {
        
    }

    class Marine : Unit // Marine에 Unit을 상속함
    {
        public Marine()
        {
            Console.WriteLine("Marine 클래스가 생성되었습니다.");
        }

        // 함수의 오버로딩 : 같은 이름의 함수를 매개 변수의 자료형과 매개 변수의 갯수로 구분하여 여러 개를 선언할 수 있는 기능 

        public void Information()
        {
            name = "Marine";
            health = 50;
            // killScore = 14; : 얘는 Unit에만 쓸 수 있음. Marine에서는 사용할 수 없다.
        }

        public void Skill()
        {
            Console.WriteLine("Steam Pack");
        }

        public void Skill(int damage)
        {
            Console.WriteLine("Damage : " + damage);
        }

        public void Skill(string name)
        {
            Console.WriteLine("Skill Name : " + name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            #region 클래스

            Monster monster1 = new Monster();
            monster1.grade = 'A';
            monster1.Attack();

            Monster monster2 = new Monster();
            monster2.grade = 'B';
            monster2.Attack();

            #endregion

            Console.WriteLine("-------------------------------------------------------");

            #region 배열

            // 배열이란? 같은 자료형의 변수들로 이루어진 유한집합

            //배열의 선언
            int [] itemList = new int[5]; // int는 4byte이고 5개니까 itemList는 20byte

            // 배열의 경우 첫 번째 원소는 0부터 시작
            // itemList[0] = 10;
            // itemList[1] = 20;
            // itemList[2] = 30;
            // itemList[3] = 40;
            // itemList[4] = 50;


            // 배열은 원하는 원소에 값을 저장할 수 있으며, 배열의 크기는 컴파일 되는 시점부터 고정된 메모리를 가지게 된다.
            for(int i = 0; i < itemList.Length; i++) // itemList.Length는 itemList 배열의 길이 (여기서는 5개니까 itemList.Length는 5)
            {
                itemList[i] = (i + 1) * 10;
                Console.WriteLine(itemList[i]);
            }
            /* 
            배열의 장점 : 직접적으로 배열에 관여할 수 있다.
            배열의 단점 : 런타임 시점에 배열의 크기를 변경할 수 없다.
            예시 : GameObject는 시간이 갈수록 늘어나야하는데 더 늘릴 수 없다.
            그래서 나온 것이 리스트(List와 LinkedList)
            List의 장점 : 
            LinkedList의 장점 : 삽입과 삭제가 용이하다.


            */

            #endregion

            Console.WriteLine("-------------------------------------------------------");

            #region 박싱과 언박싱

            // 값 타입 : bool, char, int, struct, long 등
            // 참조 타입 : Class, array, Delegate, objct 등

            // 박싱이란? 값 형식을 참조 형식으로 변환해주는 과정
            // 언박싱이란? 참조 형식을 값 형식으로 변환해주는 과정

            // object는 모든 자료형을 저장할 수 있다. 값 타입과 참조 타입의 최상위
            // 박싱
            int data = 100; // 값 타입
            object obj = data; // 참조 타입
            Console.WriteLine(obj);

            // 언박싱
            int result = (int)obj; // 명시적 형 변환
            Console.WriteLine(result);

            ArrayList arrayList = new ArrayList();
            // arrayList[0] = 10;
            // arrayList[1] = "kim";

            #endregion

            Console.WriteLine("-------------------------------------------------------");

            #region 상속

            // Unit unit = new Unit();
            Marine marine = new Marine();

            Console.WriteLine("-------------------------------------------------------"); 

            marine.Skill(5); // skill damage에 엮임
            marine.Skill("Steam Pack"); // skill name에 엮임
            marine.Skill(10); // skill damage 값 변경

            #endregion

            Console.WriteLine("-------------------------------------------------------");

            #region 네이밍 컨벤션
            /*

            camel case (camel 표기법) : 변수, 매개 변수
            첫 단어를 제외하고 첫 글자를 대문자로 표기하는 표기법
            ex) int countDown; 

            pascal case (pascal 표기법) : 함수, 클래스 이름, 구조체 이름
            단어의 첫 글자를 대문자로 표기하는 표기법
            ex) int PlayerHealth;

            snake case (snake 표기법) : DB에서 주로 사용
            전부 소문자로 표기하고, 단어 사이에 "_" 를 표기하는 표기법
            ex) data_player

            */
            #endregion
        }
    }
}