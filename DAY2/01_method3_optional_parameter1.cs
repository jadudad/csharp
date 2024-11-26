using static System.Console;

// optional Parameter - 76
class Program
{
    // C++ : default parameter
    // C# : optional parameter �̸��� �ٸ���, �ǹ̴� ����
    // Java : ���� ����
    public static void M1(int a, int b = 0, int c = 0)
	{
	 	WriteLine($"{a}, {b}, {c}");
	}
    public static void Main()
    {
        M1(10, 20, 30); // 10, 20, 30
        M1(10, 20);	 	// 10, 20, 0
        M1(10);         // 10, 0, 0

        // named argument�� ��� ��� �����մϴ�.
        M1(10, c: 30);  // 10, 0, 30
    }

    // ���� ����: ������ ���ں��� ���ʴ�θ� ���� �����մϴ�.
    public static void M2(int a, int b = 0, int c) { }     // error
    public static void M2(int a = 0, int b, int c = 0) { } // error

}