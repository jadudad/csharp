class Program
{
    public static void Main()
    {
        // 2���� int ���ڸ� �޾Ƽ� ���� ��ȯ�ϴ� ���� ǥ������ ����� ������

        // #1. ��Ȯ�� ǥ������� �غ�����
        Func<int, int, int> f1 = (int a, int b) => { return a + b; };


        // #2. ���� ������ ǥ������� �غ�����
        Func<int, int, int> f2 = (a, b) => a + b; // ���ڰ� 2���̹Ƿ� ()�� �ʿ�
                                                  //                             = $1 + $2; // swift �� �̷��Ե� ����
                                                  //                             = +   // �̷� �� �ֽ��ϴ�.

        Console.WriteLine($"{f1(1, 2)}"); // 3
        Console.WriteLine($"{f2(1, 2)}"); // 3

        //      Foo(1, 2, +); // �����ڵ� ���ڰ� �ɼ� ������ ��� ??
    }
}
// int Add(int a, int b) { return a + b;}