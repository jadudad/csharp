// github.com/codenuri/dscs   DAY4.zip
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;


struct Temperature : IComparable,
                     IComparable<Temperature>,
                     IEquatable<Temperature>
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;

        if (obj is Temperature other)
            return Value.CompareTo(other.Value);
        else
            throw new ArgumentException("Object is not a Temperature");
    }

    public int CompareTo(Temperature other)
    {
        return Value.CompareTo(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return Value == ((Temperature)obj).Value;
    }

    public bool Equals(Temperature other)
    {
        return Value == other.Value;
    }
}

class Program
{
    public static void Main()
    {
        Temperature t1 = new Temperature(5.5);
        Temperature t2 = new Temperature(5.5);

        // 2�� �µ��� ���ϴ� Equals() �����Լ�
        // => value type �� override ���� �ʾƵ� �޸� ���� ��ü�� ��
        // => ����å�� �����Ϸ��� Equals() �� override �ϸ� �ȴ�.
        WriteLine($"{t1.Equals(t2)}");
    }
}



// Equals() : object Ŭ������ �����ϴ� ���� �޼ҵ�
//            ��κ��� Ÿ���� ���� �޼ҵ�
//            ���� ��� ��ü�� Equals() �޼ҵ尡 �ִ�.
//            Boxing ���� ������ �ذ��ϱ� ���� IEquatable<T> ���� 

// CompareTo : ũ�� �񱳰� ������ Ÿ�Ը� �����ϸ� �ȴ�.
//             IComparable �������̽��� ��ӵǾ� �ִ�.
//             Boxing ���� ������ �ذ��ϱ� ���� IComparable<T> �� ����