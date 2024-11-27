using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Point))
            return false;

        Point p = (Point)obj;

        return x == p.x && y == p.y;
    }

    public override int GetHashCode()
    {
        return x.GetHashCode() + y.GetHashCode();
    }

    // ������ ������ ������ 5���� ����.. 
    // ������ "==" �� ������ �Ҽ� �ִ�������.. 
    // == ���ǽ� != �� ���� �ؾ� �մϴ�.
    public static bool operator ==(Point p1, Point p2)
    {
        return p1.x == p2.x && p1.y == p2.y;
    }
    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
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

        // #1. == �� �⺻������ "���ϰ�ü" �ΰ��� ���� ���� �Դϴ�.
        // => �׷���, "������ ������ ��������" "==" �� ������ �����Ҽ� �ֽ��ϴ�.
        WriteLine($"{p3 == p4}");   // True		
                                    // ������ ���ϼ� ����

        // #2. �̰�� ��ü�� �����Ѱ��� �����Ϸ��� �Ʒ� ó�� �ϼ���
        // => Point �� �ƴ� object Ÿ�Կ� ���ؼ� == �������� �ش޶�� ��
        WriteLine($"{(object)p3 == (object)p4}"); // False


        WriteLine($"{ReferenceEquals(p3, p4)}");

        // �Ʒ� object.ReferenceEquals �� �츮�� ����
        // "ReferenceEquals" �� ����
        WriteLine($"{object.ReferenceEquals(p3, p4)}");
    }

    public static bool MyReferenceEquals(object? a, object? b)
    {
        return a == b;
    }
}

// p3 == p4�� �ϸ� ������ �����ǵ� == �� ȣ�������
// (object)p3 == (object)p4�� �ϸ� object Ÿ���� == ���� ��ü�� ���ϼ� ���� ����

// object.ReferenceQeuals(p3,pp4) �ǵ���
// p3, p4�� object�� �����ؼ� == �ϱ� ���� �����

// ����
// #1. ��ü�� �������� �����ϰ� �ʹ�.
// => p1 == p2�� ���������� == ������ �����ǰ� �Ǿ��ٸ� �ٸ��� �����Ѵ�.
// => object.ReferenceEquals(p1, p2)�� ����. (������ �̰ɷ� �ϼ���)

// #2. ���°� �������� �����ϰ� �ʹ�.
// => p1.Equals(p2)�� �ǰ� ���� ���������
// => object.Equals(p1,p2)�� �� �� ȿ������ �ڵ�

// ��� : ��ü�� ���ϼ� ����� "object�� static method 2���� ����ض�"
