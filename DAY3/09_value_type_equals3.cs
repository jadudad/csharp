using static System.Console;

class Program
{
    public static void Main()
    {
        // 1. value type�� �⺻�����δ� == ������ �ȵ˴ϴ�.
        // 2. int�� value type�Դϴ�.
        int n1 = 10;
        int n2 = 20;

        WriteLine($"{n1 == n2}"); // ���� �ƴմϴ�.
                                  // ������ ������ �������� ������� �ֽ��ϴ�.
    }
}
