using System;
using static System.Console;

class Program
{
    public static void Foo(object obj)
    {
        // Ÿ�� �̸� ���
        Type t = obj.GetType();

        WriteLine($"{t.Name}");

        // obj �� int ���� Ȯ���ϰ� �ʹ�.
        Type t1 = obj.GetType();
        Type t2 = typeof(int);

        if (t1 == t2) { }  // int!!

        if (obj is int) { } // ���ڵ尡 ���������� ��ó�� ���� �ϴ� ��
                            // ��ó�� ��������, �̷��� �ϸ� �˴ϴ�.
                            // �׷���, ������ �˾Ƶμ���

    }

    public static void Main()
    {
        int n = 10;
        string s = "ABC";

        Foo(n);
        Foo(s);
    }
}