using static System.Console;

// try parse 
class Program
{
	public static void Main()
	{
		// int.Parse : ���ڿ��� ������ ����
		// 
		int n = int.Parse("10");    // ok. ����
        //int n = int.Parse("Hello"); // ���н� ���� �߻�

		// int.TryParse : ���� ����, ����/���� ��ȯ������ ����
		//			      ��� �������� out parameter�� ����
		int ret;
		bool b = int.TryParse("Hello", out ret);
        WriteLine(b);

        bool b2 = int.TryParse("Hello", out int ret2); // �̷��Ե� ����
        WriteLine(b2);

        //      int? ret2 = int.ParseNullable("Hello"); // �� �޼ҵ尡 ������ 
        // ����� ?
        // ����� �����ϴ�.
        // ���� �����ڰ� ��û!~!

    }
}