// class도 Generic으로 해도 됩니다.

using System.Drawing;

class Point<T>
{
    //    private T x = 0;
    //    private T y = 0; // error. 임의 타입이 0으로 초기화 될 수 없다. (string일수도 있잖아)

    private T? x = default(T);
    private T? y = default(T);

    public Point(T a, T b)
    {
        x = a;
        y = b;
    }
}

class Program
{
    public static void Main()
    {
        Point<int> p1 = new Point<int>(1, 2);
        Point<double> p2 = new Point<double>(1.1, 2.2);
        
    }
}