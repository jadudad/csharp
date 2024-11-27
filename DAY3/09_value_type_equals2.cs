using static System.Console;

//class Point
struct Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    /*
    public override bool Equals(object? obj)
    {
        Point? other = obj as Point;
        if (other == null) return false;
        return x == other.x && y == other.y;
    }
    public override int GetHashCode()
    {
        return x.GetHashCode() + y.GetHashCode();
    }
    */
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        
        // #1. value type�� ���� object.ReferenceEquals() ����ϸ� �ȵ˴ϴ�.
        // => ������ Boxing�� �˾ƾ� �մϴ�.
        WriteLine($"{object.ReferenceEquals(p1, p1)}"); // False

        // #2. �Ʒ� �ڵ�� ���� ����. �׷���, ������� �ֽ��ϴ�. (Boxing)
        //     ��� ����
        WriteLine($"{object.Equals(p1,p1)}");
    }
}

//==================================================
// a == b
// a.Equals(b)
// object.Equals(a,b)
// object.ReferenceEquals(a,b)
