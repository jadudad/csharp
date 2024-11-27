using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);


    public override bool Equals(object? obj)
    {
        Point? other = obj as Point;
        if (other == null) return false;
        return x == other.x && y == other.y;
    }

    // Equals �� override �ϸ� GetHashCode �� ���� override
    // �ϴ� ���� ��Ģ
    // 5���� Hash �����Ҷ� ���� �˴ϴ�.
    public override int GetHashCode()
    {
        return x.GetHashCode() + y.GetHashCode();
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;
        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // p1, p2 : ���� ��ü
        // p3, p4 : �ٸ� ��ü, ���°� ����

        // refeference Ÿ������!
        // #1. == ������
        // => ������ ��ü�ΰ��� ����
        WriteLine($"{p1 == p2}"); // True
        WriteLine($"{p3 == p4}"); // False

        // #2. object �� ���� �����޴� Equals() ���� �޼ҵ�
        // => object �� �⺻ ������ "==" ���
        //    �ᱹ "���� ��ü" �ΰ� ���� 
        // => ������ virtual �޼ҵ� �̹Ƿ� ����ڰ� ������ �����Ҽ� �ִ�
        //    �� ������ "���°� �����Ѱ�?" �� �����ϴ� �ڵ�
        WriteLine($"{p1.Equals(p2)}"); // True
        WriteLine($"{p3.Equals(p4)}"); // True
    }
}