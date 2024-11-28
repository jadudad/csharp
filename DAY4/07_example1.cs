using static System.Console;

class Program
{
    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };

        // Array Ŭ���� : ��� ���� �迭�� ��� Ŭ����
        //				  �迭���� �پ��� �۾��� ���� static method����

        // #1. sort �Ϸ���
        // Array.Sort(x);


        // #2. �迭���� ���� �˻�
        // IndexOf : �� �˻�, 2��° ���ڷ� ������
        int ret1 = Array.IndexOf(x, 3);
        WriteLine($"{ret1}");  // 4


        // �迭���� ó�������� "3�� ���"�� ã�� �ʹ�
        // FindIndex : ���� �˻�, 2��° ���ڷ� �޼ҵ� ����
        //			   �޼ҵ�� ���� �Ѱ��̰�, bool ��ȯ�ؾ� �Ѵ�.
        int ret2 = Array.FindIndex(x, Foo);

        WriteLine($"{ret2}");
    }
    public static bool Foo(int a)
    {
        return a % 3 == 0;
    }

}