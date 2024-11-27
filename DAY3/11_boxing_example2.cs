using System;
using static System.Console;

struct Temperature : IComparable, IComparable<Temperature>
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;


    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;

        if (obj is Temperature other)
            return Value.CompareTo(other.Value);
        else
            throw new ArgumentException("Bad Argument");
    }

    // �Ʒ� �ڵ�� Boxing ������ �����ϴ� - 146 page �׸�
    public int CompareTo(Temperature other)
    {
        return Value.CompareTo(other.Value);
    }
}

class Program
{
    public static void Main()
    {
        Temperature t1 = new Temperature(5.5);
        Temperature t2 = new Temperature(3.3);

        Console.WriteLine($"{t1.CompareTo(t2)}");


        int n = 10;
        M1(n);     // 1. int ���� ȣ�� - exactly matching
                   // 2. int ������ ������ "object"' ���� ��밡��
    }

    public static void M1(int n) { WriteLine("int"); }
    public static void M1(object obj) { WriteLine("object"); }
}

// Boxing ������ ���� ���� ����