using System;
using static System.Console;

struct Temperature : IComparable
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    // �Ʒ� �ڵ��� �׸��� 143 page�Դϴ�.
    // �ٽ��� Main���� t2 ��ü �������� obj�� �����鼭 ���纻 (boxing) ������ ��!!

    public int CompareTo(object? obj)
    {
        if (obj == null) return 1; // �� ����� null �̸� ������ ũ��

        if (obj is Temperature other)
            return Value.CompareTo(other.Value);
        else
            // obj �� ����Ű�� ���� Temperature Ÿ���� �ƴҶ�
            throw new ArgumentException("Bad Argument");
    }
}

class Program
{
    public static void Main()
    {
        Temperature t1 = new Temperature(5.5);
        Temperature t2 = new Temperature(3.3);

        Console.WriteLine($"{t1.CompareTo(t2)}");
    }
}

// 143 pagd