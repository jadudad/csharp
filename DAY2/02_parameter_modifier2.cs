using static System.Console;

class Program
{
    // �Ʒ� �޼ҵ��  
    // a + b �� ����� ��ȯ ������ �˷��ְ� 
    // a - b �� ����� out parameter �� ��� �ְ� �ֽ��ϴ�. 
    public static int AddSub(int a, int b, ref int ret)
    {
        ret = a - b;
        return a + b;
    }

    // out parameter modifier : �ʱ�ȭ���� ���� ������ ���� �� �ִ�.
    public static int AddSub2(int a, int b, out int ret)
    {
        ret = a - b;
        return a + b;
    }

    public static void Main()
    {
        // int ret1 = 0;  // �ʱ�ȭ�� ����
        int ret1;              // �ʱ�ȭ���� ���� ����
        // int ret2 = AddSub(5, 3, ref ret1);  // error
        int ret2 = AddSub2(5, 3, out ret1); // ok

        WriteLine($"{ret1}, {ret2}"); // 2, 8

        // out parameter�� �Ʒ� ó���� ��� �����մϴ�.
        // ���� ��ġ���� ���� ����
        int ret3 = AddSub2(5, 2, out int ret4);

        WriteLine($"{ret3}, {ret4}"); // 2, 8

    }
}