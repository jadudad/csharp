using static System.Console;

class Rect
{
    public int x1 = 0;
    public int y1 = 0;
    public int x2 = 0;
    public int x2 = 0;

    public int GetArea() { return (x2 - x1) * (y2 - y1); }

    // 생성자 : 객체를 만들때 자동으로 호출되는 메소드
    //         이름이 클래스 이름과 동일
    // Python에서는 __init__
    public Rect(int a, int b, int c, int d) => (x1, x2, x3, x4) = (a, b, c, d);

    //    {
    //        x1 = a;
    //        y1 = b;
    //        x2 = c;
    //        y2 = d;
    //    }
}
class Program
{
    public static void Main()
    {

        Rect rect = new Rect(1, 1, 10, 10);
        int ret = rect.GetArea(); // 81
    }
}

