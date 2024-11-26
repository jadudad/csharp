using static System.Console;

class Program
{
    // ref �� ���� ? out ���� ���� �� ������ ������
    // => swap �� R/W �� ��� �����ؾ� �մϴ�.
    // => out �� �ƴ� ref ���!!
    /*
	public static void Swap(ref int a, ref int b)
	{
		int t = a;
		a = b;
		b = t;
	}
	*/
    // �Ʒ� �ڵ尡 C#�� generic(template) �Դϴ�. ���� �ڼ��� 
    public static void Swap<T>(ref T a, ref T b)
    {
        int t = a;
        a = b;
        b = t;
    }

    public static void Main()
    {
        int x = 1;
        int y = 2;

        Swap(ref x, ref y); // swap(&x, &y)

        // �Ʒ� ����� 2, 1�� �������� Swap �� ����� ������
        WriteLine($"{x}, {y}"); // 2, 1

    }
}