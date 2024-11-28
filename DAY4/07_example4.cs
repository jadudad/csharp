using static System.Console;


class Program
{
    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };

        Array.Sort(x);  // ���� ���� ���� �Դϴ�.

        foreach (int e in x)
            Write($"{e}, "); // 1, 3, 4, 6, 8

        WriteLine(); // ����

        // ���� ���� ������ ������ 
        // �ٽ� : ���Ľ� �ʿ��� 2���� ����� �񱳸� ��� ���� ����ڰ� ����

        Array.Sort(x, Foo); // x�� �迭���� 2���� ��Ҹ� Foo �� ������
                            // 0���� ū���� ������ swap �մϴ�.

        foreach (int e in x)
            Write($"{e}, "); // 1, 3, 4, 6, 8

        WriteLine(); // ����

        //        Comparison<int> c;

    }

    public static int Foo(int a, int b)
    {
        return b.CompareTo(a);
    }



}