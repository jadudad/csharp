using System;
using System.Net.Mime;
using static System.Console;


class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // Generic �ȿ��� object �� �Ҽ� �ִ� �۾��ܿ�
    // � ������ �ϰ� �ʹٸ�
    // ��� #1. generic constraint(����) ���
    // => ��� Ÿ�Կ� ����(�޼ҵ� �����Ѵٴ� �ǹ�)�ϴ� �޼ҵ尡 �ƴ�
    // => ����(constraint)�� �����ϴ� ��츸 ��밡���ϴٴ� ��
    public static T Max1<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) < 0 ? b : a;
    }

    // ��� #2. ĳ����
    // => �Ʒ� ó�� �ص� ������ �����ϴ�.
    // => �׷���.. 
    public static T Max2<T>(T a, T b)
    {
        IComparable ia = (IComparable)a;
        IComparable ib = (IComparable)b;

        return ia.CompareTo(ib) < 0 ? b : a;
    }

    public static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        WriteLine($"{Max1(10, 20)}");
        WriteLine($"{Max1("AAA", "CC")}");

        //      Max1(p1, p2);   // ������ ����. IComparable �� �������� ���� Ÿ��

        Max2(10, 20); // ok 
        Max2(p1, p2); // ����.. �׷���, compile time �� �ƴ�
                      // runtime error. ĳ������ ���� �Ѱ�

        Max1(p1, p2); // ������ ����. ���ڰ� ������ �������� ������

    }
}
/*
// ���� : C++ �� C++20 ���� constraint �� �����Ҽ� �ֽ��ϴ�.
template<typename T> require std::is_pointer<T> 
void foo(T a) 
{
    int n = *a;
}

int k = 0;
foo(k); // ���⼭ ������ �ƴϴ�.
*/