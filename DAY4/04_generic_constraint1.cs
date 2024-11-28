using System;
using static System.Console;


class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // int Ÿ�Ը� ������ �޼ҵ�
    /*
    public static int Max(int a, int b) 
    {
		return a < b ? b : a;
    }
    */

    // Max �� Generic ���� �غ�����
    public static T Max<T>(T a, T b)
    {
        //      return a < b ? b : a; // < �� ���� Ÿ�Ը� ����

        // CompareTo �� int �� string ��� ����.
        // ������ ���� - ������ �Ʒ� Foo ����
        return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    {
        WriteLine($"{Max(10, 20)}");
        WriteLine($"{Max("AAA", "CC")}");

        Foo(10, 20);
    }
    public static void Foo<T>(T a, T b)
    {
        a.CompareTo(b); // a�ȿ� CompareTo �� �ִٴ� ������ ����.
                        // �׷��� error


        a.ToString(); // ok. ��κ��� Ÿ�Կ��� �ִ�. onject �� ����

        // �ٽ�
        // Generic �ȿ����� ���ڿ� ���ؼ� object Ÿ������
        // ������ ���길 �Ҽ� �ִ�.

    }
}