// expression bodied - 71 page
using static System.Console;
class Program
{
    public static int Square1(int x)
    {
        return x * x;
    }
    
    // 표현식으로 메소드 구현(expression bodied)라는 문법 - 한줄의 간단한 메소드에만 사용 추천
    public static int Square2(int x) => x * x;

    public static void SayHello() => WriteLine("Hello");

    public static void Main()
    {
        int n = Square1(3);
    }
}