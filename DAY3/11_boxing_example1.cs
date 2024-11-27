using System;
using static System.Console;

struct Temperature : IComparable
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    // 아래 코드의 그림이 143 page입니다.
    // 핵심은 Main에서 t2 객체 보내지면 obj로 받으면서 복사본 (boxing) 생성된 것!!

    public int CompareTo(object? obj)
    {
        if (obj == null) return 1; // 비교 대상이 null 이면 무조건 크다

        if (obj is Temperature other)
            return Value.CompareTo(other.Value);
        else
            // obj 가 가리키는 것이 Temperature 타입이 아닐때
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