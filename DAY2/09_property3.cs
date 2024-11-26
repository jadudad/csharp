// property는 C# 언어만의 문법입니다. VB.net, C++/CLI에는 없습니다.
// 즉, IL 코드에는 이런 문법이 없습니다.
// => 컴파일러가 "set_Age(), get_Age()" 라는 메소드로 변경하게 됩니다.
// => #1. 아래 코드 빌드해 놓으세요
// => #2. ILDASM 실행해서 "Day2.dll" 열어 보세요.
//    (윈도우 시작 버튼 => "developer ..." 검색해서 실행하고 ILDASM 실행
//    (DAY2/bin/debug/net8.0/day2.dll...)
//

class Person
{
    public int age;

    public int Age
    {
        get { return age; }
        set { if (value > 0 && value < 150) age = value; }
    }

    // 위 코드에 의해서 set_Age, get_Age 메소드가 생성됩니다.
    // => 사용자가 아래처럼 만들면 충돌 발생. 에러입니다.
    // public void set_Age(int a) { age = a; }
    


}


class Program
{
    public static void Main()
    {
        Person p = new Person();

        p.Age = 10;
        int n = p.Age;

        // p.set_Age(3); // C# 1.0때는 이 코드도 가능했습니다. 그런데, 지금은 에러
        
        Console.WriteLine(n);

        // 참고
        int if = 0; // error. if는 키워드, 키워드를 변수 이름으로 사용할 수 없습니다.
                    // (if, switch, int, double, for, foreach)
        int value = 0; // ok.

        // 문맥적 키워드 (context keyword)
        // => 특정 문맥(코드) 안에서만 사용되는 키워드
        // => value는 property의 set에서만 사용됩니다.
        //    다른 곳에서는 사용 안됩니다.
        // => 변수 이름으로 사용가능
    }
}


